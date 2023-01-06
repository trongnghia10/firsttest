-- Bài 8:

create table expressions(
	id int primary key auto_increment,
    a int,
    b int,
    operation varchar(50),
    c int
);

insert into expressions (a,b,operation,c) 
values (2,3,'+',5),
		(2,3,'+',6),
        (3,2,'/',1),
        (4,7,'*',28),
        (5,2,'-',27),
        (6,0,'/',0);
select * from expressions;
-- Truy vấn:
select * from expressions
where operation = '+' and a + b = c or
operation = '-' and a - b = c or
operation = '*' and a * b = c or
operation = '/' and a / b = c;