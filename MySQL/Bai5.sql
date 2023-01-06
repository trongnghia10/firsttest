-- Bài 5:

create table suspect(
	id int primary key auto_increment,
	name varchar(50),
	surname varchar(50),
	height int,
	weight int
);

insert into suspect (name, surname,height, weight) values	('John','Doe',165,60),
							('Bill','Green',170,67),
							('Baelfire','Grehn',172,70),
							('Bill','Gretan',165,55),
							('Brendon','Grewn',150,50),
							('bill','Green',169,50);

select * from suspect;

select id, name, surname
from suspect
where height<=170 and name like 'B%' and surname like 'Gre_n';