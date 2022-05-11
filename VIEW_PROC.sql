select * from [dbo].[vw_EmployeeAccount]

create view vw_EmployeeDepartment
as
select [Fname], [Minit], 
		[Lname], [Ssn], [Bdate],
		[Address], [Sex], [Salary], [Super_ssn], [Dno],[Dname]
from [dbo].[EMPLOYEE] e , [dbo].[DEPARTMENT] d
where e.Dno = d.Dnumber

-- Tao view cho bang employee (Fname,Lname) 
   --               / project (pname, pnumber ) / works_on (hour)
  create view vw_EmployeeProjectWork
   as 
   select [Fname],[Lname],[Pname],[Pnumber] ,[Hours]
   from 
   [dbo].[EMPLOYEE] e,
   [dbo].[PROJECT] p,
   [dbo].[WORKS_ON] w
   where e.Ssn=w.Essn and p.Pnumber=w.Pno
-- tao procedure add/ update / delete
CREATE PROC PRC_ADD_ACCOUNT (@ssn char(9), 
                             @userName varchar(50),
							 @password varchar(50),@role varchar(50) )
as
begin
	insert account values (@ssn,@userName,@password,@role)
end

exec PRC_ADD_ACCOUNT '453453453' ,'emp3','123456','employee'
Select * from 
CREATE PROC PRC_DELETE_ACCOUNT (@ssn char(9))
as
begin
	delete account where ssn = @ssn
end
exec PRC_DELETE_ACCOUNT '453453453'

Select * from ACCOUNT

CREATE PROC PRC_UPDATE_ACCOUNT (@ssn char(9), 
                             @userName varchar(50),
							 @password varchar(50),@role varchar(50) )
as
begin
	update account 
	set UserName = @userName,
	[Password] = @password,
	[Role] = @role
	where ssn = @ssn
end
exec PRC_UPDATE_ACCOUNT '333445555' ,'EMP2','4567891','employee'

Select * from ACCOUNT
