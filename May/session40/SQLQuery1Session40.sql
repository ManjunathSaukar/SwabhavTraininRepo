Create table student(
	id int identity(1,1) primary key,
	name varchar(20),
	location varchar(20)
)

select * from student

insert into student
		values('name1','location1');
insert into student
		values('name2','location2');