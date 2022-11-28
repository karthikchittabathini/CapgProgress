-- Retrieve all BoardingPoint and TravelDate for the amount which is greater than 450.

select BoardingPoint , TravelDate, Amount from BusInfo where Amount > 450


-- Create View Bus_View to display the BusID, BoardingPoint whose rating is greater than 3

create view [Bus_View] as
select BusId, BoardingPoint from BusInfo where Rating > 3 

--Executing the View
select * from [Bus_VIew]


-- Retrieve all the BusID, BoardingPoint for the bus travelled on 10-12-2017.

select BusId, BoardingPoint from BusInfo where TravelDate = '2017-12-10'
