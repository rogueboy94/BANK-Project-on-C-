USE [master]
GO
/****** Object:  Database [BANK Management]    Script Date: 20.07.2017 16:26:48 ******/
CREATE DATABASE [BANK Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BANK Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BANK Management.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BANK Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BANK Management_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BANK Management] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BANK Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BANK Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BANK Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BANK Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BANK Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BANK Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [BANK Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BANK Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BANK Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BANK Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BANK Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BANK Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BANK Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BANK Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BANK Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BANK Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BANK Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BANK Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BANK Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BANK Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BANK Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BANK Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BANK Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BANK Management] SET RECOVERY FULL 
GO
ALTER DATABASE [BANK Management] SET  MULTI_USER 
GO
ALTER DATABASE [BANK Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BANK Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BANK Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BANK Management] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BANK Management] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BANK Management', N'ON'
GO
USE [BANK Management]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 20.07.2017 16:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[ID] [uniqueidentifier] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 20.07.2017 16:26:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Payment] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](10) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Credits]    Script Date: 20.07.2017 16:26:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credits](
	[ID] [uniqueidentifier] NOT NULL,
	[DebitorID] [uniqueidentifier] NOT NULL,
	[Amount] [bigint] NOT NULL,
	[Balance] [bigint] NOT NULL,
	[OpenDate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Credits] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payments]    Script Date: 20.07.2017 16:26:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[ID] [uniqueidentifier] NOT NULL,
	[CreditsID] [uniqueidentifier] NOT NULL,
	[Amount] [bigint] NOT NULL,
	[PaymentDate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Credits]  WITH CHECK ADD  CONSTRAINT [FK_Credits_Clients1] FOREIGN KEY([DebitorID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Credits] CHECK CONSTRAINT [FK_Credits_Clients1]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Credits] FOREIGN KEY([CreditsID])
REFERENCES [dbo].[Credits] ([ID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Credits]
GO
USE [master]
GO
ALTER DATABASE [BANK Management] SET  READ_WRITE 
GO
