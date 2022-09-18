USE AIRPORT
GO

CREATE TABLE PLANE (
    Plane_Number VARCHAR(36) PRIMARY KEY,
    Capacity INT,
    Airplane_Name VARCHAR(64)
);

CREATE TABLE MANAGEMENT (
    Management_ID VARCHAR(36) PRIMARY KEY,
    First_Name VARCHAR(64),
    Last_Name VARCHAR(64),
    Passwords VARCHAR(64),
    Email VARCHAR(64),
    ID_Number INT,
    Role_ID VARCHAR(36)
);

CREATE TABLE MEMBER (
    Member_ID VARCHAR(36) PRIMARY KEY,
    First_Name VARCHAR(64),
    Last_Name VARCHAR (64),
    Passwords VARCHAR(64),
    Email VARCHAR(64),
    ID_Number INT
);

CREATE TABLE DESTINATION (
    Destination_ID VARCHAR(3) PRIMARY KEY,
    Airport_Name VARCHAR(64),
    City_Name VARCHAR(64),
    Province VARCHAR(64)
);

CREATE TABLE FLIGHTS (
    Flight_Number VARCHAR(36) PRIMARY KEY,
    Destination_ID VARCHAR(3),
    Departure_Date DATETIME,
    Departure_Time DATETIME,
    Plane_Number VARCHAR(36),
    Gate_Number VARCHAR(36),
    Status VARCHAR(64),
    Price SMALLMONEY
);

CREATE TABLE BOOKING (
    Booking_Number VARCHAR(36) PRIMARY KEY,
    Member_ID VARCHAR(36),
    Flight_Number VARCHAR(36),
    Booking_Date DATETIME

);