drop DATABASE AirlineReservation;

USE AirlineReservation;

CREATE TABLE Airport
(
	airportCode		CHAR(5),
	airportName		VARCHAR(50),
	city			VARCHAR(20),
	country			VARCHAR(20),
	
	CONSTRAINT pk_airport PRIMARY KEY(airportCode)
		
);

CREATE TABLE Airline
(
	alineCode		CHAR(5),
	alineAddress	VARCHAR(50),
	alineName		VARCHAR(50),
	
	CONSTRAINT pk_airline PRIMARY KEY(alineCode)	
);


CREATE TABLE Airplane
(
	planeRegNo		CHAR(10),
	planeType		VARCHAR(30),
	noOfSeat		INTEGER,
	alineCode		CHAR(5),
	
	CONSTRAINT pk_airplane PRIMARY KEY(planeRegNo),
	CONSTRAINT fk_airplane FOREIGN KEY(alineCode) 
		REFERENCES Airline(alineCode)
);


CREATE TABLE Fair
(
	ticketNo		VARCHAR(15),
	amount			FLOAT,
	paymentMethod	VARCHAR(50),
	
	CONSTRAINT pk_fair PRIMARY KEY(ticketNo),
	CONSTRAINT chk_fair CHECK(paymentMethod in ('Credit/Debit' ,'Bank ATM' ,'Counter Sevice', 'Bank direct payment','Over the counter' ))
);

CREATE TABLE Flight_Route
(
	routeNo			CHAR(10),
	startingPoint	VARCHAR(20),
	turningPoint	VARCHAR(20),
	endingPoint		VARCHAR(20),
	ticketNo		VARCHAR(15),
	
	CONSTRAINT pk_route PRIMARY KEY(routeNo),
	CONSTRAINT fk_route FOREIGN KEY(ticketNo)
		REFERENCES Fair(ticketNo)	
);

CREATE TABLE Flight
(
	flightNo		CHAR(10),
	fSource			VARCHAR(30),
	destination		VARCHAR(30),
	departureTime	TIME,
	arrivalTime		TIME,
	departuteDate	DATE,
	arrivalDate		DATE,
	alineCode		CHAR(5),
	routeNo			CHAR(10),
	
	CONSTRAINT pk_flight PRIMARY KEY(flightNo),
	CONSTRAINT fk1_flight FOREIGN KEY(alineCode)
		REFERENCES Airline(alineCode),
	CONSTRAINT fk2_flight FOREIGN KEY(routeNo)
		REFERENCES Flight_Route(routeNo)
	
);

CREATE TABLE FlightClass
(
	flightNo	CHAR(10),
	class		VARCHAR(30),
	
	CONSTRAINT pk_fclass PRIMARY KEY(flightNo,class),
	CONSTRAINT fk_fclass FOREIGN KEY(flightNo)
		REFERENCES Flight(flightNo)
);


CREATE TABLE Travel_Agency
(
	TAID		INTEGER,
	TAname		VARCHAR(30),
	TAaddress	VARCHAR(30),
	
	CONSTRAINT pk_travel PRIMARY KEY(TAID)

);


CREATE TABLE TA_Contact
(
	TAID		INTEGER,
	TAphone		INTEGER,

	CONSTRAINT pk_tcontact PRIMARY KEY(TAID,TAphone),
	CONSTRAINT fk_tcontact FOREIGN KEY(TAID)
		REFERENCES Travel_Agency(TAID)
);


CREATE TABLE Passenger
(
	passportNo	CHAR(10),
	passcode	VARCHAR(10),
	fname		VARCHAR(15),
	mname		VARCHAR(15),
	lname		VARCHAR(15),
	age			INTEGER,
	gender		CHAR(8),
	pAddress	VARCHAR(50),
	TAID		INTEGER,

	
	CONSTRAINT pk_passenger PRIMARY KEY(passportNO),
	CONSTRAINT fk_passenger FOREIGN KEY(TAID)
		REFERENCES Travel_Agency(TAID)
);

CREATE TABLE Passenger_Contact
(
	passportNo	CHAR(10),
	pPhone		INTEGER,
	
	CONSTRAINT pk_pc PRIMARY KEY(passportNo,pPhone),
	CONSTRAINT fk_pc FOREIGN KEY(passportNo)
		REFERENCES Passenger(passportNo)
);


CREATE TABLE Passenger_Email
(
	passportNo	CHAR(10),
	email		VARCHAR(30),

	CONSTRAINT pk_pe PRIMARY KEY(passportNo,email),
	CONSTRAINT fk_pe FOREIGN KEY(passportNo)
		REFERENCES Passenger(passportNo)
);

CREATE  TABLE Seat
(
	planeRegNo		CHAR(10),
	seatNo			CHAR(5),
			
    CONSTRAINT pk_seat PRIMARY KEY(planeRegNo,seatNo),
    CONSTRAINT fk_Seat FOREIGN KEY (planeRegNo)
		REFERENCES Airplane(planeRegNo)
);

CREATE  TABLE Booking
(
         flightNo		CHAR(10),
         TAID           INTEGER,
   
    	CONSTRAINT pk_book PRIMARY KEY(flightNo,TAID),
    	CONSTRAINT fk1_Booking FOREIGN KEY (flightNo)
	              REFERENCES Flight(flightNo),
    	CONSTRAINT fk2_Booking FOREIGN KEY (TAID)
	       REFERENCES Travel_Agency(TAID)
);

CREATE  TABLE Land
(
            planeRegNo		CHAR(10),   					   				   
            airportCode		CHAR(5),
			
	CONSTRAINT pk_land PRIMARY KEY( planeRegNo, airportCode),
	CONSTRAINT fk1_land FOREIGN KEY( planeRegNo)
	            REFERENCES Airplane( planeRegNo),
	CONSTRAINT fk2_land FOREIGN KEY( airportCode)
	            REFERENCES Airport( airportCode)	
);
INSERT INTO Airport
	 VALUES('CMB','Bandaranayake IA','Colombo','Sri Lanka')
INSERT INTO Airport
	 VALUES('PGX','Perigueux Airport','Periguex','France')
INSERT INTO Airport
	 VALUES('CCJ','Calicut IA','Calicut','India')
INSERT INTO Airport
	 VALUES('KUL','Kuala Lampur IA','Kuala Lampur','Malaysia')
INSERT INTO Airport
	 VALUES('DOH','Hamad IA','Doha','Qatar')
INSERT INTO Airport
	 VALUES('SIN','Singapore Changi Airport','Singapore','Singapore')
INSERT INTO Airport
	 VALUES('BKK','Suvarnabhumi Airport','Bangkok','Thailand')
INSERT INTO Airport
	 VALUES('DXB','Dubai IA','Dubai','United Arab Emirates')
INSERT INTO Airport
	 VALUES('CBG','Cambridge Airport','Cambridge','United Kingdom')
INSERT INTO Airport
	 VALUES('CAE','Colombia Metropolitan','Columbia','USA')


INSERT INTO Airline 
	VALUES('UL','Srilankan Airlines','Sri Lanka')
INSERT INTO Airline 
	VALUES('AC','Air Canada','Canada')
INSERT INTO Airline 
	VALUES('IX','Air India express','India')
INSERT INTO Airline 
	VALUES('B3','Bhutan Airlines','Bhutan')
INSERT INTO Airline 
	VALUES('BA','British airways','United kingdom')
INSERT INTO Airline 
	VALUES('EK','Emirates Airlines','UAE')
INSERT INTO Airline 
	VALUES('QF','Quantas Airways','Australia')
INSERT INTO Airline 
	VALUES('G7','gojet Airlines','USA')
INSERT INTO Airline 
	VALUES('SQ','Singapore Airlines','Singapore')


INSERT INTO Airplane 
	VALUES('9Y-TTA','Boeing 737-800',191,'AC')
INSERT INTO Airplane 
	VALUES('9Y-ANU','Boeing 737-800',187,'EK')
INSERT INTO Airplane 
	VALUES('LN-TUJ','Boeing 737-700',167,'G7')
INSERT INTO Airplane 
	VALUES('9Y-GEO','Boeing 737-800 ',191,'SQ')
INSERT INTO Airplane
 	VALUES('SP-EQCH','Bombardier Dash 8 (400)',82,'G7')
INSERT INTO Airplane
 	VALUES('9Y-TTB','Airbus A-321',165,'IX')
INSERT INTO Airplane
 	VALUES('D-AGWK','Airbus A-319',144,'AC')
INSERT INTO Airplane
 	VALUES('LN-NGY','Boeing 737-800',186,'BA')



INSERT INTO Fair
	 VALUES('819456789/1',1376.48,'Credit/Debit')
INSERT INTO Fair
	 VALUES('234567891/9',688.24,'Bank ATM')
INSERT INTO Fair
	 VALUES('156789348/8',412.94,'Counter Sevice')
INSERT INTO Fair
	 VALUES('958324302/7',700.35,'Bank direct payment')
INSERT INTO Fair
	 VALUES('731457800/1',206.47,'Over the counter')
	 

INSERT INTO Flight_Route(routeNo ,startingPoint ,endingPoint ,ticketNo)
	 VALUES('DBX-CMB' ,'Dubai' ,'Colombo' ,'819456789/1')
INSERT INTO Flight_Route(routeNo ,startingPoint ,turningPoint ,endingPoint ,ticketNo)
	 VALUES('BKK-CBR' ,'Bankok' ,'Melbourne' ,'Canberra' ,'234567891/9')
INSERT INTO Flight_Route(routeNo ,startingPoint ,endingPoint ,ticketNo)
	 VALUES('CJJ-DOH' ,'Calicut' ,'Doha' ,'156789348/8')
INSERT INTO Flight_Route(routeNo ,startingPoint ,turningPoint ,endingPoint ,ticketNo)
	 VALUES('BKK-CBG' ,'Bankok' ,'Amsterdam' ,'Cambridge' ,'958324302/7')
INSERT INTO Flight_Route(routeNo ,startingPoint ,endingPoint ,ticketNo)
	 VALUES('PGX-CMB' ,'Perigueux' ,'Colombo' ,'731457800/1')


INSERT INTO Flight	
	VALUES('EK819' ,'Dubai Intl' ,'Bandaranaike Intl' , '23:45' ,'03:55' ,'2016-09-30' ,'2016-10-01' ,'EK' ,'DBX-CMB')
INSERT INTO Flight	
	VALUES('G7205' ,'Swarnabhumi Intl' ,'Canberra Intl' , '17:45' ,'05:50' ,'2016-10-05' ,'2016-10-06' ,'G7' ,'BKK-CBR')
INSERT INTO Flight	
	VALUES('IX243' ,'Calicut Intl' ,'Hamad Intl' , '01:05' ,'05:10' ,'2016-09-23' ,'2016-10-23' ,'IX' ,'CJJ-DOH')
INSERT INTO Flight	
	VALUES('BA10' ,'Swarnabhumi Intl' ,'Cambridge Intl' , '22:25' ,'01:00' ,'2016-09-29' ,'2016-10-01' ,'BA' ,'BKK-CBG')
INSERT INTO Flight	
	VALUES('UL162' ,'Bassillac Intl' ,'Bandaranaike Intl' , '21:45' ,'10:36' ,'2016-10-10' ,'2016-10-11' ,'UL' ,'PGX-CMB')

INSERT INTO FlightClass
	 VALUES('EK819' ,'First')
INSERT INTO FlightClass
	 VALUES('EK819' ,'Economy')
INSERT INTO FlightClass
	 VALUES('EK819' ,'Business')
INSERT INTO FlightClass
	 VALUES('EK819' ,'Shuttle')
INSERT INTO FlightClass
	 VALUES('G7205' ,'Economy')
INSERT INTO FlightClass
	 VALUES('G7205' ,'Business')
INSERT INTO FlightClass
	 VALUES('IX243' ,'Economy')
INSERT INTO FlightClass
	 VALUES('BA10' ,'Economy')
INSERT INTO FlightClass
	 VALUES('BA10' ,'Business')
INSERT INTO FlightClass
	 VALUES('BA10' ,'Shuttle')
INSERT INTO FlightClass
	 VALUES('BA10' ,'Premium Economy')
INSERT INTO FlightClass
	 VALUES('UL162' ,'Economy')
INSERT INTO FlightClass
	 VALUES('UL162' ,'Business')
INSERT INTO FlightClass
	 VALUES('UL162' ,'First')
INSERT INTO FlightClass
	 VALUES('UL162' ,'Premium Economy')

INSERT INTO Travel_Agency
	VALUES(60000 , 'Hemas International' ,'Kandy')
INSERT INTO Travel_Agency
	VALUES(11244 , 'SafeLine Travels' ,'Colombo')
INSERT INTO Travel_Agency
	VALUES(54321 , 'Abhimani Lanka' ,'Galle')
INSERT INTO Travel_Agency
	VALUES(60641 , 'Lotus Travels' ,'Negombo')
INSERT INTO Travel_Agency
	VALUES(13478 , 'Asliya International' ,'Kurunegala')
INSERT INTO Travel_Agency
	VALUES(65478 , 'YourJourney Travels' ,'Ratnapura')
	
	
INSERT INTO TA_Contact
	 VALUES(60000 , 0815500300)
INSERT INTO TA_Contact
	 VALUES(11244 ,0789610769)
INSERT INTO TA_Contact
	 VALUES(54321, 0919229279)
INSERT INTO TA_Contact
	 VALUES(54321 , 0114830751)
INSERT INTO TA_Contact
	 VALUES(60000, 0710236548)
INSERT INTO TA_Contact
	 VALUES(65478 , 0452200390)
INSERT INTO TA_Contact
	 VALUES(65478 , 0765545300)
 
 
 INSERT INTO Passenger
	 VALUES('N2542781C','ashsad676','Nuwan','kumara','Wijesundara',32,'Male','No 7/33, Peradeniya' , 60000)
INSERT INTO Passenger
	 VALUES('N2542508N','a2ysad676','Nimali','hansika','Hewavitharana',27,'Female','No-12,pedri place, Ratnapura' , 65478)
INSERT INTO Passenger
	 VALUES('N2542520L','asmau76','Ruwan','prabath','Kumarasinghe',26,'Male','No 36,Kingsroad,Thalawathugoda' , 11244)
INSERT INTO Passenger
	 VALUES('N2543480S','aag6787','Suresh','udaya','Priyantha',30,'Male','mihira,Kurunegala' , 13478)
INSERT INTO Passenger
	 VALUES('N2556523N','hsuwdg6','Sujith','bandara','Adikari',28,'Male','No 8/12,Anuradhapura road,Kandy' , 60000)
INSERT INTO Passenger
	 VALUES('N2562845B','83ruasu','Yureni','madhushika','Welegama',26,'Female','No-639,Negombo' , 60641)
INSERT INTO Passenger
	 VALUES('N2563158E','kas676','Supun','kanishka','Perera',29,'Male','No 65,green park,Kurunagala' , 13478)
INSERT INTO Passenger
	 VALUES('N2563206L','s53hd76','Gayan','madhusanka','Samarasinghe',35,'Male','No 26,Lotus place,Galle' , 54321)



INSERT INTO Passenger_Contact
	 VALUES('N2542781C','0815689410')
INSERT INTO Passenger_Contact
	 VALUES('N2542508N','0710147856')
INSERT INTO Passenger_Contact
	 VALUES('N2542520L','0372456789')
INSERT INTO Passenger_Contact
	 VALUES('N2543480S','0715722945')
INSERT INTO Passenger_Contact
	 VALUES('N2556523N','0712689654')
INSERT INTO Passenger_Contact
	 VALUES('N2562845B','0112456587')
INSERT INTO Passenger_Contact
	 VALUES('N2563158E','0376489521')
INSERT INTO Passenger_Contact
	 VALUES('N2563206L','0912245785')
INSERT INTO Passenger_Contact
	 VALUES('N2542520L','0712435804')
INSERT INTO Passenger_Contact
	 VALUES('N2543480S','0756622945')
INSERT INTO Passenger_Contact
	 VALUES('N2556523N','0776689654')


INSERT INTO Passenger_Email
	 VALUES('N2542781C','Nkumara@ymail.com')
INSERT INTO Passenger_Email
	 VALUES('N2542508N','hansika23@yahoo.com')
INSERT INTO Passenger_Email
	 VALUES('N2542520L','praKumarasinghe@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2543480S','Priyantha99@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2556523N','SBAdikari94@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2562845B','Yureni.m@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2563158E','SupunPerera@ymail.com')
INSERT INTO Passenger_Email
	 VALUES('N2563206L','Madhusanka123@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2542781C','n_kumara@hotmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2542508N','hansika.k@gmail.com')
INSERT INTO Passenger_Email
	 VALUES('N2542520L','pkumarasinghe@live.com')


INSERT INTO Seat
	 VALUES('9Y-TTA','16A')
INSERT INTO Seat
	 VALUES('9Y-ANU','4F')
INSERT INTO Seat
	 VALUES('LN-TUJ','28G')
INSERT INTO Seat
	 VALUES('9Y-GEO','39H')
INSERT INTO Seat
	 VALUES('SP-EQCH','24A')
INSERT INTO Seat
	 VALUES('9Y-TTB','11C')
INSERT INTO Seat
	 VALUES('D-AGWK','67J')
INSERT INTO Seat
	 VALUES('LN-NGY','2A')
	 
	
INSERT INTO Booking
	 VALUES('EK819','60000')
INSERT INTO Booking
	 VALUES('G7205','11244')
INSERT INTO Booking
	 VALUES('IX243','54321')
INSERT INTO Booking
	 VALUES('BA10','60641')
INSERT INTO Booking
	 VALUES('UL162','60000')	
INSERT INTO Booking
	 VALUES('EK819','13478')
INSERT INTO Booking
	 VALUES('G7205','65478')
INSERT INTO Booking
	 VALUES('IX243','11244')
	 
	 

INSERT INTO Land
	 VALUES('9Y-TTA','CMB')
INSERT INTO Land
	 VALUES('9Y-ANU','PGX')
INSERT INTO Land
	 VALUES('LN-TUJ','CCJ')
INSERT INTO Land
	 VALUES('9Y-GEO','KUL')
INSERT INTO Land
	 VALUES('SP-EQCH','DOH')
INSERT INTO Land
	 VALUES('9Y-TTB','SIN')
INSERT INTO Land
	 VALUES('D-AGWK','BKK')
INSERT INTO Land
	 VALUES('LN-NGY','DXB')
INSERT INTO Land
	 VALUES('9Y-TTA','CCJ')
INSERT INTO Land
	 VALUES('D-AGWK','PGX')
INSERT INTO Land
	 VALUES('9Y-TTB','CCJ')

CREATE PROCEDURE FLIGHTNO_CLASS @class VARCHAR(30)
--Display all flight numbers which has the selected class
AS
BEGIN
SELECT flightNo FOM FlightClass
WHERE class=@class  
END
GO

CREATE VIEW NOT_DIRECT_FLIGHT 
--Display flightNo and relavant route order which have not a direct route
AS
SELECT f.flightNo , r.startingPoint , r.turningPoint , r.endingPoint  
FROM Flight f , Flight_Route r
WHERE f.routeNo = r.routeNo AND r.turningPoint IS NOT NULL

SELECT * FROM NOT_DIRECT_FLIGHT



CREATE VIEW MULTIPLE_CLASS_FLIGHT 
--Display flight numbers that are having at least two classes
AS
SELECT f.flightNo , COUNT(fc.class) AS 'Number of classes' , f.fSource , f.destination
FROM Flight f , FlightClass fc
WHERE f.flightNo = fc.flightNo
GROUP BY f.flightNo , f.fSource , f.destination
Having COUNT(fc.class) >= 2

SELECT * FROM MULTIPLE_CLASS_FLIGHT


CREATE VIEW ALL_Airline_Capacity 
--Display the maximum seat in each aline name.
AS
SELECT MAX(noOfSeat) AS 'Maximum Seats', alineAddress  AS 'Airline Name' 
FROM Airplane , Airline
WHERE Airline.alineCode = Airplane.alineCode
GROUP BY alineAddress

SELECT * FROM ALL_Airline_Capacity


CREATE PROCEDURE Airline_Capacity @name varchar(50)
--Display the maximum seat in selected aline name.
AS
BEGIN
SELECT MAX(noOfSeat) AS 'Maximum Seats', alineAddress  AS 'Airline Name' 
FROM Airplane , Airline
WHERE Airline.alineCode = @name AND Airline.alineCode = Airplane.alineCode
GROUP BY alineAddress
END
GO

CREATE PROCEDURE Passengers_Biggerthan @age INT
--Passengers whose age is greater than selected age 
AS
BEGIN
SELECT passportNo , fname , lname 
FROM Passenger
WHERE age > (SELECT age
             FROM Passenger
			 WHERE age= @age)
END
GO

Create VIEW TravelAgency_Passengers
--Count the number of passenger in each Travel Agency
AS
SELECT COUNT(*) AS 'No of Passengers',TAname
FROM Passenger INNER JOIN Travel_Agency
ON Passenger.TAID = Travel_Agency.TAID
GROUP BY TAname


SELECT * FROM TravelAgency_Passengers