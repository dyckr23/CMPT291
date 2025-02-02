USE [master]
GO
/****** Object:  Database [291-RentalCar]    Script Date: 2020-04-03 9:46:30 AM ******/
CREATE DATABASE [291-RentalCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'291-RentalCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\291-RentalCar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'291-RentalCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\291-RentalCar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [291-RentalCar] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [291-RentalCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [291-RentalCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [291-RentalCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [291-RentalCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [291-RentalCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [291-RentalCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [291-RentalCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [291-RentalCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [291-RentalCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [291-RentalCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [291-RentalCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [291-RentalCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [291-RentalCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [291-RentalCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [291-RentalCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [291-RentalCar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [291-RentalCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [291-RentalCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [291-RentalCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [291-RentalCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [291-RentalCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [291-RentalCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [291-RentalCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [291-RentalCar] SET RECOVERY FULL 
GO
ALTER DATABASE [291-RentalCar] SET  MULTI_USER 
GO
ALTER DATABASE [291-RentalCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [291-RentalCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [291-RentalCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [291-RentalCar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [291-RentalCar] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'291-RentalCar', N'ON'
GO
ALTER DATABASE [291-RentalCar] SET QUERY_STORE = OFF
GO
USE [291-RentalCar]
GO
/****** Object:  Table [dbo].[booking]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking](
	[booking_id] [int] NOT NULL,
	[rental_date] [date] NULL,
	[due_date] [date] NULL,
	[car_id] [int] NULL,
	[customer_id] [int] NULL,
	[branch_id] [int] NULL,
 CONSTRAINT [PK_booking] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branch]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branch](
	[branch_id] [int] NOT NULL,
	[address_line_1] [nchar](25) NULL,
	[address_line_2] [nchar](25) NULL,
	[city] [nchar](25) NULL,
	[province] [nchar](25) NULL,
	[postal_code] [nchar](25) NULL,
	[phone] [nchar](20) NULL,
	[email] [nchar](50) NULL,
 CONSTRAINT [PK_branch] PRIMARY KEY CLUSTERED 
(
	[branch_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car](
	[car_id] [int] NOT NULL,
	[make] [nchar](25) NULL,
	[model] [nchar](25) NULL,
	[year] [int] NULL,
	[color] [nchar](25) NULL,
	[mileage] [int] NULL,
 CONSTRAINT [PK_car] PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car_type]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car_type](
	[type_id] [int] NOT NULL,
	[chassis] [nchar](50) NULL,
	[seats] [nchar](10) NULL,
	[daily_rate] [money] NULL,
	[weekly_rate] [money] NULL,
	[monthly_rate] [money] NULL,
 CONSTRAINT [PK_car_type] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[customer_id] [int] NOT NULL,
	[full_name] [nchar](60) NULL,
	[phone] [nchar](20) NULL,
	[email] [nchar](50) NULL,
	[gold_star] [nchar](20) NULL,
	[balance_owed] [float] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2020-04-03 9:46:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employee_id] [int] NOT NULL,
	[username] [nchar](50) NULL,
	[password] [nchar](50) NULL,
	[full_name] [nchar](75) NOT NULL,
	[first_name] [nchar](25) NULL,
	[middle_name] [nchar](25) NULL,
	[last_name] [nchar](25) NULL,
	[phone] [nchar](20) NULL,
	[email] [nchar](50) NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_branch] FOREIGN KEY([booking_id])
REFERENCES [dbo].[branch] ([branch_id])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_branch]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_car] FOREIGN KEY([booking_id])
REFERENCES [dbo].[car] ([car_id])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_car]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_customer] FOREIGN KEY([booking_id])
REFERENCES [dbo].[customer] ([customer_id])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_customer]
GO
USE [master]
GO
ALTER DATABASE [291-RentalCar] SET  READ_WRITE 
GO
