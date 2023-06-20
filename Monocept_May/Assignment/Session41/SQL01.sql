CREATE TABLE DEPT (
 DEPTNO              integer NOT NULL,
 DNAME               varchar(14),
 LOC                 varchar(13),
 CONSTRAINT DEPT_PRIMARY_KEY PRIMARY KEY (DEPTNO));
 
INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

select * from DEPT

CREATE TABLE EMP (
 EMPNO               integer NOT NULL,
 ENAME               varchar(10),
 JOB                 varchar(9),
 MGR                 integer ,
 HIREDATE            DATE,
 SAL                 DECIMAL,
 COMM                DECIMAL,
 DEPTNO              integer NOT NULL,
 CONSTRAINT EMP_FOREIGN_KEY FOREIGN KEY (DEPTNO) REFERENCES DEPT (DEPTNO),
 CONSTRAINT EMP_PRIMARY_KEY PRIMARY KEY (EMPNO));


INSERT INTO EMP VALUES (7839,'KING','PRESIDENT',NULL,'1981-11-17',5000,NULL,10);
INSERT INTO EMP VALUES (7698,'BLAKE','MANAGER',7839,'1981-05-1',2850,NULL,30);
INSERT INTO EMP VALUES (7782,'CLARK','MANAGER',7839,'1981-06-01',2450,NULL,10);
INSERT INTO EMP VALUES (7566,'JONES','MANAGER',7839,'1981-06-01',2975,NULL,20);
INSERT INTO EMP VALUES (7654,'MARTIN','SALESMAN',7698,'1981-06-01',1250,1400,30);
INSERT INTO EMP VALUES (7499,'ALLEN','SALESMAN',7698,'1981-06-01',1600,300,30);
INSERT INTO EMP VALUES (7844,'TURNER','SALESMAN',7698,'1981-06-01',1500,0,30);
INSERT INTO EMP VALUES (7900,'JAMES','CLERK',7698,'1981-06-01',950,NULL,30);
INSERT INTO EMP VALUES (7521,'WARD','SALESMAN',7698,'1981-06-01',1250,500,30);
INSERT INTO EMP VALUES (7902,'FORD','ANALYST',7566,'1981-06-01',3000,NULL,20);
INSERT INTO EMP VALUES (7369,'SMITH','CLERK',7902,'1981-06-01',800,NULL,20);
INSERT INTO EMP VALUES (7788,'SCOTT','ANALYST',7566,'1981-06-01',3000,NULL,20);
INSERT INTO EMP VALUES (7876,'ADAMS','CLERK',7788,'1981-06-01',1100,NULL,20);
INSERT INTO EMP VALUES (7934,'MILLER','CLERK',7782,'1981-06-01',1300,NULL,10);

select * from EMP;






-- Q-1. Write an SQL query to fetch “NAME” of the employee from Emp table using the alias name as <FULL_NAME>.
select ENAME AS FULL_NAME from EMP;

-- Q-2. Write an SQL query to fetch “NAME” from EMP table in upper case.
select UPPER(ENAME) from EMP;

-- Q-3. Write an SQL query to fetch unique values of DEPARTMENT from EMP table.
SELECT distinct DEPTNO from EMP;

-- Q-4. Write an SQL query to print the first three characters of  NAME from EMP table.
SELECT SUBSTRING(ENAME,1,3) from EMP;

-- Q-5. Write an SQL query to print all EMP details from the EMP table order by ENAME Ascending.
select * from EMP ORDER by ENAME;

-- Q-6. Write an SQL query to print all EMP details from the EMP table order by ENAME Descending.
select * from EMP ORDER by ENAME DESC;

-- Q-7. Write an SQL query to print details of EMP with JOB as “SALE*”.
select * from EMP where JOB LIKE 'SALE%';

-- Q-8. Write an SQL query to print details of the EMP whose ENAME contains ‘a’.
select * from EMP where ENAME LIKE '%a%';

-- Q-9. Write an SQL query to print details of the EMP whose ENAME ends with ‘a’.
select * from EMP where ENAME LIKE '%a';

-- Q-10. Write an SQL query to print details of the EMP whose ENAME ends with ‘h’ and contains six alphabets.
select * from EMP where ENAME LIKE '_____h';

-- Q-11. Write an SQL query to print details of the EMP whose SALES lies between 2000 and 5000.
select * from EMP where SAL between 2000 AND 5000;

-- Q-12. Write an SQL query to fetch the no. of EMP for each department in the descending order.
select DEPTNO, count(EMPNO) AS no_of_worker from EMP group by DEPTNO ORDER BY no_of_worker desc;

-- Q-13. Write an SQL query to print details of the EMP worked as SALES Depatment.
select e.* from EMP as e inner join DEPT as d on d.DEPTNO = e.DEPTNO where d.DNAME = 'SALES';

-- Q-14. Write an SQL query to fetch number (more than 1) of same JOB in the EMP of different types.
select JOB, count(*) as count from EMP group by JOB having count(*) > 1;

-- Q-15. Write an SQL query to show only odd rows from a table.
select * from EMP where (EMPNO %2) != 0;
select * from EMP where (EMPNO% 2) <> 0;

-- Q-16. Write an SQL query to show only even rows from a table. 
select * from EMP where (EMPNO%2) = 0;

-- Q-17. Write an SQL query to print details of the EMP who have HIREDATE in JUNE’1981.
select * from EMP where YEAR(HIREDATE) =1981 AND MONTH(HIREDATE) = 06;

