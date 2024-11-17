--CREATE Database testAsm1
--go
USE testAsm1
go
CREATE TABLE Customers (  
    CustomersID INT PRIMARY KEY,  
    CustomersName VARCHAR(100),  
    CustomersPhone VARCHAR(15),  
    CustomersAddress VARCHAR(255),  
    CustomersEmail VARCHAR(100)  
);  
CREATE TABLE Employee (  
    EmployeeID INT PRIMARY KEY,  
    EmployeeName VARCHAR(100),  
    EmployeePhone VARCHAR(15),  
    EmployeeAddress VARCHAR(255),  
    EmployeePosition VARCHAR(50),  
    EmployeeEmail VARCHAR(100)  
);  
CREATE TABLE Orders (  
    OrderID INT PRIMARY KEY,  
    CustomersID INT,  
    EmployeeID INT,  
    OrderDate DATE,  
    OrderPrice DECIMAL(10, 2),  
    FOREIGN KEY (CustomersID) REFERENCES Customers(CustomersID),  
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)  
);  
CREATE TABLE Product (  
    ProductID INT PRIMARY KEY,  
    ProductPrice DECIMAL(10, 2),  
    ProductType VARCHAR(50),  
    ProductDescription VARCHAR(255),  
    ProductQuantity INT  
);  
CREATE TABLE DetailedOrders (  
    OrderID INT,  
    ProductID INT,  
    Quantity INT,  
    Price DECIMAL(10, 2),  
    PRIMARY KEY (OrderID, ProductID),  
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),  
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)  
);  