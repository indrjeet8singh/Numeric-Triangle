create database employee
use employee
create table empl(id int identity primary key , empl_name varchar(50), empl_mobile bigint)
select * from empl
insert into empl(empl_name, 