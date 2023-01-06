-- Bài 7:

create table answers(
	id int primary key auto_increment,
	correct_answer varchar(50),
	given_answer varchar(50)
);

insert into answers (correct_answer, given_answer) values	('a','a'),
							('a',NULL),
							('c','b');
select * from answers;

-- Truy vấn:
select id,
case
	when correct_answer = given_answer then 'correct'
    when correct_answer != given_answer then 'incorrect'
else 'no answer'
end as checks
from answers;