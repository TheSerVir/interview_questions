CREATE TABLE Employee (
    EmployeeId int,
    LastName nvarchar(255),
    FirstName nvarchar(255),
    CityId int
);

CREATE TABLE City (
    CityId int,
    Name nvarchar(255));

-- Query all employees from "Kharkiv"