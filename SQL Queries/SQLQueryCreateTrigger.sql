CREATE TRIGGER chef_employee_id_only
ON ItemOrder
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        LEFT JOIN Employee e ON i.ChefEmployeeID = e.EmployeeID
        WHERE e.Position <> 'Chef' OR e.Position IS NULL
    )
        THROW 50000, 'Error: ChefEmployeeID must reference an employee with the Chef position', 1;
    ELSE
    BEGIN
        -- If the condition is met, insert the row
        INSERT INTO ItemOrder (OrderID, ItemID, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus)
        SELECT OrderID, ItemID, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus FROM inserted;
    END;
END;