-- Bài 3:
create table _userb3(

	id int primary key,
	name varchar(50),
	score int
);

insert into _userb3 values	('1','gongy','3001'),
							('2','urandom','2401'),
							('3','eduardische','2477'),
							('4','Gassa','2999'),
							('5','bcc32','2658'),
							('6','Alex_2oo8','6000'),
							('7','mirosuaf','2479'),
							('8','Sparik','2399'),
							('9','thomas_holmes','2478'),
							('10','cthaeghya','2400');
select * from _userb3;
-- Truy vấn:
select name
from _userb3
order by score desc
limit 3,5;