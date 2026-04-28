-- FUNCTIONS 
/*
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
 */

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