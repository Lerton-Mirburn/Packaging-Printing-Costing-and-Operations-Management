CREATE TABLE Roles (
    role_id INT IDENTITY(1,1) PRIMARY KEY,
    role_name VARCHAR(50) NOT NULL
);

CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    role_id INT,
    FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);

CREATE TABLE Customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    address VARCHAR(200),
    email VARCHAR(100)
);

CREATE TABLE Suppliers (
    supplier_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_name VARCHAR(100),
    phone VARCHAR(20),
    address VARCHAR(200),
    email VARCHAR(100)
);

CREATE TABLE Materials (
    material_id INT IDENTITY(1,1) PRIMARY KEY,
    material_name VARCHAR(100),
    unit VARCHAR(20),
    price DECIMAL(10,2)
);

CREATE TABLE Quotations (
    quotation_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    quotation_date DATE,
    total_price DECIMAL(12,2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

CREATE TABLE Quotation_Details (
    detail_id INT IDENTITY(1,1) PRIMARY KEY,
    quotation_id INT,
    description VARCHAR(200),
    cost DECIMAL(10,2),
    FOREIGN KEY (quotation_id) REFERENCES Quotations(quotation_id)
);

CREATE TABLE Purchase_Orders (
    po_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_id INT,
    order_date DATE,
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);

CREATE TABLE Purchase_Order_Details (
    po_detail_id INT IDENTITY(1,1) PRIMARY KEY,
    po_id INT,
    material_id INT,
    quantity INT,
    price DECIMAL(10,2),
    FOREIGN KEY (po_id) REFERENCES Purchase_Orders(po_id),
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);

CREATE TABLE Production_Orders (
    production_id INT IDENTITY(1,1) PRIMARY KEY,
    quotation_id INT,
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (quotation_id) REFERENCES Quotations(quotation_id)
);

CREATE TABLE Inventory (
    inventory_id INT IDENTITY(1,1) PRIMARY KEY,
    material_id INT,
    quantity INT,
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);

CREATE TABLE Stock_Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    material_id INT,
    transaction_type VARCHAR(20),
    quantity INT,
    transaction_date DATE,
    FOREIGN KEY (material_id) REFERENCES Materials(material_id)
);

CREATE TABLE Debts (
    debt_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_id INT,
    amount DECIMAL(12,2),
    debt_date DATE,
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);

CREATE TABLE Payments (
    payment_id INT IDENTITY(1,1) PRIMARY KEY,
    debt_id INT,
    payment_amount DECIMAL(12,2),
    payment_date DATE,
    FOREIGN KEY (debt_id) REFERENCES Debts(debt_id)
);
INSERT INTO Roles
VALUES ('Admin');
INSERT INTO Users (username, password, email, role_id)
VALUES ('admin', '123', 'admin@gmail.com', 1);