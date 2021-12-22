USE [master]
GO
/****** Object:  Database [Bilet_System]    Script Date: 22.12.2021 23:09:11 ******/
CREATE DATABASE [Bilet_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bilet_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilet_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bilet_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilet_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bilet_System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bilet_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bilet_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bilet_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bilet_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bilet_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bilet_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bilet_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bilet_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bilet_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bilet_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bilet_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bilet_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bilet_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bilet_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bilet_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bilet_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bilet_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bilet_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bilet_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bilet_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bilet_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bilet_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bilet_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bilet_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Bilet_System] SET  MULTI_USER 
GO
ALTER DATABASE [Bilet_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bilet_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bilet_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bilet_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bilet_System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bilet_System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bilet_System', N'ON'
GO
ALTER DATABASE [Bilet_System] SET QUERY_STORE = OFF
GO
USE [Bilet_System]
GO
/****** Object:  Table [dbo].[Bilets]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilets](
	[ID_Bilet] [int] NOT NULL,
	[Address_Bilet] [nvarchar](100) NULL,
	[Date_Bilet] [date] NULL,
	[Time_Bilet] [time](7) NULL,
	[Place_Bilet] [nvarchar](100) NULL,
	[Topic_Bilet] [nvarchar](200) NULL,
	[Category_Bilets] [nvarchar](50) NULL,
	[Price_Bilets] [int] NULL,
 CONSTRAINT [PK_Bilets] PRIMARY KEY CLUSTERED 
(
	[ID_Bilet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cancellation_of_the_Event]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancellation_of_the_Event](
	[ID_Event_Card] [int] NOT NULL,
	[ID_Bilet] [int] NULL,
 CONSTRAINT [PK_Cancellation_of_the_Event] PRIMARY KEY CLUSTERED 
(
	[ID_Event_Card] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event_Card]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event_Card](
	[ID_Event_Card] [int] NOT NULL,
	[Name_Event_Card] [nvarchar](50) NULL,
	[Amount_of_visitors] [int] NULL,
	[Category_Bilets] [nvarchar](50) NULL,
	[Price_Bilets] [int] NULL,
	[Analytics_Bilets] [nvarchar](max) NULL,
 CONSTRAINT [PK_Event_Card] PRIMARY KEY CLUSTERED 
(
	[ID_Event_Card] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pokupatel]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pokupatel](
	[ID] [int] NOT NULL,
	[Familia] [nvarchar](50) NULL,
	[Imya] [nvarchar](50) NULL,
	[Otchestvo] [nvarchar](50) NULL,
	[ID_Bilet] [int] NULL,
 CONSTRAINT [PK_Pokupatel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodawec]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodawec](
	[ID] [int] NOT NULL,
	[Familia] [nvarchar](50) NULL,
	[Imya] [nvarchar](50) NULL,
	[Otchestvo] [nvarchar](50) NULL,
	[Passport_Num_Series] [nvarchar](11) NULL,
	[Date_of_Birth] [date] NULL,
	[ID_Bilet] [int] NOT NULL,
 CONSTRAINT [PK_Prodawec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refund_Bilets]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refund_Bilets](
	[ID_Bilet] [int] NOT NULL,
	[Amount_Return_Bilets] [int] NULL,
	[Sum_Return] [int] NULL,
 CONSTRAINT [PK_Refund_Bilets] PRIMARY KEY CLUSTERED 
(
	[ID_Bilet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](40) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22.12.2021 23:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IDRole] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bilets]  WITH CHECK ADD  CONSTRAINT [FK_Bilets_Refund_Bilets] FOREIGN KEY([ID_Bilet])
REFERENCES [dbo].[Refund_Bilets] ([ID_Bilet])
GO
ALTER TABLE [dbo].[Bilets] CHECK CONSTRAINT [FK_Bilets_Refund_Bilets]
GO
ALTER TABLE [dbo].[Cancellation_of_the_Event]  WITH CHECK ADD  CONSTRAINT [FK_Cancellation_of_the_Event_Bilets] FOREIGN KEY([ID_Bilet])
REFERENCES [dbo].[Bilets] ([ID_Bilet])
GO
ALTER TABLE [dbo].[Cancellation_of_the_Event] CHECK CONSTRAINT [FK_Cancellation_of_the_Event_Bilets]
GO
ALTER TABLE [dbo].[Event_Card]  WITH CHECK ADD  CONSTRAINT [FK_Event_Card_Cancellation_of_the_Event] FOREIGN KEY([ID_Event_Card])
REFERENCES [dbo].[Cancellation_of_the_Event] ([ID_Event_Card])
GO
ALTER TABLE [dbo].[Event_Card] CHECK CONSTRAINT [FK_Event_Card_Cancellation_of_the_Event]
GO
ALTER TABLE [dbo].[Pokupatel]  WITH CHECK ADD  CONSTRAINT [FK_Pokupatel_Bilets] FOREIGN KEY([ID_Bilet])
REFERENCES [dbo].[Bilets] ([ID_Bilet])
GO
ALTER TABLE [dbo].[Pokupatel] CHECK CONSTRAINT [FK_Pokupatel_Bilets]
GO
ALTER TABLE [dbo].[Pokupatel]  WITH CHECK ADD  CONSTRAINT [FK_Pokupatel_Users] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Pokupatel] CHECK CONSTRAINT [FK_Pokupatel_Users]
GO
ALTER TABLE [dbo].[Prodawec]  WITH CHECK ADD  CONSTRAINT [FK_Prodawec_Bilets] FOREIGN KEY([ID_Bilet])
REFERENCES [dbo].[Bilets] ([ID_Bilet])
GO
ALTER TABLE [dbo].[Prodawec] CHECK CONSTRAINT [FK_Prodawec_Bilets]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Prodawec] FOREIGN KEY([ID])
REFERENCES [dbo].[Prodawec] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Prodawec]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Bilet_System] SET  READ_WRITE 
GO
