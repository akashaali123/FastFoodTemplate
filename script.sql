USE [master]
GO
/****** Object:  Database [MedicalStore]    Script Date: 11/10/2020 6:02:29 PM ******/
CREATE DATABASE [MedicalStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MedicalStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MedicalStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MedicalStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MedicalStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MedicalStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MedicalStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MedicalStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MedicalStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MedicalStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MedicalStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MedicalStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MedicalStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MedicalStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MedicalStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MedicalStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MedicalStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MedicalStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MedicalStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MedicalStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MedicalStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MedicalStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MedicalStore] SET RECOVERY FULL 
GO
ALTER DATABASE [MedicalStore] SET  MULTI_USER 
GO
ALTER DATABASE [MedicalStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MedicalStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MedicalStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MedicalStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MedicalStore] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MedicalStore', N'ON'
GO
ALTER DATABASE [MedicalStore] SET QUERY_STORE = OFF
GO
USE [MedicalStore]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 11/10/2020 6:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NULL,
	[Formula] [nvarchar](250) NULL,
	[CategoryId] [int] NULL,
	[Quantity] [int] NULL,
	[SoldPricePerUnit] [money] NULL,
	[RetailPricePerUnit] [money] NULL,
	[TabletQuantityPerPacket] [int] NULL,
	[TotalSoldPrice] [money] NULL,
	[TotalPurchasePrice] [money] NULL,
	[TotalTabletStock] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblProduct] ON 

INSERT [dbo].[tblProduct] ([Id], [ProductName], [Formula], [CategoryId], [Quantity], [SoldPricePerUnit], [RetailPricePerUnit], [TabletQuantityPerPacket], [TotalSoldPrice], [TotalPurchasePrice], [TotalTabletStock], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (7, N'adas', N'xsxdas', 1, 12, 0.1333, 0.1333, 15, 24.0000, 24.0000, 180, CAST(N'2020-11-10T12:58:59.150' AS DateTime), CAST(N'2020-11-10T12:58:59.150' AS DateTime), 1)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [Formula], [CategoryId], [Quantity], [SoldPricePerUnit], [RetailPricePerUnit], [TabletQuantityPerPacket], [TotalSoldPrice], [TotalPurchasePrice], [TotalTabletStock], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (8, N'Panadol', N'Paracetamol', 2, 12, 12.0000, 10.0000, NULL, 144.0000, 120.0000, NULL, CAST(N'2020-11-10T17:00:45.263' AS DateTime), CAST(N'2020-11-10T17:00:45.263' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
USE [master]
GO
ALTER DATABASE [MedicalStore] SET  READ_WRITE 
GO
