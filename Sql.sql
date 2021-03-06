USE [COMPANY_PTPMUD]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[Fname] [varchar](15) NOT NULL,
	[Minit] [char](1) NULL,
	[Lname] [varchar](15) NOT NULL,
	[Ssn] [char](9) NOT NULL,
	[Bdate] [date] NULL,
	[Address] [varchar](30) NULL,
	[Sex] [char](1) NULL,
	[Salary] [decimal](10, 2) NULL,
	[Super_ssn] [char](9) NULL,
	[Dno] [numeric](4, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[ssn] [char](9) NOT NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw__EmployeeAccount]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw__EmployeeAccount]
AS
SELECT        dbo.EMPLOYEE.Fname, dbo.EMPLOYEE.Minit, dbo.EMPLOYEE.Lname, dbo.EMPLOYEE.Ssn, dbo.EMPLOYEE.Salary, dbo.EMPLOYEE.Address, dbo.EMPLOYEE.Sex, dbo.EMPLOYEE.Bdate, dbo.Account.UserName, 
                         dbo.Account.Password, dbo.Account.Role
FROM            dbo.EMPLOYEE INNER JOIN
                         dbo.Account ON dbo.EMPLOYEE.Ssn = dbo.Account.Ssn
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[Dname] [varchar](15) NOT NULL,
	[Dnumber] [numeric](4, 0) NOT NULL,
	[Mgr_ssn] [char](9) NULL,
	[Mgr_start_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_EmployeeDepartment]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_EmployeeDepartment]
AS
SELECT        e.Fname, e.Minit, e.Lname, e.Ssn, e.Bdate, e.Address, e.Sex, e.Salary, e.Super_ssn, e.Dno, d.Dname
FROM            dbo.EMPLOYEE AS e INNER JOIN
                         dbo.DEPARTMENT AS d ON e.Dno = d.Dnumber
GO
/****** Object:  Table [dbo].[PROJECT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROJECT](
	[Pname] [varchar](15) NOT NULL,
	[Pnumber] [int] NOT NULL,
	[Plocation] [varchar](15) NULL,
	[Dnum] [numeric](4, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pnumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKS_ON]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKS_ON](
	[Essn] [char](9) NOT NULL,
	[Pno] [int] NOT NULL,
	[Hours] [decimal](4, 1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Essn] ASC,
	[Pno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_EmployeeProjectWork]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_EmployeeProjectWork]
   as 
   select [Fname],[Lname],[Pname],[Pnumber] ,[Hours]
   from 
   [dbo].[EMPLOYEE] e,
   [dbo].[PROJECT] p,
   [dbo].[WORKS_ON] w
   where e.Ssn=w.Essn and p.Pnumber=w.Pno
GO
/****** Object:  Table [dbo].[DEPT_LOCATIONS]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPT_LOCATIONS](
	[Dnumber] [numeric](4, 0) NOT NULL,
	[Dlocation] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Dnumber] ASC,
	[Dlocation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_DEPENDENT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_DEPENDENT](
	[Essn] [char](9) NOT NULL,
	[Dependent_name] [nvarchar](25) NOT NULL,
	[Sex] [char](1) NULL,
	[Bdate] [date] NULL,
	[Relationship] [varchar](8) NULL,
 CONSTRAINT [PK_depen] PRIMARY KEY CLUSTERED 
(
	[Essn] ASC,
	[Dependent_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([ssn], [userName], [password], [role]) VALUES (N'123456788', N'phu126', N'1234', N'Staff')
INSERT [dbo].[ACCOUNT] ([ssn], [userName], [password], [role]) VALUES (N'123456789', N'phu126', N'1234', N'Staff')
GO
INSERT [dbo].[DEPARTMENT] ([Dname], [Dnumber], [Mgr_ssn], [Mgr_start_date]) VALUES (N'Headquarters', CAST(1 AS Numeric(4, 0)), N'888665555', CAST(N'1971-06-19' AS Date))
INSERT [dbo].[DEPARTMENT] ([Dname], [Dnumber], [Mgr_ssn], [Mgr_start_date]) VALUES (N'Administration', CAST(4 AS Numeric(4, 0)), N'987654321', CAST(N'1985-01-01' AS Date))
INSERT [dbo].[DEPARTMENT] ([Dname], [Dnumber], [Mgr_ssn], [Mgr_start_date]) VALUES (N'Research', CAST(5 AS Numeric(4, 0)), N'333445555', CAST(N'1978-05-22' AS Date))
GO
INSERT [dbo].[DEPT_LOCATIONS] ([Dnumber], [Dlocation]) VALUES (CAST(1 AS Numeric(4, 0)), N'Houston')
INSERT [dbo].[DEPT_LOCATIONS] ([Dnumber], [Dlocation]) VALUES (CAST(4 AS Numeric(4, 0)), N'Stafford')
INSERT [dbo].[DEPT_LOCATIONS] ([Dnumber], [Dlocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Bellaire')
INSERT [dbo].[DEPT_LOCATIONS] ([Dnumber], [Dlocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Houston')
INSERT [dbo].[DEPT_LOCATIONS] ([Dnumber], [Dlocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Sugarland')
GO
INSERT [dbo].[E_DEPENDENT] ([Essn], [Dependent_name], [Sex], [Bdate], [Relationship]) VALUES (N'123456789', N'Alice', N'F', CAST(N'1978-12-31' AS Date), N'Daughter')
INSERT [dbo].[E_DEPENDENT] ([Essn], [Dependent_name], [Sex], [Bdate], [Relationship]) VALUES (N'123456789', N'Elizabeth', N'F', CAST(N'1957-05-05' AS Date), N'Spouse')
INSERT [dbo].[E_DEPENDENT] ([Essn], [Dependent_name], [Sex], [Bdate], [Relationship]) VALUES (N'123456789', N'Michael', N'M', CAST(N'1978-01-01' AS Date), N'Son')
INSERT [dbo].[E_DEPENDENT] ([Essn], [Dependent_name], [Sex], [Bdate], [Relationship]) VALUES (N'333445555', N'Alice', N'F', CAST(N'1976-04-05' AS Date), N'Daughter')
INSERT [dbo].[E_DEPENDENT] ([Essn], [Dependent_name], [Sex], [Bdate], [Relationship]) VALUES (N'333445555', N'Franklin', N'F', CAST(N'1948-05-03' AS Date), N'Spouse')
GO
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'John', N'B', N'Smith', N'123456789', CAST(N'1955-01-09' AS Date), N'Houston,TX', N'M', CAST(30000.00 AS Decimal(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Duy', N'M', N'LN', N'222222222', CAST(N'2000-04-14' AS Date), N'25 OK', N'F', CAST(10000.00 AS Decimal(10, 2)), N'333445555', CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Franklin', N'T', N'Wong', N'333445555', CAST(N'1945-12-08' AS Date), N'Houston,TX', N'M', CAST(40000.00 AS Decimal(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Joyce', N'A', N'English', N'453453453', CAST(N'1962-07-31' AS Date), N'Houston, TX', N'F', CAST(25000.00 AS Decimal(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Ramesh', N'K', N'Narayan', N'666884444', CAST(N'1952-09-15' AS Date), N'Humble,TX', N'M', CAST(38000.00 AS Decimal(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'James', N'E', N'Borg', N'888665555', CAST(N'1927-11-10' AS Date), N'Houston,TX', N'M', CAST(55000.00 AS Decimal(10, 2)), N'888665555', CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Jennifer', N'S', N'Wallace', N'987654321', CAST(N'1931-06-20' AS Date), N'Bellaire,TX', N'F', CAST(43000.00 AS Decimal(10, 2)), N'987654321', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Ahmad', N'V', N'Jabbar', N'987987987', CAST(N'1959-03-29' AS Date), N'Houston,TX', N'M', CAST(25000.00 AS Decimal(10, 2)), N'987654321', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[EMPLOYEE] ([Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]) VALUES (N'Alicia', N'J', N'Zelaya', N'999887777', CAST(N'1958-07-19' AS Date), N'Spring,TX', N'F', CAST(25000.00 AS Decimal(10, 2)), N'987654321', CAST(4 AS Numeric(4, 0)))
GO
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'ProductX', 1, N'Bellaire', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'ProductY', 2, N'Sugarland', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'ProductZ', 3, N'Houston', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'Computerization', 10, N'Stafford', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'Reorganization', 20, N'Houston', CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[PROJECT] ([Pname], [Pnumber], [Plocation], [Dnum]) VALUES (N'Newbenefits', 30, N'Stafford', CAST(4 AS Numeric(4, 0)))
GO
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'123456789', 1, CAST(32.5 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'123456789', 2, CAST(7.5 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'333445555', 2, CAST(10.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'333445555', 3, CAST(10.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'333445555', 10, CAST(10.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'333445555', 20, CAST(10.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'453453453', 1, CAST(20.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'453453453', 2, CAST(20.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'666884444', 3, CAST(40.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'987654321', 20, CAST(15.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'987654321', 30, CAST(20.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'987987987', 10, CAST(35.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'987987987', 30, CAST(5.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'999887777', 10, CAST(10.0 AS Decimal(4, 1)))
INSERT [dbo].[WORKS_ON] ([Essn], [Pno], [Hours]) VALUES (N'999887777', 30, CAST(30.0 AS Decimal(4, 1)))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PROJECT__173BB01C8C0918E3]    Script Date: 10/05/2022 2:56:29 CH ******/
ALTER TABLE [dbo].[PROJECT] ADD UNIQUE NONCLUSTERED 
(
	[Pname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DEPARTMENT]  WITH CHECK ADD FOREIGN KEY([Mgr_ssn])
REFERENCES [dbo].[EMPLOYEE] ([Ssn])
GO
ALTER TABLE [dbo].[E_DEPENDENT]  WITH CHECK ADD  CONSTRAINT [FK_depen] FOREIGN KEY([Essn])
REFERENCES [dbo].[EMPLOYEE] ([Ssn])
GO
ALTER TABLE [dbo].[E_DEPENDENT] CHECK CONSTRAINT [FK_depen]
GO
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD FOREIGN KEY([Super_ssn])
REFERENCES [dbo].[EMPLOYEE] ([Ssn])
GO
ALTER TABLE [dbo].[WORKS_ON]  WITH CHECK ADD FOREIGN KEY([Essn])
REFERENCES [dbo].[EMPLOYEE] ([Ssn])
GO
ALTER TABLE [dbo].[WORKS_ON]  WITH CHECK ADD FOREIGN KEY([Pno])
REFERENCES [dbo].[PROJECT] ([Pnumber])
GO
ALTER TABLE [dbo].[E_DEPENDENT]  WITH CHECK ADD CHECK  (([Sex]='F' OR [Sex]='M'))
GO
/****** Object:  StoredProcedure [dbo].[PRC_ADD_ACCOUNT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PRC_ADD_ACCOUNT] (@ssn char(9),
							@userName varchar(50),
							@password varchar(50),@role varchar(50))
as
begin
	insert Account values (@ssn,@userName,@password,@role)
end
GO
/****** Object:  StoredProcedure [dbo].[PRC_ADD_ACCOUNT1]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PRC_ADD_ACCOUNT1] (@ssn char(9),
							@userName varchar(50),
							@password varchar(50),@role varchar(50))
as
begin
	insert Account values (@ssn,@userName,@password,@role)
end
GO
/****** Object:  StoredProcedure [dbo].[PRC_DELETE_ACCOUNT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PRC_DELETE_ACCOUNT](@ssn char(9))
as
begin
	delete Account where ssn = @ssn
end
GO
/****** Object:  StoredProcedure [dbo].[PRC_UPDATE_ACCOUNT]    Script Date: 10/05/2022 2:56:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PRC_UPDATE_ACCOUNT](@ssn char(9),
							@userName varchar(50),
							@password varchar(50),@role varchar(50))
as
begin
	update Account
	set [UserName] = @userName,
	[Password] = @password,
	[Role] = @role
	where [Ssn] = @ssn
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EMPLOYEE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Account"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw__EmployeeAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw__EmployeeAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "e"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmployeeDepartment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmployeeDepartment'
GO
