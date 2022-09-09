USE AIRPORT
GO

INSERT INTO BOOKING (Booking_Number, Member_ID, Flight_Number, Booking_Date)
VALUES ('BK1','M01', 'FT322', 22-09-15)

INSERT INTO DESTINATION (Destination_ID, Airport_Name, City_Name, Province)
VALUES ('CPT', 'Cape Airlines', 'CapeTown', 'Western Cape')

INSERT INTO PLANE (Plane_Number, Capacity, Airplane_Name)
VALUES ('P1', 11, 'Fasty')

INSERT INTO MANAGEMENT (Management_ID, First_Name, Last_Name, Passwords, Email, ID_Number, Role_ID)
VALUES ('MAN1', 'Jan', 'Fourie', '1234', 'jan@gmail.com', 258963741, 'Manager')

INSERT INTO MEMBER (Member_ID, First_Name, Last_Name, Passwords, Email, ID_Number)
VALUES ('MEM1', 'Koos', 'VDM', '1111', 'koos@gmail.com', 123456789)

INSERT INTO FLIGHTS (Flight_Number, Destination_ID, Departure_Date, Departure_Time, Plane_Number, Gate_Number, Status, Price)
VALUES ('FT322', 'CPT', 22-09-15, null, 'P1', 'G1', 'Available', 2000)
