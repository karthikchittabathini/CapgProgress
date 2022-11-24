-- Q1) Retrieve all the winning teams
select WinningTeam from footballleague where Points = 4;
-- by executing the above query we will get russia two times to make it appear for only one time we can use distinct



--Q2)Create View Match_View to display the teams whose status is Draw
create view [Match_View] as 
select * from footballleague where points = 2;

-- executing the view
select * from [Match_View]



--Q3) Retrieve details of all the matches in which japan played
select * from footballleague where TeamName1 = 'Japan' OR TeamName2 = 'Japan'