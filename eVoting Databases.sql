create database eVoting;
use eVoting;

-- table for voter details
create table voter(id varchar(30),name varchar(30),pwd varchar(30),father varchar(30),
age varchar(30), idissue varchar(30),email varchar(30),phone varchar(30),address varchar(30),city varchar(30),
state varchar(30),pincode varchar(30));


select * from voter;

insert into voter values('001','Aman','Delhi','Ram','22','12-08-2018','amankumar@gmail.com',
'888888888','abcd','gurgaon','Haryana','122001');