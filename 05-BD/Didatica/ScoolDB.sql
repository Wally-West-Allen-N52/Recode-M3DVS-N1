create database SchoolDB; --Crete a database
use SchoolDB; -- To connect DB

create table Student ( -- To crreate a table
	registration int not null primary key,
	name varchar(50) not null,
);

select * from Student; -- To select the data

-- To enter data start here
insert into Student (registration, name) values (1, 'Thomas');
insert into Student (registration, name) values (2, 'Athena');
insert into Student (registration, name) values (3, 'Nathally');
-- to enter data end here

delete from Student where registration = 2; -- To delete data in the field

update Student set name = 'Wallace' where registration = 3; -- To uppdate data field

delete from Student; -- To clean table field

drop table Student; -- To delete table

use master; -- To use master

drop database SchoolDB; -- To delete database in master

--THE NEW TABLE--
