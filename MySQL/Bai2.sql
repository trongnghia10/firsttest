-- Bài 2
create table products(
	id int primary key,
	name varchar(50),
	price int,
	quantity int
);

insert into products values	('1','Tomato',10,4),
							('2','Cucumber',8,5),
							('3','Red Pepper',20,2),
							('4','Feta',40,1);

select * from products;

select  name
from products
where price*quantity = (select max(price*quantity) from products)
order by name asc
limit 1;