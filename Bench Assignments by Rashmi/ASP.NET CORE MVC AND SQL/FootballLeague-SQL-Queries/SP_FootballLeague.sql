--Create a stored procedure to insert into the footballleague table
create procedure InsertFootballDetails
		(@Id int,
		@Team1 varchar(50),
		@Team2 varchar(50),
		@status varchar(20),
		@TeamWon varchar(50),
		@Points int)
AS
BEGIN
		SET NOCOUNT ON;
		Insert into footballleague values (@Id, @Team1, @Team2, @status,@TeamWon,@Points)
END
GO


exec InsertFootballDetails
@Id = 1002,
@Team1 = 'Brazil',
@Team2 = 'Portugal',
@status = 'Draw',
@TeamWon = NULL,
@Points = 2
GO

exec InsertFootballDetails
@Id = 1003,
@Team1 = 'England',
@Team2 = 'Japan',
@status = 'Win',
@TeamWon = 'England',
@Points = 4
GO

exec InsertFootballDetails
@Id = 1004,
@Team1 = 'USA',
@Team2 = 'Russia',
@status = 'Win',
@TeamWon = 'Russia',
@Points = 4
GO

exec InsertFootballDetails
@Id = 1005,
@Team1 = 'Portugal',
@Team2 = 'Italy',
@status = 'Draw',
@TeamWon = NULL,
@Points = 2
GO

exec InsertFootballDetails
@Id = 1006,
@Team1 = 'Brazil',
@Team2 = 'France',
@status = 'Win',
@TeamWon = 'Brazil',
@Points = 4
GO

exec InsertFootballDetails
@Id = 1007,
@Team1 = 'England',
@Team2 = 'Russia',
@status = 'Win',
@TeamWon = 'Russia',
@Points = 4
GO

exec InsertFootballDetails
@Id = 1008,
@Team1 = 'Japan',
@Team2 = 'USA',
@status = 'Draw',
@TeamWon = NULL,
@Points = 2
GO
