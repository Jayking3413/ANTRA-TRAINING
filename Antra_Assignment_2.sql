use AdventureWorks2019
GO

--1. Write a query that lists the country and province names from person. CountryRegion and person. 
--   StateProvince tables. Join them and produce a result set similar to the following.

SELECT c.Name County, s.Name Province 
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode


--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.

SELECT c.Name County, s.Name Province 
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name = 'Canada' OR c.NAME = 'Germany'


--Using Northwind Database: (Use aliases for all the Joins)
use Northwind
GO

--3. List all Products that has been sold at least once in last 25 years.

SELECT DISTINCT p.ProductName
FROM [Order Details] od INNER JOIN Products p ON od.ProductID = p.ProductID INNER JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate > '1997-5-18' AND od.Quantity>= 1  

--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.

SELECT TOP 5 o.ShipPostalCode , COUNT(o.OrderID) AS NumOfOrders
FROM Orders o 
WHERE o.OrderDate > '1997-5-18'
GROUP BY ShipPostalCode
ORDER BY COUNT(o.OrderID) DESC

--5. List all city names and number of customers in that city.     

SELECT c.City, COUNT(c.CustomerID) AS NumOfCustomers
FROM Customers c
GROUP BY c.City


--6. List city names which have more than 2 customers, and number of customers in that city

SELECT c.City, COUNT(c.CustomerID) AS NumOfCustomers
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >2

--7. Display the names of all customers along with the count of products they bought

SELECT c.CompanyName, SUM(od.Quantity) AS NumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName
ORDER BY c.CompanyName


--8. Display the customer ids who bought more than 100 Products with count of products.

SELECT c.CustomerID, SUM(od.Quantity) AS NumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) >= 100
ORDER BY c.CustomerID

--9. List all of the possible ways that suppliers can ship their products. Display the results as below

SELECT DISTINCT s.CompanyName supplierName, sh.CompanyName
FROM Suppliers s 
JOIN Products p ON s.SupplierID = p.SupplierID 
JOIN [Order Details] od On od.ProductID = p.ProductID 
JOIN Orders o ON o.OrderID = od.OrderID 
JOIN Shippers sh ON sh.ShipperID = o.ShipVia

--10. Display the products order each day. Show Order date and Product Name.

SELECT o.OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
ORDER BY o.OrderDate

--11. Displays pairs of employees who have the same job title.

SELECT e.FirstName
FROM Employees e
WHERE e.Title IN 
(SELECT e.Title
FROM Employees m
WHERE m.Title = 2)



--12. Display all the Managers who have more than 2 employees reporting to them.

SELECT COUNT(e.FirstName) as EmployeeNum, m.FirstName  as ManagerName
FROM Employees e INNER JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.FirstName
HAVING COUNT(e.FirstName) > 2 

--13. Display the customers and suppliers by city. The results should have the following columns

SELECT c.City, c.CompanyName, c.ContactName
FROM Customers c
UNION ALL
SELECT s.City, s.CompanyName, s.ContactName
FROM Suppliers s

--All scenarios are based on Database NORTHWIND.


--14. List all cities that have both Employees and Customers.

SELECT City
FROM Customers
WHERE City IN (SELECT City FROM Employees)

--15. List all cities that have Customers but no Employee.

--a. 

SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (SELECT City FROM Employees) 

--b. 

SElECT DISTINCT c.City 
FROM Customers c, Employees e
WHERE c.City != e.City 


--16. List all products and their total order quantities throughout all orders.

SELECT p.ProductName, SUM(od.Quantity) orderNum
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--17. List all Customer Cities that have at least two customers.

--a. 
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) > = 2
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) > = 2

--b. 

--Use
--sub-query and no union
SELECT DISTINCT City
FROM Customers
WHERE City IN 
(SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) > = 2)
ORDER BY City

--18. List all Customer Cities that have ordered at least two different kinds of products.
 
SELECT c.City, COUNT(od.ProductID) kinds
FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID) >=2
ORDER BY c.City

--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

SELECT TOP 5 p.ProductName, o.ShipCity, COUNT(od.Quantity) numOfOrders, AVG(od.UnitPrice) avgPrice
FROM Products p JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON o.OrderID = od.OrderID
GROUP BY p.ProductName, o.ShipCity


--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
--and also the city of most total quantity of products ordered from. (tip: join  sub-query)

SELECT TOP 1 o.ShipCity City, COUNT(o.OrderID) numOfOrders, SUM(od.Quantity) numOfQuantity
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.ShipCity
ORDER BY COUNT(o.OrderID) DESC, SUM(od.Quantity) DESC

--21. How do you remove the duplicates record of a table?

--USE DISTINCT OR UNION
