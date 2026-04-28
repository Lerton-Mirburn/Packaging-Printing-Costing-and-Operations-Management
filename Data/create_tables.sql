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
    price_per_ton INT
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
