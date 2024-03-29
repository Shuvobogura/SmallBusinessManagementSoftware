USE [master]
GO
/****** Object:  Database [BusinessManagementSystemDb]    Script Date: 10/15/2019 10:24:00 PM ******/
CREATE DATABASE [BusinessManagementSystemDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusinessManagementSystemDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SILENTREVENGER\MSSQL\DATA\BusinessManagementSystemDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BusinessManagementSystemDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SILENTREVENGER\MSSQL\DATA\BusinessManagementSystemDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BusinessManagementSystemDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusinessManagementSystemDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET  MULTI_USER 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusinessManagementSystemDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusinessManagementSystemDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BusinessManagementSystemDb]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] NULL,
	[Code] [varchar](10) NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[LoyaltyPoint] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NULL,
	[Name] [varchar](50) NULL,
	[ReorderLevel] [int] NULL,
	[Description] [varchar](100) NULL,
	[CategoryId] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchases](
	[Id] [int] NOT NULL,
	[Date] [date] NULL,
	[BillNo] [varchar](50) NULL,
	[Code] [varchar](50) NULL,
	[AvailableQuantity] [int] NULL,
	[ManufacturedDate] [date] NULL,
	[ExpiredDate] [date] NULL,
	[Remarks] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [float] NULL,
	[TotalPrice] [float] NULL,
	[MRP] [float] NULL,
	[CategoryId] [int] NULL,
	[SupplierId] [int] NULL,
	[ProductId] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] NULL,
	[Date] [date] NULL,
	[Quantity] [int] NULL,
	[TotalMRP] [float] NULL,
	[GrandTotal] [float] NULL,
	[Discount] [float] NULL,
	[DiscountAmount] [float] NULL,
	[PayableAmount] [float] NULL,
	[CategoryId] [int] NULL,
	[ProductId] [int] NULL,
	[CustomerId] [int] NULL,
	[PurchaseId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] NULL,
	[Code] [varchar](10) NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[ContactPerson] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ProductsView]    Script Date: 10/15/2019 10:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create VIEW [dbo].[ProductsView] AS
select P.Id, P.Code, P.Name, C.Name as Category, P.ReorderLevel, P.Description  from Products as P INNER JOIN Categories as C ON P.CategoryId = C.Id
GO
USE [master]
GO
ALTER DATABASE [BusinessManagementSystemDb] SET  READ_WRITE 
GO
