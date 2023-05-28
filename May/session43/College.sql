CREATE TABLE COLLEGE(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NAME VARCHAR(20)
)
CREATE TABLE DEPARTMENT(
	ID INT PRIMARY KEY,
	NAME VARCHAR(20),
	COLLEGE_ID INT REFERENCES COLLEGE(ID)
)

INSERT INTO COLLEGE VALUES('VIVA')
DELETE FROM COLLEGE WHERE ID=2
SELECT * FROM COLLEGE
INSERT INTO DEPARTMENT VALUES(10,'CS',1)

SELECT * FROM DEPARTMENT

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Phone VARCHAR(20)
);
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE TABLE LineItems (
    LineItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone)
VALUES (1, 'John', 'Doe', 'john.doe@example.com', '1234567890');

INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone)
VALUES (2, 'Jane', 'Smith', 'jane.smith@example.com', '9876543210');


INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES (1, 1, '2023-05-17', 100.00);

INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES (2, 2, '2023-05-18', 150.00);


INSERT INTO LineItems (LineItemID, OrderID, ProductID, Quantity, Price)
VALUES (1, 1, 1001, 2, 10.00);

INSERT INTO LineItems (LineItemID, OrderID, ProductID, Quantity, Price)
VALUES (2, 1, 1002, 3, 15.00);

INSERT INTO LineItems (LineItemID, OrderID, ProductID, Quantity, Price)
VALUES (3, 2, 1003, 1, 20.00);


select * from Customers
select * from Orders
select * from LineItems

