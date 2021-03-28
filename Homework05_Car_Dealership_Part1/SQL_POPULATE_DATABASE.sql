insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('soareclaudiuflorin@gmail.com', 'Claudiu-Florin','Soare') ; 
insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('ilieadrian@gmail.com', 'Adrian','Ilie') ; 
insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('creangaelena@gmail.com', 'Elena','Creanga') ; 
insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('mihaidraghia@gmail.com', 'Mihai','Draghia') ; 
insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('sandicacristian@gmail.com', 'Cristian','Sandica') ; 
insert into CUSTOMER(Email, First_Name, Last_Name) VALUES ('biancaduduman@gmail.com', 'Duduman','Bianca') ; 


INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (1, 1);
INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (2, 2);
INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (3, 3);
INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (4, 4);
INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (5, 5);
INSERT INTO ORDERS(Order_Id, Fk_Customer_Id) VALUES (6, 6);


insert into BRAND(Brand_Id,Brand_Name) VALUES(1,'Volkswagen'); 
insert into BRAND(Brand_Id,Brand_Name) VALUES(2,'Bugatti'); 
insert into BRAND(Brand_Id,Brand_Name) VALUES(3,'Ford'); 
insert into BRAND(Brand_Id,Brand_Name) VALUES(4,'Dacia'); 


insert into CAR(Manufacturing_Date,Fk_Brand_id) values( '2020-10-10',1);
insert into CAR(Manufacturing_Date,Fk_Brand_id) values( '2019-11-10',2); 
insert into CAR(Manufacturing_Date,Fk_Brand_id) values( '2014-07-09',3); 
insert into CAR(Manufacturing_Date,Fk_Brand_id) values( '2018-12-10',4); 





INSERT INTO ORDER_CAR(Order_Car_Id,Fk_Order_Id,Fk_Car_Id,Buy_Date) VALUES (1,1,3,'2021-03-03') ; 
INSERT INTO ORDER_CAR(Order_Car_Id,Fk_Order_Id,Fk_Car_Id,Buy_Date) VALUES (2,3,2,'2020-04-07') ; 
INSERT INTO ORDER_CAR(Order_Car_Id,Fk_Order_Id,Fk_Car_Id,Buy_Date) VALUES (3,4,4,'2019-02-03') ; 
INSERT INTO ORDER_CAR(Order_Car_Id,Fk_Order_Id,Fk_Car_Id,Buy_Date) VALUES (4,2,1,'2018-03-03') ; 


INSERT INTO MODEL(Model_Id, Model_Name, Fk_Brand_id,Price) VALUES (1,'Passerati',1,50000) ; 
INSERT INTO MODEL(Model_Id, Model_Name, Fk_Brand_id,Price) VALUES (2,'Veiron',2,40000) ; 
INSERT INTO MODEL(Model_Id,Model_Name, Fk_Brand_id,Price) VALUES (3,'Focus',3,30000) ; 
INSERT INTO MODEL(Model_Id, Model_Name, Fk_Brand_id,Price) VALUES (4,'Logan',4,20000) ; 


INSERT INTO PossibleFeatures(Feauture,Fk_Model_id) VALUES ('Flying',1) ; 
INSERT INTO PossibleFeatures(Feauture,Fk_Model_id) VALUES ('Drawing',1); 
INSERT INTO PossibleFeatures(Feauture,Fk_Model_id) VALUES ('Cooking',2); 
INSERT INTO PossibleFeatures(Feauture,Fk_Model_id) VALUES ('Music',3); 

INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Turbo',1) ; 
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Turbine',1);
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Turbine',2) ; 
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Navigation',3) ; 
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Golden rims',4) ; 




