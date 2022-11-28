
-- creating a table with name BusInfo

create table BusInfo
(
BusId int primary key identity(1,1),
BoardingPoint varchar(4),
TravelDate date,
Amount float,
Rating int
);


-- Display the contents of the table
select * from BusInfo

-- stored procedure to insert the data to the BusInfo table
create procedure InsertIntoBusInfo
(
@boarding varchar(4),
@date date,
@price float,
@rating int
)
as
begin

set nocount on;
insert into BusInfo(BoardingPoint, TravelDate, Amount, Rating) 
values(@boarding, @date, @price, @rating)

end
go

-- Executing the stored procedure
exec InsertIntoBusInfo
@boarding = 'BYL',
@date = '2017-06-18',
@price = 400.65,
@rating = 2
go


exec InsertIntoBusInfo
@boarding = 'HYD',
@date = '2017-10-05',
@price = 600.00,
@rating = 3
go

