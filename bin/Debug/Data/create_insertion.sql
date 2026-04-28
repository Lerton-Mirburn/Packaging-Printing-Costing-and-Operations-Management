
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