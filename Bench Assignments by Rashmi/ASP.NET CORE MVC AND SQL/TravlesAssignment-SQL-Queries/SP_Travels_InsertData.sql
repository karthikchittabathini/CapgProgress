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


exec InsertIntoBusInfo
@boarding = 'CHN',
@date = '2016-07-25',
@price = 445.95,
@rating = 3
go


exec InsertIntoBusInfo
@boarding = 'PUN',
@date = '2017-12-10',
@price = 543.00,
@rating = 4
go

exec InsertIntoBusInfo
@boarding = 'MUM',
@date = '2017-01-28',
@price = 500.50,
@rating = 4
go


exec InsertIntoBusInfo
@boarding = 'PUN',
@date = '2016-03-27',
@price = 333.55,
@rating = 3
go

exec InsertIntoBusInfo
@boarding = 'MUM',
@date = '2016-03-27',
@price = 510.00,
@rating = 4
go