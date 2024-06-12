create database INVENTORY;
use INVENTORY;

create table Login(username varchar(50), password varchar(50));

insert into Login VALUES
('EMP','emp2024');

select * from Login;

-- Other Functional tables --
create table Materials(Material varchar(100),Material_Category varchar(100));
select * from Materials;

create table Materials_IN (Date date,Material varchar(100),Material_Category varchar(100),Unit varchar(50),Quantity int);
select * from Materials_IN;

create table Materials_OUT(Date date, Material varchar(100),Material_Category varchar(100),Unit varchar(50),Available_Quantity int,Quantity_Out int);

create table Stock(Material varchar(100),Material_Category varchar(100),Unit varchar(50),Avilable_Quantity int);
select * from Stock;


delete from Materials_IN;
delete from Stock;
delete from Materials_OUT;
