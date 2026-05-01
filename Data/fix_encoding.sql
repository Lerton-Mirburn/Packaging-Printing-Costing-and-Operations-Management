
/* 
   FIX MOJIBAKE ENCODING IN DATABASE 
   This script fixes characters that were incorrectly inserted due to encoding mismatches.
   Run this in SQL Server Management Studio (SSMS) or your SQL tool.
*/

-- Fix Roles
UPDATE Roles SET role_name = N'Nhân viên báo giá' WHERE role_name LIKE '%nhÃ¢n viÃªn%';
UPDATE Roles SET role_name = N'Nhân viên báo giá' WHERE role_id = 2;
UPDATE Roles SET role_name = N'Nhân viên mua hàng' WHERE role_id = 3;
UPDATE Roles SET role_name = N'Nhân viên kho' WHERE role_id = 4;
UPDATE Roles SET role_name = N'Nhân viên kế toán' WHERE role_id = 5;

-- Fix Users
UPDATE Users SET full_name = REPLACE(full_name, 'BÃ¡o GiÃ¡', 'Báo Giá') WHERE full_name LIKE '%BÃ¡o GiÃ¡%';
UPDATE Users SET full_name = REPLACE(full_name, 'Mua HÃ ng', 'Mua Hàng') WHERE full_name LIKE '%Mua HÃ ng%';
UPDATE Users SET full_name = REPLACE(full_name, 'Káº¿ ToÃ¡n', 'Kế Toán') WHERE full_name LIKE '%Káº¿ ToÃ¡n%';

-- General fix for the "Báo Giá 01" issue specifically seen in screenshot
UPDATE Users SET full_name = N'Báo Giá 01' WHERE username = 'baogia01';
UPDATE Users SET full_name = N'Báo Giá 02' WHERE username = 'baogia02';
UPDATE Users SET full_name = N'Mua Hàng 01' WHERE username = 'muahang01';
UPDATE Users SET full_name = N'Mua Hàng 02' WHERE username = 'muahang02';
UPDATE Users SET full_name = N'Kho 01' WHERE username = 'kho01';
UPDATE Users SET full_name = N'Kho 02' WHERE username = 'kho02';
UPDATE Users SET full_name = N'Kế Toán 01' WHERE username = 'ketoan01';
UPDATE Users SET full_name = N'Kế Toán 02' WHERE username = 'ketoan02';

-- Fix Materials
UPDATE Materials SET material_name = N'Giấy A4' WHERE material_id = 1;
UPDATE Materials SET material_name = N'Mực in' WHERE material_id = 2;
UPDATE Materials SET material_name = N'Bao bì' WHERE material_id = 3;

PRINT 'Encoding fix completed.';
