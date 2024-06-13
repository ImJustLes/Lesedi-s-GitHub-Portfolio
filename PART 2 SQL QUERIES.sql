CREATE DATABASE PROG7311POEPART3
USE PROG7311POEPART3 

CREATE TABLE RegisteredEmployees(

Username VARCHAR(255) PRIMARY KEY NOT NULL,
UserPassword VARCHAR(255) NOT NULL
);

CREATE TABLE EmployeeFarmers(

ProductID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Username VARCHAR(255),
FOREIGN KEY (Username) REFERENCES RegisteredEmployees(Username),
FarmerUsername VARCHAR(255),
FOREIGN KEY (FarmerUsername) REFERENCES RegisteredFarmers(FarmerUsername),
ProductName VARCHAR(255) NOT NULL,
Category VARCHAR(255) NOT NULL,
ProductDate DATE NOT NULL
);

CREATE TABLE RegisteredFarmers(

EmployeeUsername VARCHAR(255),
FOREIGN KEY (EmployeeUsername) REFERENCES RegisteredEmployees(Username),
FarmerUsername VARCHAR(255) PRIMARY KEY NOT NULL,
UserPassword VARCHAR(255) NOT NULL
);

INSERT INTO RegisteredEmployees (Username, UserPassword)
VALUES ('Lesedi', 'MTIz'), ('Max', 'MTIz'), ('Tracy', 'MTIz'), ('Daniel', 'MTIz'), ('Donna', 'MTIz');

-- Insert products for user1 (as farmer)
INSERT INTO EmployeeFarmers (Username, FarmerUsername, ProductName, Category, ProductDate)
VALUES ('Lesedi', 'user1', 'Solar Roof Panels', 'Solar Panels', '2024-05-31'),
       ('Lesedi', 'user1', 'High-Efficiency Fridge', 'Energy Efficiency Measures', '2024-05-31'),
       ('Lesedi', 'user1', 'High-Efficiency Alarm Clock', 'Energy Efficiency Measures', '2024-07-26');

-- Insert products for user2 (as farmer)
INSERT INTO EmployeeFarmers (Username, FarmerUsername, ProductName, Category, ProductDate)
VALUES ('Tracy', 'user2', 'Organic Cow Milk', 'Dairy', '2024-01-18'),
       ('Tracy', 'user2', 'Custom Wooden Tables', 'Carpentry', '2024-05-31'),
       ('Tracy', 'user2', 'Aluminium', 'Metal Works', '2024-04-20');

-- Sample inserts for RegisteredFarmers (assuming user1 and user2 as farmers)
INSERT INTO RegisteredFarmers (EmployeeUsername, FarmerUsername, UserPassword)
VALUES ('Lesedi', 'user1', 'MTIz'), ('Tracy', 'user2', 'MTIz');




DROP TABLE RegisteredFarmers;
DROP TABLE EmployeeFarmers;
DROP TABLE RegisteredEmployees;

SELECT * FROM RegisteredEmployees;
SELECT * FROM RegisteredFarmers;
SELECT * FROM EmployeeFarmers;

DELETE FROM RegisteredFarmers WHERE UserPassword = 'MTIz'