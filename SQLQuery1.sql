create database Shopping

create table customer
(
custid int primary Key,
custname varchar(30),
city varchar(30) ,
custstate varchar(20)
)

create table products
(
prodid int primary key,
prodname varchar(15),
unitprice int,
UnitOfMeasurement int,
QtyinStock int
)

Create  table sales_header
(
invno int,
invdate date,
invamt int,
disPercent int,
custid int primary key,
)
 create  table sales_detail
 (
invno int,
custid int,
prodid int,
qtysold int

)
use Shopping

alter table sales_detail
add foreign key(custid) references customer(custid)

drop  table customer
create table customer
(
custid int primary Key,
custname varchar(30),
city varchar(30) ,
custstate varchar(20)
)
drop table products

alter table sales_detail
add foreign key(prodid) references products(prodid)

alter table sales_detail
drop column qtysold

alter table sales_detail
add qty int