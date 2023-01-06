-- Bài 4:

create table grades(
	name varchar(50),
	id int primary key,
	midterm1 int,
	midterm2 int,
	final int
);

insert into grades values	('David',42334,34,54,124),
							('Anthony',54528,100,10,50),
							('Jonathan',58754,49,58,121),
							('Jonty',11000,25,30,180);

select * from grades;

select name, id
from grades
where final > midterm1+midterm2
order by SUBSTRING(name,1,3), id;