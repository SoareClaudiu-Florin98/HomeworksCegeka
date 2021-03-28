/* a. You need to have a way of grouping all your Inventory cars by Brand.*/
SELECT Fk_Brand_Id, Max(Price) AS PRET_MAXIM from CAR, BRAND
WHERE CAR.Fk_Brand_id = BRAND.Brand_Id
GROUP BY Fk_Brand_id
/* b. Given a car Model, you need to be able to display all the ActualCarFeatures for all the cars that are currently in your Inventory.*/
SELECT Feauture FROM ActualCar_Features
WHERE Fk_Model_id =1   
/* c. Given a car Model, you need to be able to display all its Possible Car Features.*/
SELECT Feauture FROM PossibleFeatures
WHERE Fk_Model_id =1  
/*d. You need to know all the customers who bought cars to in the past month, in order to check for their feedback.*/
SELECT CUSTOMER.First_Name,CUSTOMER.Email FROM CUSTOMER, ORDERS,ORDER_CAR
where CUSTOMER.Customer_Id = ORDERS.Fk_Customer_Id AND ORDERS.Order_Id = ORDER_CAR.Fk_Order_Id 
AND ORDER_CAR.Buy_Date >  EOMONTH(DATEADD(month, -1, Current_timestamp)); 

/*e. You need to know all the customers who expressed interest in a car the past month but did not end up buying it,
in order to be able to contact them and persuade them to buy it.*/
Select CUSTOMER.Customer_Id,CUSTOMER.First_Name,CUSTOMER.Last_Name,CUSTOMER.Email from CUSTOMER 
EXCEPT
SELECT CUSTOMER.Customer_Id,CUSTOMER.First_Name,CUSTOMER.Last_Name,CUSTOMER.Email FROM CUSTOMER,ORDERS
WHERE CUSTOMER.Customer_Id = ORDERS.Fk_Customer_Id

/*f. Given a certain fabrication year, you need to display all the cars in your inventory that were produced that year.*/
SELECT * FROM CAR 
WHERE YEAR(CAR.Manufacturing_Date) = 2019
/*g. Given a certain price range, you need to be able to present the range of Models to your potential customers.*/
SELECT* FROM MODEL WHERE 
Price BETWEEN 20000 AND 40000
/*h. Given a certain feature (Diesel vs Gas vs Electric/ Manual vs Automatic etc), you need to be able to present a range of cars in your Inventory to your potential customers for a test drive.*/
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Diesel',1) ; 
INSERT INTO ActualCar_Features(Feauture,Fk_Model_id) VALUES ('Diesel',2) ; 

SELECT CAR.Car_Id,CAR.Manufacturing_Date,BRAND.Brand_Name FROM CAR,BRAND,MODEL,ActualCar_Features
WHERE  CAR.Fk_Brand_id= BRAND.Brand_Id AND MODEL.Fk_Brand_id = BRAND.Brand_Id AND MODEL.Model_Id = ActualCar_Features.Fk_Model_id AND ActualCar_Features.Feauture= 'Diesel'



