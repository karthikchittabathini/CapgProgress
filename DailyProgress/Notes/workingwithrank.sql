/*
Rank :- The RANK Function in SQL Server is a kind of Ranking Function. 
This function will assign the number to each row within the partition of an output. 
It assigns the rank to each row as one plus the previous row rank.
*/


create table rank_demo(
firstname varchar(25),
lastname varchar(25),
city varchar(25)
);

insert into rank_demo values('Luisa', 'Evans', 'Texas');

insert into rank_demo values
('Paul', 'Ward', 'Alaska'),
('Peter', 'Bennett', 'California'),
('Carlos', 'Patterson', 'New York'),
('Rose', 'Huges', 'Florida'),
('Marielia', 'Simmons', 'Texas'),
('Antonio', 'Butler', 'New York'),
('Diego', 'Cox', 'California');

select * from rank_demo

-- Rank() function with over()
-- syntax
/* 
select column_name
rank() over(
partition by expression 
order by expression 
as desiredcolumnname
from tablename
*/

-- Over clause :- sets the partitioning and ordering of a result before the associated window function is applied.

-- Partition by clause :- divides the output produces by the from clause into the partition. 
--Then the function is applied to each partition and re-initialized when the division border crosses partitions.
--If we have not defined clause, the function will treat all rows as a single partition.

select 
firstname, 
lastname, 
city,
rank() over(order by city) as ranking 
from rank_demo

-- Here in the above query we just used over() with out partion by clause, the function treated the whole as a single partition.

select 
firstname,
lastname,
city,
rank() over(partition by city order by lastname) as partitionrank
from rank_demo


-- row_number() :- return unique sequential number for each row even there are duplicates.

select 
firstname,
lastname,
city,
ROW_NUMBER() over(order by city) as ranking
from 
rank_demo

-- dense_rank() :- unique rank for each row within a partition.

select 
firstname,
lastname,
city,
DENSE_RANK() over(order by city) as ranking
from 
rank_demo

-- Ntile(n) function :- distribute rows of an ordered partition into a pre-defined number (n) .

select 
firstname,
lastname,
city,
ntile(2) over(order by firstname) as ranking
from
rank_demo