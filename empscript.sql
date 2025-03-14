USE [master]
GO
/****** Object:  Database [EmployeeInfo]    Script Date: 27-10-2024 21:26:30 ******/
CREATE DATABASE [EmployeeInfo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeInfo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EmployeeInfo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeInfo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EmployeeInfo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EmployeeInfo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeInfo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeInfo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeInfo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeInfo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeInfo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeInfo] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeInfo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeInfo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeInfo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeInfo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeInfo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeInfo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeInfo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeInfo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeInfo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeInfo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeInfo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeInfo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeInfo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeInfo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeInfo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeInfo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeInfo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeInfo] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeeInfo] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeInfo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeInfo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeInfo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeInfo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeInfo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EmployeeInfo', N'ON'
GO
ALTER DATABASE [EmployeeInfo] SET QUERY_STORE = OFF
GO
USE [EmployeeInfo]
GO
/****** Object:  Table [dbo].[contact]    Script Date: 27-10-2024 21:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[Fristname] [nvarchar](50) NULL,
	[Lastname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Identity] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp]    Script Date: 27-10-2024 21:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp](
	[empid] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 27-10-2024 21:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[Empid] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[Position] [nvarchar](50) NULL,
	[Qualification] [nvarchar](50) NULL,
	[DOB] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empsalary]    Script Date: 27-10-2024 21:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empsalary](
	[Empid] [int] NULL,
	[Empname] [nvarchar](50) NULL,
	[Empposition] [nvarchar](50) NULL,
	[Workeddays] [int] NULL,
	[Date] [datetime] NULL,
	[Total] [float] NULL,
	[dailypay] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[search]    Script Date: 27-10-2024 21:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[search](
	[Rollno] [int] NULL,
	[Name] [nchar](10) NULL,
	[Address] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (1, N'Riya', 18, N'Thane', N'FEMALE    ', N'DIRECTOR', N'GRADUATE', CAST(N'2005-08-18T15:22:00.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (2, N'riya', 19, N'thane', N'FEMALE    ', N'CO', N'GRADUATE', CAST(N'2004-06-10T15:25:00.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (3, N'siya ', 34261, N' dombivli', N'FEMALE ', N'DIRECTOR', N'GRADUATE', CAST(N'1993-10-19T10:39:32.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (4, N' riva ', 33438, N' thane', N'FEMALE ', N'ACCOUNTANT', N'UG', CAST(N'1991-07-19T10:40:34.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (5, N' nikhish', 36257, N'kharghar', N'MALE', N'SECURITY', N'PG', CAST(N'1999-04-07T10:41:46.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (7, N' vihan ', 29983, N'pune ', N'MALE', N'IT', N'PG', CAST(N'1982-02-01T10:43:16.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (11, N' vihan', 28, N'dombivili', N'MALE', N'DIRECTOR', N'DIPLOMA ', CAST(N'1995-01-09T13:28:29.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (9, N' dheifh', 45102, N' kdhfpie', N'MALE', N'DIRECTOR', N'GRADUATE', CAST(N'2023-06-24T16:13:14.000' AS DateTime))
INSERT [dbo].[EmployeeDetails] ([Empid], [Name], [Age], [Address], [Gender], [Position], [Qualification], [DOB]) VALUES (10, N' pooja', 19, N'thane', N'FEMALE ', N'IT', N'DIPLOMA ', CAST(N'2004-05-27T19:56:08.000' AS DateTime))
GO
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (1, N'Riya', N'DIRECTOR', 16, CAST(N'2023-06-19T10:45:11.000' AS DateTime), 8000, 2000)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (2, N'riya', N'CO', 16, CAST(N'2023-06-19T10:45:29.000' AS DateTime), 20800, 1300)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (3, N'siya ', N'DIRECTOR', 24, CAST(N'2023-06-19T10:46:47.000' AS DateTime), 12000, 2000)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (4, N' riva ', N'ACCOUNTANT', 24, CAST(N'2023-06-19T10:47:38.000' AS DateTime), 31200, 1300)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (5, N' nikhish', N'SECURITY', 18, CAST(N'2023-06-19T10:47:48.000' AS DateTime), 12600, 700)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (6, N' viraj', N'CLEANER', 28, CAST(N'2023-06-19T10:47:59.000' AS DateTime), 14000, 500)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (7, N' vihan ', N'IT', 4, CAST(N'2023-06-19T10:48:08.000' AS DateTime), 5200, 1300)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (20, N' piyush', N'CO', 20, CAST(N'2023-06-19T10:48:19.000' AS DateTime), 26000, 1300)
INSERT [dbo].[Empsalary] ([Empid], [Empname], [Empposition], [Workeddays], [Date], [Total], [dailypay]) VALUES (2, N'riya', N'CO', 23, CAST(N'2023-09-27T19:58:14.000' AS DateTime), 0, 0)
GO
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (1, N'pooja     ', N'thane     ')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (2, N'shwete    ', N'pune      ')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (3, N'shreya    ', N'majiwada  ')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (4, N'navya     ', N'parel     ')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (5, N'siddh     ', N'kopri     ')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (6, N'kashvi    ', N'ulhasnagar')
INSERT [dbo].[search] ([Rollno], [Name], [Address]) VALUES (7, N'payal     ', N'kalwa     ')
GO
/****** Object:  StoredProcedure [dbo].[SalaryInfo]    Script Date: 27-10-2024 21:26:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SalaryInfo]
	@FromDate datetime,
	@ToDate datetime,
	@EmpName nvarchar(50)
As
Begin

Declare @FromDate1 datetime, @ToDate1 datetime, @EmpName1 nvarchar(50), @Empid int, @Empposition nvarchar(50), @Workeddays int, @Date datetime, @Total float, @dailypay float

--Sql Query to Create Temporary Table
Declare @SalaryInfo table
(
Empid int, Empname nvarchar(50), Empposition nvarchar(50), Workeddays int, Date datetime, Total float, dailypay float
)


Set @FromDate1 = @FromDate
Set @ToDate1 = @ToDate 
Set @EmpName1 = @EmpName 

Declare cur1 cursor for SELECT Empid, Empposition, Workeddays, Date, Total, dailypay from Empsalary where Date >= @FromDate1 and Date <= @ToDate1 and Empname = @EmpName1 order by Date 
Open cur1

FETCH NEXT FROM cur1 into @Empid, @Empposition, @Workeddays, @Date, @Total, @dailypay

WHILE @@FETCH_STATUS = 0
BEGIN
				
	Insert Into @SalaryInfo (Empid, Empname, Empposition, Workeddays, Date, Total, dailypay) 
	Values (@Empid, @Empname1, @Empposition, @Workeddays, @Date, @Total, @dailypay)

FETCH NEXT FROM cur1 into @Empid, @Empposition, @Workeddays, @Date, @Total, @dailypay
End
Close cur1
DEALLOCATE cur1

Select * from @SalaryInfo order by Date

End
GO
USE [master]
GO
ALTER DATABASE [EmployeeInfo] SET  READ_WRITE 
GO
