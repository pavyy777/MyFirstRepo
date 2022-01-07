create database TutorialDB
create table Tutorials
(
TutorialID int,
TutorialName varchar(100),
TutorialDesc varchar(8000),
Published int
)
insert into Tutorials values(1,'c#','A',0)
insert into Tutorials values(2,'c#1','B',1)
insert into Tutorials values(3,'c#2','C',1)
insert into Tutorials values(4,'c#3','D',0)
alter table tutorials add Author varchar(8000)
update tutorials set author ='P' , TutorialID=1 
update tutorials set published=0 where TutorialID=2;
delete from Tutorials where Tutorialid=1 or TutorialDesc='d'or Tutorialid=2
select * from Tutorials