USE ST10079848Db;

CREATE TABLE RegisteredUsers(

UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Username VARCHAR(255) NOT NULL,
UserPassword VARCHAR(255) NOT NULL,
);

CREATE TABLE Modules(

ModuleCode VARCHAR(255) PRIMARY KEY NOT NULL,
UserID INT,
FOREIGN KEY (UserID) REFERENCES RegisteredUsers(UserID),
ModuleName VARCHAR(255) NOT NULL,
Credits INT NOT NULL,
HoursPerWeek FLOAT NOT NULL
);

CREATE TABLE Semesters(

SemesterNum INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
UserID INT,
FOREIGN KEY (UserID) REFERENCES RegisteredUsers(UserID),
Weeks INT NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
);

CREATE TABLE UserInformation(

UserID INT,
FOREIGN KEY (UserID) REFERENCES RegisteredUsers(UserID),
ModuleCode VARCHAR(255),
FOREIGN KEY (ModuleCode) REFERENCES Modules(ModuleCode),
SelfStudyHours FLOAT NOT NULL,
);

CREATE TABLE StudyHoursRecords(

UserID INT,
FOREIGN KEY (UserID) REFERENCES RegisteredUsers(UserID),
ModuleCode VARCHAR(255),
FOREIGN KEY (ModuleCode) REFERENCES Modules(ModuleCode),
HoursStudied FLOAT NOT NULL,
DateStudied DATE NOT NULL,
);

DELETE FROM RegisteredUsers WHERE UserID = 1016;
DELETE FROM RegisteredUsers WHERE UserID = 1017;
DELETE FROM UserInformation WHERE UserID = 1010;
DELETE FROM StudyHoursRecords WHERE UserID = 1008;
DELETE FROM StudyHoursRecords WHERE UserID = 1010;
DELETE FROM Semesters WHERE UserID = 1010;
DELETE FROM Semesters WHERE UserID = 1006;
DELETE FROM Modules WHERE UserID = 1008;
DELETE FROM Modules WHERE UserID = 1010;

SELECT * FROM UserInformation;
SELECT * FROM RegisteredUsers;
SELECT * FROM StudyHoursRecords;
SELECT * FROM Semesters;
SELECT * FROM Modules;

