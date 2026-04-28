/* PROCEDURES */

CREATE PROCEDURE sp_insert_customer
    @customer_name NVARCHAR(100),
    @phone VARCHAR(20),
    @address NVARCHAR(200),
    @email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Customers(customer_name, phone, address, email)
    VALUES (@customer_name, @phone, @address, @email);
END;
GO

CREATE PROCEDURE sp_insert_supplier
    @supplier_name NVARCHAR(100),
    @phone VARCHAR(20),
    @address NVARCHAR(200),
    @email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Suppliers(supplier_name, phone, address, email)
    VALUES (@supplier_name, @phone, @address, @email);
END;
GO

CREATE PROCEDURE sp_insert_material
    @material_name NVARCHAR(100),
    @unit NVARCHAR(20),
    @price DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Materials(material_name, unit, price)
    VALUES (@material_name, @unit, @price);
END;
GO

CREATE PROCEDURE sp_create_quotation
    @customer_id INT,
    @quotation_date DATE,
    @customer_name NVARCHAR(200),
    @addresses NVARCHAR(300),
    @product_name NVARCHAR(200),
    @expiry NVARCHAR(100),
    @delivery_time NVARCHAR(100),
    @profit FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Quotations(
        customer_id, quotation_date, total_price,
        customer_name, addresses, product_name,
        expiry, delivery_time, profit
    )
    VALUES (
        @customer_id, @quotation_date, 0,
        @customer_name, @addresses, @product_name,
        @expiry, @delivery_time, @profit
    );

    SELECT SCOPE_IDENTITY() AS quotation_id;
END;
GO

CREATE PROCEDURE sp_add_quotation_detail
    @quotation_id INT,

    @prodX FLOAT,
    @prodY FLOAT,
    @prodZ FLOAT,

    @product_amount INT,
    @color_amount INT,
    @units_per_sheet INT,

    @print_length FLOAT,
    @print_width FLOAT,
    @waste_sheet INT,

    @big_printer BIT,

    @paper_type_id INT,

    @uv_frame_cost DECIMAL(12,2),
    @diecut_frame_cost DECIMAL(12,2),
    @delivery_and_proof DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Quotation_Details(
        quotation_id,
        prodX, prodY, prodZ,
        product_amount, color_amount, units_per_sheet,
        print_length, print_width, waste_sheet,
        big_printer,
        paper_type_id,
        uv_frame_cost, diecut_frame_cost, delivery_and_proof
    )
    VALUES (
        @quotation_id,
        @prodX, @prodY, @prodZ,
        @product_amount, @color_amount, @units_per_sheet,
        @print_length, @print_width, @waste_sheet,
        @big_printer,
        @paper_type_id,
        @uv_frame_cost, @diecut_frame_cost, @delivery_and_proof
    );
END;
GO

CREATE PROCEDURE sp_get_paper_types
AS
BEGIN
    SELECT 
        paper_type_id,
        paper_name,
        gsm,
        price_per_ton
    FROM PaperTypes;
END
GO

CREATE PROCEDURE sp_create_purchase_order
    @supplier_id INT,
    @order_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Purchase_Orders(supplier_id, order_date)
    VALUES (@supplier_id, @order_date);
END;
GO

CREATE PROCEDURE sp_add_purchase_order_detail
    @po_id INT,
    @material_id INT,
    @quantity INT,
    @price DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF @quantity <= 0
        THROW 50001, N'Số lượng phải lớn hơn 0', 1;

    IF @price < 0
        THROW 50002, N'Đơn giá không hợp lệ', 1;

    INSERT INTO Purchase_Order_Details(po_id, material_id, quantity, price)
    VALUES (@po_id, @material_id, @quantity, @price);
END;
GO

CREATE PROCEDURE sp_create_production_order
    @quotation_id INT,
    @start_date DATE,
    @end_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @end_date < @start_date
        THROW 50003, N'Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu', 1;

    INSERT INTO Production_Orders(quotation_id, start_date, end_date)
    VALUES (@quotation_id, @start_date, @end_date);
END;
GO

CREATE PROCEDURE sp_import_stock
    @material_id INT,
    @quantity INT,
    @transaction_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @exists INT = 0;

    IF @quantity <= 0
        THROW 50004, N'Số lượng nhập phải lớn hơn 0', 1;

    INSERT INTO Stock_Transactions(material_id, transaction_type, quantity, transaction_date)
    VALUES (@material_id, 'IN', @quantity, @transaction_date);

    SELECT @exists = COUNT(*)
    FROM Inventory
    WHERE material_id = @material_id;

    IF @exists = 0
    BEGIN
        INSERT INTO Inventory(material_id, quantity)
        VALUES (@material_id, dbo.fn_inventory_quantity(@material_id));
    END
    ELSE
    BEGIN
        UPDATE Inventory
        SET quantity = dbo.fn_inventory_quantity(@material_id)
        WHERE material_id = @material_id;
    END
END;
GO

CREATE PROCEDURE sp_export_stock
    @material_id INT,
    @quantity INT,
    @transaction_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @current_stock INT = 0;
    DECLARE @exists INT = 0;

    IF @quantity <= 0
        THROW 50005, N'Số lượng xuất phải lớn hơn 0', 1;

    SELECT @current_stock = dbo.fn_inventory_quantity(@material_id);

    IF @current_stock < @quantity
        THROW 50006, N'Không đủ tồn kho để xuất', 1;

    INSERT INTO Stock_Transactions(material_id, transaction_type, quantity, transaction_date)
    VALUES (@material_id, 'OUT', @quantity, @transaction_date);

    SELECT @exists = COUNT(*)
    FROM Inventory
    WHERE material_id = @material_id;

    IF @exists = 0
    BEGIN
        INSERT INTO Inventory(material_id, quantity)
        VALUES (@material_id, dbo.fn_inventory_quantity(@material_id));
    END
    ELSE
    BEGIN
        UPDATE Inventory
        SET quantity = dbo.fn_inventory_quantity(@material_id)
        WHERE material_id = @material_id;
    END
END;
GO

CREATE PROCEDURE sp_create_debt
    @supplier_id INT,
    @amount DECIMAL(12,2),
    @debt_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @amount <= 0
        THROW 50007, N'Số tiền công nợ phải lớn hơn 0', 1;

    INSERT INTO Debts(supplier_id, amount, debt_date)
    VALUES (@supplier_id, @amount, @debt_date);
END;
GO

CREATE PROCEDURE sp_pay_debt
    @debt_id INT,
    @payment_amount DECIMAL(12,2),
    @payment_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @remaining DECIMAL(12,2) = 0;

    IF @payment_amount <= 0
        THROW 50008, N'Số tiền thanh toán phải lớn hơn 0', 1;

    SELECT @remaining = dbo.fn_remaining_debt(@debt_id);

    IF @payment_amount > @remaining
        THROW 50009, N'Số tiền thanh toán vượt quá công nợ còn lại', 1;

    INSERT INTO Payments(debt_id, payment_amount, payment_date)
    VALUES (@debt_id, @payment_amount, @payment_date);
END;
GO

CREATE PROCEDURE sp_get_import_stock_list
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        st.transaction_id,
        m.material_name,
        st.quantity,
        st.transaction_date
    FROM Stock_Transactions st
    JOIN Materials m ON st.material_id = m.material_id
    WHERE st.transaction_type = 'IN'
    ORDER BY st.transaction_date DESC;
END;
GO

CREATE PROCEDURE sp_CheckLogin
    @username VARCHAR(50),
    @password VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT user_id, username, email, full_name, state, role_id
    FROM Users
    WHERE username = @username 
      AND [password] = @password 
      AND state = 1;
END;
GO

CREATE PROCEDURE sp_GetUsers
AS
BEGIN
    SELECT 
        u.user_id,
        u.username,
        u.email,
        u.full_name,
        u.role_id,
        ISNULL(r.role_name, N'Unknown') AS role_name,
        CASE 
            WHEN u.state = 1 THEN N'Active'
            WHEN u.state = 0 THEN N'Inactive'
            WHEN u.state = 2 THEN N'Deactivated'
            ELSE N'Unknown'
        END AS state_text
    FROM Users u
    LEFT JOIN Roles r ON u.role_id = r.role_id
END
GO

CREATE PROCEDURE sp_AddUsers
    @username VARCHAR(50),
    @password VARCHAR(100),
    @email VARCHAR(100),
    @full_name NVARCHAR(100),
    @state TINYINT,
    @role_id INT
AS
BEGIN
    INSERT INTO Users (username, [password], email, full_name, state, role_id)
    VALUES (@username, @password, @email, @full_name, @state, @role_id);
END
GO 

CREATE PROCEDURE sp_GetRoles
AS
BEGIN
    SELECT role_id, role_name
    FROM Roles
END
GO

CREATE PROCEDURE sp_UpdateUser
    @user_id INT,
    @full_name NVARCHAR(100),
    @email VARCHAR(100),
    @role_id INT
AS
BEGIN
    UPDATE Users
    SET 
        email = @email,
        full_name = @full_name,
        role_id = @role_id
    WHERE user_id = @user_id;
END
GO

CREATE PROCEDURE sp_DeleteUser
    @user_id INT
AS
BEGIN
    DELETE FROM Users
    WHERE user_id = @user_id;
END
GO


CREATE PROCEDURE sp_ToggleUserState
    @user_id INT
AS
BEGIN
    UPDATE Users
    SET state = 
        CASE 
            WHEN state = 2 THEN 1 -- activate
            ELSE 2                -- deactivate
        END
    WHERE user_id = @user_id;
END
GO

CREATE PROCEDURE sp_SaveOTP
    @email VARCHAR(100),
    @otp VARCHAR(6),
    @expiry DATETIME
AS
BEGIN
    INSERT INTO PasswordResets (email, otp_code, expiry_time)
    VALUES (@email, @otp, @expiry);
END;
GO

CREATE PROCEDURE sp_VerifyOTP
    @email VARCHAR(100),
    @otp VARCHAR(6)
AS
BEGIN
    SELECT COUNT(*)
    FROM PasswordResets
    WHERE email = @email 
      AND otp_code = @otp 
      AND expiry_time > GETDATE() 
      AND is_used = 0;
END;
GO

CREATE PROCEDURE sp_UpdatePassword
    @email VARCHAR(100),
    @new_password VARCHAR(100)
AS
BEGIN
    UPDATE Users SET [password] = @new_password WHERE email = @email;
    UPDATE PasswordResets SET is_used = 1 WHERE email = @email;
END;
GO
