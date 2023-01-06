-- Bài 9:

create table full_year(
	id int primary key auto_increment,
    newspaper varchar(50),
    subscriber varchar(50)
);
insert into full_year (newspaper,subscriber)
values ('The Paragon Herald', 'Crissy Sepe'),
		('The Daily Reporter', 'Tonie Moreton'),
        ('Morningtide Daily', 'Erwin Chitty'),
        ('Daily Breakfast', 'Tonie Moreton'),
        ('Independent Weekly', 'Lavelle Phu');
select * from full_year;

create table half_year(
	id int primary key auto_increment,
    newspaper varchar(50),
    subscriber varchar(50)
);
insert into half_year (newspaper,subscriber)
values ('The Daily Reporter','Lavelle Phu'),
		  ('Daily Breakfast','Tonie Moreton'),
		  ('The Paragon Herald','Lia Cover'),
		  ('The Community Gazette','Lavelle Phu'),
		  ('Nova Daily','Lia Cover'),
		  ('Nova Daily','Joya Buss');
select * from half_year;

-- Truy vấn:
select subscriber from full_year
where newspaper like '%Daily%'
union
select subscriber from half_year
where newspaper like '%Daily%'
order by subscriber asc ;
