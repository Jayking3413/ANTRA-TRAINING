/*
1. What is index; types of indices; pros and cons

Index: On disk structure associated with a table that increase retrieval speed of rows from the tables
clustered index: physically sort the data; one table can only have one clustered index 
non clustered index: will not sort the data, will be sotred seperately


2. What's the difference between Primary key and Unique constraint?

primary key vs unique key

Primary Key
•PRIMARY KEY constraints identify the column or set of columns that have values that uniquely identify a row in a table 
•primary key (PK) of the table and enforces the entity integrity of the table 
•A table can have only one PRIMARY KEY constraint, and a column that participates in the PRIMARY KEY constraint cannot accept null values. Because PRIMARY KEY constraints guarantee unique data, they are frequently defined on an identity column. 
•If a PRIMARY KEY constraint is defined on more than one column it is called as composite primary key
•If a composite primary key is defined, values may be duplicated within one column, but each combination of values from all the columns in the PRIMARY KEY constraint definition must be unique.
•Composite primary key is a table constraint

Copyri ght © 2015 Antra , I nc. All ri ghts re served. Unique
•UNIQUE constraints enforce the uniqueness of the values in a set of columns 
•In a UNIQUE constraint, no two rows in the table can have the same value for the columns 
•You can use UNIQUE constraints to make sure that no duplicate values are entered in specific columns that do not participate in a primary key 
•Multiple UNIQUE constraints can be defined on a table 
•In a UNIQUE constraint, only one null value is allowed per column. 
•A UNIQUE constraint can be referenced  by a FOREIGN KEY constraint 


3. Tell me about check constraint

check constraint: limit the value range that can be placed in the column


4. Difference between temp table and table variable

1. temp tables and tables variables are stored in temp db
2. scope: local/global; current batch
3. size: >100 rows; <100 
4. usage: do not use in SP/FUNCITION; can be used in sp/function 


5. Difference between WHERE and HAVING

1) both are used as filters, but having apply only to groups as a whole, and only filters on aggregation functions; where applys to individual rows
2) WHERE goes before aggregations, but HAVING filters after the aggregations
	FROM/JOIN -> WHERE -> GROUP BY -> HAVING -> SELECT -> DISTINCT -> ORDER BY
	             |_________________________|
				 cannot use alias in select


6. Difference between RANK() and DenseRank() — value gap

RANK(): if there is the same rank ,the there will be a gap for the next rank
DENSE_RANK(): will not skip any number in rank if there is a tie
Rank() will keep the ranking, so the numbering may go 1, 2, 2, 4 etc, whereas dense_rank will never give any gaps.

7. COUNT(*) vs. COUNT(colName)
1. COUNT(*): returns the number of rows
COUNT(colName): return the number of specified column of rows excluding NULL values

8. What's the difference between left join and inner join? JOIN and Subquery, which one has a

INNER JOIN: return the records that have matching values in both tables
LEFT OUTER JOIN: return all records from the left table, and the matching records from the right table, 
for the non-matching records in the right table, the result set will return us null values list all customers whether they have made any purchase or not
Subquery: a SELECT statement taht is embeded in a clause of another sql statement

subquery vs. join
	1) JOIN can only be used in FROM; Subquery can be used in SELECT, WHERE, FROM, ORDER BY 
	2)subquery is easy to understand and maintain
	3) usually join will have a better performance than subquery

better performance, why?
	less data space need for joins
	using joins, you can maximize the calculation burden on the database i.e., instead of multiple queries using one join query


9. What is correlated subquery

Correlated Subquery: inner query is dependent on the outer query


10. What is a CTE, why do we need CTE?

Common Table Expression (CTE): Specifies a temporary named result set
	Improve readability and manageability of complex SQL Statements
	Similar to VIEWs and even more to Derived Tables
	Over time most of the CTEs will be used for this purpose

Recursive CTEs: Using CTEs and Unions, we can generate columns that can be used in the query following the CTE.


11. What does SQL Profiler do?

SQL Server Profiler: an interface to create and manage traces and analyze and replay trace results


12. What is SQL injection, how to avoid SQL injection?
 
 SQL injection: a code injection technique used to attack data-driven applications, 
 in which malicious SQL statements are inserted into an entry field for execution.
 
 Prevention:
 a) stop writing dynamic queries with string concatenation;
 b) prevent user supplied input which contains malicious SQL from affecting the logic of the executed query.


13. Difference between SP and user defined function? When to use SP when to use function?

sp vs. function
	usage: sp for DML, function for calculations
	how to call: sp called by its name, function will be called in SQL query
	output: sp may or maynot have output, but function must return some value
	SP can function but function can not call sp


14. Criteria of Union and Union all? Difference between UNION and UNION ALL

1. both UNION and UNION ALL are used to combine multiple result sets vertically
2. criteria
	the num of columns must be the same
	columns types must be identical
3.alias must be given in the first SELECT statement

difference
1. UNION remove all duplicate records, but UNION ALL will not
2. UNION sort the first column ascendingly, but UNION ALL will not
3. UNION cannot be used in recursive cte, but UNION ALL can


15. Steps you take to improve SQL Queries

1. look at the execution plan
2. choose index wisely
3. avoid unnecessary joins
4. avoid SELECT *
5. JOIN to replace subquery
6. derived table to avoid a lot of grouping by


16. concurrency problem in transaction

concurrency occurs when two or more transactions are trying to access the same data or info

1. dirty reads:
	t1 allows t2 to read uncommitted data and then t1 rolled back
	caused by isolation level read uncommitted
	solved by isolation level read committed
2. lost update
	t1 and t2 read and update the same data but t2 finish its work earlier than t1, then t2 will lost their update
	caused by isolation level read committed
	solved by isolation level repeatable read
3. non repeatable read
	t1 read the same data twice while t2 is updating the data
	caused by isolation level read committed
	solved by isolation level repeatable read
4. phantom read
	t1 reads the same data twice while t2 is inserting records
	cuased by isolation level repeatable read
	solved by isolation level serializable


17. what is deadlock, how to prevent

deadlock: a situation in which two or more transactions are waiting for one another to give up locks

Prevent : 
Try to keep transactions short; this will avoid holding locks in a transaction for a long period of time.
Access objects in a similar logical manner in multiple transactions.
Create a covering index to reduce the possibility of a deadlock.


18. what is normalization, 1NF - BCNF, benefits using normalization

Normalization:
	•Database Normalization is a process of organizing data to minimize redundancy (data duplication), which in turn ensures data consistency. 
	•Normalization has a series of steps called “Forms”, the more steps you take the more normalized your tables are


19. what are the system defined databases?

A new SQL Server  installation always includes four databases 
❑master
❑model 
❑tempdb 
❑mssql system resource  (hidden)
❑msdb


20. composite key

•A composite key, in the context of relational databases, is a combination of two or more columns in a table that can be used to uniquely identify each row in the table.  
Uniqueness  is only guaranteed  when  the columns are combined; when  taken individually the columns do not guarantee uniqueness.
•This is usually seen in Joint tables


21. candidate key

•A key that is not a PK but  eligible  to be a PK.
•Mostly it is a unique  key without  null  value.


22. DDL vs. DML

Data definition language (DDL): Allows creation objects in database with:

Create, Alter, Drop

Data Control Language (DCL): allows you to determine who can see or modify the data.

            GRANT, DENY, REVOKE

Data Manipulation Language (DML): Allows query and modify the data:

            Select, Insert, Update, Delete.


23. ACID property

ACID
	A: Atomicity -- work is atomic
	C: Consistency -- whatever happends in the middle of the transaction, this property will never leave your db in half-completed state
	I: Isolation -- two transactions will be isolated from each other by locking the resource
	D: Durability -- once the transaction is completed, then the changes it has made to the db will be permanent


24. table scan vs. index scan

Table scan means iterate over all table rows. Index scan means iterate over all index items,
when item index meets search condition, table row is retrived through index. 
Usualy index scan is less expensive than a table scan because index is more flat than a table.


25. Difference between Union and JOIN

Unions: Concatenates the results of two queries into a single result set.
JOIN: combine rows from two or more tables, based on a related column between them