
--Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday. 
--When inserting, make up info if necessary. Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.

--1.Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.

CREATE VIEW view_product_order_He
AS
SELECT ProductID, Quantity
FROM [Order Details]


--2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” 
--that accept product id as an input and total quantities of order as output parameter.

CREATE PROC sp_product_order_quantity_KING
@Pid int, 
@quantities VARCHAR(20) OUTPUT
AS
BEGIN
SELECT @quantities = Quantity FROM [Order Details] WHERE ProductID = @Pid
END


--3.Create a stored procedure “sp_product_order_city_[your_last_name]” 
--that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.

CREATE PROC sp_product_order_city_Liu
@pname varchar(50),
@cty varchar(20),
@nums varchar(20) OUT
AS
BEGIN
SELECT TOP 5 @nums =od.Quantity
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
WHERE @cty = o.ShipCity AND @pname = p.ProductName
END


--4.Create 2 new tables “people_your_last_name” “city_your_last_name”. 
--City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
--Create a view “Packers_your_name” lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
CREATE TABLE people_He (id int, Name TEXT, City int)
CREATE TABLE city_He (Id int, City TEXT)

INSERT INTO city_He
VALUES (1, 'Seattle'), (2, 'Green Bay')

INSERT INTO people_He
VALUES (1,'Aaron Rodgers', 2), (2, 'Russell Wilson', 1), (3, 'Jody Nelson', 2)

UPDATE city_He
SET City=  'Madison'
WHERE Id = 1

DROP TABLE city_He
DROP TABLE people_He

CREATE VIEW Packers_He
AS
SELECT p.Name
FROM dbo.city_He c JOIN dbo.people_He p ON p.id = c.id
WHERE c.City In ('Green Bay')


--5.Create a stored procedure “sp_birthday_employees_[you_last_name]” 
--that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. 
--(Make a screen shot) drop the table. Employee table should not be affected.

CREATE PROC sp_birthday_employees_He
AS 
BEGIN
CREATE TABLE birthday_employees_He (id int primary key not null, name varchar(40), dob date)
INSERT INTO birthday_employees_He VALUES(1, 'John', 1945-2-15)
INSERT INTO birthday_employees_He VALUES(2, 'Jay', 1985-2-5)
INSERT INTO birthday_employees_He VALUES(3, 'James', 1995-2-25)
END

EXEC sp_birthday_employees_He

DROP TABLE birthday_employees_He


--6.How do you make sure two tables have the same data?

-- Use TABLEDIFF() function
