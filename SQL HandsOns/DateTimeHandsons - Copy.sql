create database HandsonDB
-- SQL STRING FUNCTIONS 

--ASCII VALUE
SELECT ASCII('A') AS A, ASCII('B') AS B,   
ASCII('a') AS a, ASCII('b') AS b,  
ASCII(1) AS [1], ASCII(2) AS [2];  
--CHAR VALUE
SELECT CHAR (85) AS [85]
--CHAR INDEX
SELECT CHARINDEX('string', 'This is a string'); 
--CONCAT
SELECT CONCAT ( 'This ', 'is ', ' a ', 'string' ) AS Result;  
--DEFFERENCE
SELECT SOUNDEX('PVN'),SOUNDEX('PAVAN'),DIFFERENCE('PVN','PAVAN')
--LEFT
SELECT LEFT('PAVAN',2);
--RIGHT
SELECT RIGHT('PAVAN',3);
--LEN
SELECT LEN('PAVAN');
--LOWER
SELECT LOWER('PAVAN')
--UPPER
SELECT UPPER('pavan')

--LTRIM  
SELECT LTRIM('     PAVAN')
--RTRIM  
SELECT RTRIM('PAVAN     ')
--QUOTE NAME
SELECT QUOTENAME('PAVAN');
--REPLACE
SELECT REPLACE('PAVAN','N','N UPADHYE'); 
--REVERSE
SELECT REVERSE('PAVAN');

--SQL DATETIME FUNCTIONS
use HandsonDB
CREATE TABLE SampleTbl
(
Num int ,
Quantity int,
LastDate datetime
)
DROP  TABLE SampleTbl
INSERT INTO SampleTbl VALUES (20,10,'2022-01-11 14:50:00')
INSERT INTO SampleTbl VALUES (30,10,'2022-01-12 03:50:00')
SELECT * FROM SampleTbl
--RETURN DATE AS STRING AND CONVRTING SOME INTO SOME STYLES
SELECT CAST (LastDate AS VARCHAR (20)), CONVERT(VARCHAR(30),LastDate, 106 ) FROM SampleTbl
select * from sales
--ADDIND DAY
select dateadd(mm,1,LastDate) from SampleTbl
--DAY DIFFERENCE IN  2 DATES
select DATEDIFF(dd,LastDate,'2022-01-12') from SampleTbl
--GET CURRENT TIME
select cast(getdate() as time ) [time] from SampleTbl
--RETURN MONTH IN DATE
select datename(mm,LastDate) from SampleTbl
--RETURN DAY IN DATE
select datename(dd,LastDate) from SampleTbl
--RETURN YEAR IN DATE
select datename(yyyy,LastDate) from SampleTbl
--RETURN HOUR IN CURRENT TIME
select datepart(hh,GETDATE())
--RETURN MILLISECONDS IN CURRENT TIME
select datepart(ms,GETDATE())
--RETURN MINUTE IN CURRENT TIME
select datepart(mi,GETDATE())
--RETURN MONTH PART
select datepart(mm,LastDate) from SampleTbl









