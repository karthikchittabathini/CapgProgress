create table footballleague(
MatchId int primary key,
TeamName1 varchar(50) NOT NULL,
TeamName2 varchar(50) NOT NULL,
Statuss varchar(20) NOT NULL,
WinningTeam varchar(50),
Points int NOT NULL
);

-- Display all the data in the table
select * from footballleague


-- Insert data into the table 
insert into footballleague values(1001, 'Italy', 'France', 'Win', 'France', 4);
