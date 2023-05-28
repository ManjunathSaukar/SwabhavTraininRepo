SELECT * FROM EMP
SELECT * FROM DEPT

--display all employee names in descending order
SELECT ENAME FROM EMP ORDER BY ENAME DESC 

--display all empname, salary, commison
SELECT ENAME, SAL, COMM FROM EMP 
WHERE DEPTNO=10

--all employees in dept 10 and 20
SELECT * FROM EMP WHERE DEPTNO =10 OR DEPTNO=20
SELECT * FROM EMP WHERE DEPTNO in (10,20)

--display all employees who are managers
 SELECT * FROM EMP 
 WHERE JOB = 'MANAGER'

 --display all employees whose salary is between 2k and 5k $
 SELECT * FROM EMP 
 WHERE SAL BETWEEN 2000 AND 5000

 --display all employees whoose commision is null
 SELECT * FROM EMP 
 WHERE COMM IS NULL

 --display annual ctc
 SELECT COMM,ISNULL(COMM, -1) FROM EMP
 SELECT ENAME, SAL, COMM, 12*(SAL+ISNULL(COMM,0)) AS CTC FROM EMP

 --display min max avg sum of salaries of employees
 SELECT AVG(SAL) AS 'AVG', MAX(SAL) AS 'MAX', SUM(SAL) AS 'SUM' 
 FROM EMP

 SELECT GETDATE() AS 'TODAY'
 PRINT GETDATE()

 --display 
 SELECT DATEDIFF(YEAR, '10/10/2017',GETDATE()) AS DATEDIFF
 SELECT ENAME, HIREDATE, DATEDIFF(YEAR, HIREDATE,GETDATE()) AS 'TENURE' FROM EMP

 --all emloyees with 's'
SELECT * FROM EMP WHERE ENAME LIKE '%S'

--display unique deptno from emp table
SELECT DISTINCT DEPTNO FROM EMP

--selct top 3 employees with more salaries
SELECT TOP 3 * FROM EMP ORDER BY SAL DESC

--display dept wise no of employees
SELECT DEPTNO, COUNT(DEPTNO) AS EMPLOYEECOUNT
FROM EMP
GROUP BY DEPTNO;

--display job wise employee count 
SELECT JOB, COUNT(*) AS EmployeeCount
FROM EMP
GROUP BY JOB;

-- display dept wise, job wise employee count
SELECT DEPTNO, JOB, COUNT(*) AS EmployeeCount
FROM EMP
GROUP BY DEPTNO, JOB ORDER BY DEPTNO;
