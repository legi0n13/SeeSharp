create table friends (
  id INTEGER,
  name TEXT,
  birthday DATE
);
insert into friends (id,name,birthday)
values
(1,'Ororo Munroe', '1940-05-30'),
(2,'legi0n 13' , '2001-01-27'),
(3,'John Doe', '1983-12-13');

update friends 
set name = 'Storm'
where id =1;

alter table friends
add column email text;

update friends 
set email = 'storm@codecademy.com'
where id =1;

update friends 
set email = 'legi0n13tr@gmail.com'
where id =2;

update friends 
set email = 'johndoe@icloud.com'
where id =3;

delete from friends
where id =1;



select * from friends;