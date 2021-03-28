Create database CarDealership

Use CarDealership


CREATE TABLE CUSTOMER
(
Customer_Id int identity(1,1) primary key,
Email varchar(50),
First_Name varchar(50),
Last_Name varchar(50)
)

CREATE TABLE ORDERS
(
	Order_Id int  primary key,
	Fk_Customer_Id int foreign key references CUSTOMER(Customer_Id)
)

CREATE TABLE BRAND
(
	Brand_Id int primary key, 
	Brand_Name varchar(30)
)
CREATE TABLE CAR
(
	Car_Id int identity(1,1) primary key,
	Manufacturing_Date date,
	Fk_Brand_id int  unique foreign key references BRAND(Brand_id)	
)
CREATE TABLE ORDER_CAR
(
	Order_Car_Id int primary key,
	Fk_Order_Id int foreign key references ORDERS(Order_Id),
	Fk_Car_Id int foreign key references CAR(Car_Id),
	Buy_Date date
)

CREATE TABLE MODEL
(
	Model_Id int primary key,
	Model_Name varchar(50),
	Fk_Brand_id int foreign key references BRAND(Brand_id),
	Price int

) 

CREATE TABLE PossibleFeatures
(
	PossibleFeauture_Id int identity(1,1) primary key,
	Feauture varchar(20),
	Fk_Model_id int foreign key references MODEL(Model_Id)
)
CREATE TABLE ActualCar_Features
(
	ActualCar_Features_Id int identity(1,1) primary key,
	Feauture varchar(20),
	Fk_Model_id int foreign key references MODEL(Model_Id)
)
