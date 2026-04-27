USE PPCOM;
GO

CREATE TABLE Roles (
    role_id INT IDENTITY(1,1) PRIMARY KEY,
    role_name NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    [password] VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE,
    full_name NVARCHAR(100) NOT NULL,
    state TINYINT NOT NULL DEFAULT 0, 
    role_id INT,
    FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);
GO

CREATE TABLE PasswordResets (
    id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(100) NOT NULL,
    otp_code VARCHAR(6) NOT NULL,
    expiry_time DATETIME NOT NULL,
    is_used BIT DEFAULT 0
);
GO

CREATE TABLE Customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name NVARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    address NVARCHAR(200),
    email VARCHAR(100)
);
GO

CREATE TABLE Suppliers (
    supplier_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_name NVARCHAR(100),
    phone VARCHAR(20),
    address NVARCHAR(200),
    email VARCHAR(100)
);
GO

CREATE TABLE Materials (
    material_id INT IDENTITY(1,1) PRIMARY KEY,
    material_name NVARCHAR(100),
    unit NVARCHAR(20),
    price DECIMAL(10,2)
);
GO

CREATE TABLE Quotations (
    quotation_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    quotation_date DATE,
    total_price DECIMAL(12,2),
    customer_name NVARCHAR(200),
    addresses NVARCHAR(300),
    product_name NVARCHAR(200),
    expiry NVARCHAR(100),
    delivery_time NVARCHAR(100),
    profit FLOAT,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);
GO

CREATE TABLE Quotation_Details (
    detail_id INT IDENTITY(1,1) PRIMARY KEY,
    quotation_id INT,

    prodX FLOAT,
    prodY FLOAT,
    prodZ FLOAT,

    product_amount INT,
    color_amount INT,
    units_per_sheet INT,

    print_length FLOAT,
    print_width FLOAT,
    waste_sheet INT,

    big_printer BIT,

    paper_type_id INT,

    uv_frame_cost DECIMAL(12,2),
    diecut_frame_cost DECIMAL(12,2),
    delivery_and_proof DECIMAL(12,2),

    FOREIGN KEY (quotation_id) REFERENCES Quotations(quotation_id)
);
GO

CREATE TABLE PaperTypes (
    paper_type_id INT IDENTITY(1,1) PRIMARY KEY,
    paper_name NVARCHAR(100),
    gsm INT,
    price_per_ton DECIMAL(18,2)
);
GO

CREATE TABLE Purchase_Orders (
    po_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_id INT,
    order_date DATE,
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);
GO

CREATE TABLE Purchase_Order_Details (
    po_detail_id INT IDENTITY(1,1) PRIMARY KEY,
    po_id INT,
    material_id INT,
    quantity INT,
    price DECIMAL(10,2),
    FOREIGN KEY (po_id) REFERENCES Purchase_Orders(po_id),
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);
GO

CREATE TABLE Production_Orders (
    production_id INT IDENTITY(1,1) PRIMARY KEY,
    quotation_id INT,
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (quotation_id) REFERENCES Quotations(quotation_id)
);
GO

CREATE TABLE Inventory (
    inventory_id INT IDENTITY(1,1) PRIMARY KEY,
    material_id INT,
    quantity INT,
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);
GO

CREATE TABLE Stock_Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    material_id INT NOT NULL,
    transaction_type VARCHAR(20) 
        CHECK (transaction_type IN ('IN', 'OUT')),
    quantity INT NOT NULL,
    transaction_date DATE,
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);
GO

CREATE TABLE Debts (
    debt_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_id INT,
    amount DECIMAL(12,2),
    debt_date DATE,
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);
GO

CREATE TABLE Payments (
    payment_id INT IDENTITY(1,1) PRIMARY KEY,
    debt_id INT,
    payment_amount DECIMAL(12,2),
    payment_date DATE,
    FOREIGN KEY (debt_id) REFERENCES Debts(debt_id)
);
GO

/* FUNCTIONS */

CREATE FUNCTION fn_total_quotation_amount (@quotation_id INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @total DECIMAL(12,2);

    SELECT @total = ISNULL(SUM(cost), 0)
    FROM Quotation_Details
    WHERE quotation_id = @quotation_id;

    RETURN @total;
END;
GO

CREATE FUNCTION fn_total_purchase_order_amount (@po_id INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @total DECIMAL(12,2);

    SELECT @total = ISNULL(SUM(quantity * price), 0)
    FROM Purchase_Order_Details
    WHERE po_id = @po_id;

    RETURN @total;
END;
GO

CREATE FUNCTION fn_inventory_quantity (@material_id INT)
RETURNS INT
AS
BEGIN
    DECLARE @in_qty INT = 0;
    DECLARE @out_qty INT = 0;

    SELECT @in_qty = ISNULL(SUM(quantity), 0)
    FROM Stock_Transactions
    WHERE material_id = @material_id
      AND transaction_type = 'IN';

    SELECT @out_qty = ISNULL(SUM(quantity), 0)
    FROM Stock_Transactions
    WHERE material_id = @material_id
      AND transaction_type = 'OUT';

    RETURN @in_qty - @out_qty;
END;
GO

CREATE FUNCTION fn_total_paid_of_debt (@debt_id INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @total_paid DECIMAL(12,2);

    SELECT @total_paid = ISNULL(SUM(payment_amount), 0)
    FROM Payments
    WHERE debt_id = @debt_id;

    RETURN @total_paid;
END;
GO

CREATE FUNCTION fn_remaining_debt (@debt_id INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @amount DECIMAL(12,2) = 0;
    DECLARE @paid DECIMAL(12,2) = 0;

    SELECT @amount = ISNULL(amount, 0)
    FROM Debts
    WHERE debt_id = @debt_id;

    SELECT @paid = dbo.fn_total_paid_of_debt(@debt_id);

    RETURN @amount - @paid;
END;
GO

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

/* INSERT DATA */

INSERT INTO Roles (role_name)
VALUES
(N'Admin'),
(N'Nhân viên báo giá'),
(N'Nhân viên mua hàng'),
(N'Nhân viên kho'),
(N'Nhân viên kế toán');
GO

INSERT INTO Users (username, [password], email, full_name, state, role_id)
VALUES
('admin', 'admin', 'admin@gmail.com', N'Administrator', 1, 1),
('baogia01', '123456', 'baogia01@gmail.com', N'Báo Giá 01', 1, 2),
('baogia02', '123456', 'baogia02@gmail.com', N'Báo Giá 02', 1, 2),
('muahang01', '123456', 'muahang01@gmail.com', N'Mua Hàng 01', 1, 3),
('muahang02', '123456', 'muahang02@gmail.com', N'Mua Hàng 02', 1, 3),
('kho01', '123456', 'kho01@gmail.com', N'Kho 01', 1, 4),
('kho02', '123456', 'kho02@gmail.com', N'Kho 02', 1, 4),
('ketoan01', '123456', 'ketoan01@gmail.com', N'Kế Toán 01', 1, 5),
('ketoan02', '123456', 'ketoan02@gmail.com', N'Kế Toán 02', 1, 5);
GO

INSERT INTO Materials (material_name, unit)
VALUES 
(N'Giấy A4', N'Tờ'),
(N'Mực in', N'Chai'),
(N'Bao bì', N'Cái');
GO

INSERT INTO Stock_Transactions (material_id, quantity, transaction_type, transaction_date)
VALUES 
(1, 100, 'IN', GETDATE()),
(2, 50, 'IN', GETDATE()),
(3, 200, 'IN', GETDATE());
GO

INSERT INTO PaperTypes (paper_name, gsm, price_per_ton)
VALUES 
(N'Ivory 400', 400, 28100000);
GO