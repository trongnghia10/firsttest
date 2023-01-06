-- Bài 1
create database THUCTAP;
use THUCTAP;

create table _user(
	id int primary key,
	username varchar(50),
	_role varchar(50),
	email varchar(50)
);

insert into _user values('6','fasalytch','premium','much.premium@role.com'),
						('13','luckygirl','regular','fun@meh.com'),
						('16','todayhumor','guru','today@humor.com'),
						('23','Felix','admin','felix@codefights.com'),
						('52','admin666','AdmiN','iamtheadmin@admin.admin'),
						('87','solver100500','regular','email@notbot.com');

select * from _user;

-- Truy vấn:
select email
from _user
where _role not in('premium','admin')
order by email asc;