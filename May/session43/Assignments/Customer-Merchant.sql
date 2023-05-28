-- Create Customer table
CREATE TABLE Customer (
    CID INT,
    CName VARCHAR(50),
    Balance DECIMAL(10, 2)
);

-- Insert values into Customer table
INSERT INTO Customer (CID, CName, Balance)
VALUES
    (1, 'Manjunath', 1000),
    (2, 'Ravi', 5000);

select * from Customer

-- Create Merchant table
CREATE TABLE Merchant (
    MID VARCHAR(10),
    MName VARCHAR(50),
    Balance DECIMAL(10, 2)
);

-- Insert values into Merchant table
INSERT INTO Merchant (MID, MName, Balance)
VALUES
    ('M1', 'Reliance', 50000),
    ('M2', 'DMart', 60000);

select * from Merchant
