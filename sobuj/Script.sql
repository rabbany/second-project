USE [master]
GO
/****** Object:  Database [FairManagementDB]    Script Date: 5/27/2015 10:27:33 AM ******/
CREATE DATABASE [FairManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FairManagementDB', FILENAME = N'I:\Basis\FairManagementVer1.1-master\DB\FairManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FairManagementDB_log', FILENAME = N'I:\Basis\FairManagementVer1.1-master\DB\FairManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FairManagementDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FairManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FairManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FairManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FairManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FairManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FairManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FairManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FairManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FairManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FairManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FairManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FairManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FairManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FairManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [FairManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FairManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FairManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FairManagementDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FairManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FairManagementDB', N'ON'
GO
USE [FairManagementDB]
GO
/****** Object:  Table [dbo].[tbl_VisitingZone]    Script Date: 5/27/2015 10:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_VisitingZone](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZID] [int] NOT NULL,
	[VID] [int] NOT NULL,
 CONSTRAINT [PK_tbl_VisitingZone] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Visitor]    Script Date: 5/27/2015 10:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Visitor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CNumber] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Visitor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Zone]    Script Date: 5/27/2015 10:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Zone](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Zone] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_VisitingZone] ON 

INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (11, 5, 16)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (12, 6, 16)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (13, 7, 16)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (14, 8, 19)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (15, 9, 19)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (16, 7, 20)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (17, 9, 20)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (18, 6, 22)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (19, 8, 22)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (20, 7, 23)
INSERT [dbo].[tbl_VisitingZone] ([ID], [ZID], [VID]) VALUES (21, 8, 23)
SET IDENTITY_INSERT [dbo].[tbl_VisitingZone] OFF
SET IDENTITY_INSERT [dbo].[tbl_Visitor] ON 

INSERT [dbo].[tbl_Visitor] ([ID], [Name], [Email], [CNumber]) VALUES (16, N'Mithun ', N'm@gmail.com', 1913313087)
INSERT [dbo].[tbl_Visitor] ([ID], [Name], [Email], [CNumber]) VALUES (19, N'Sujion', N's@gmail.com', 1723456789)
INSERT [dbo].[tbl_Visitor] ([ID], [Name], [Email], [CNumber]) VALUES (20, N'Raju', N'r@gmail.com', 16543123)
INSERT [dbo].[tbl_Visitor] ([ID], [Name], [Email], [CNumber]) VALUES (22, N'Rabbany', N'ba@gmail.com', 17273344)
INSERT [dbo].[tbl_Visitor] ([ID], [Name], [Email], [CNumber]) VALUES (23, N'Reza', N'e@gmail.com', 192777334)
SET IDENTITY_INSERT [dbo].[tbl_Visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_Zone] ON 

INSERT [dbo].[tbl_Zone] ([ID], [ZoneName]) VALUES (5, N'Enterprise Application Zone')
INSERT [dbo].[tbl_Zone] ([ID], [ZoneName]) VALUES (6, N'Mobile Apps Zone')
INSERT [dbo].[tbl_Zone] ([ID], [ZoneName]) VALUES (7, N'Game and Multimedia Zone')
INSERT [dbo].[tbl_Zone] ([ID], [ZoneName]) VALUES (8, N'Telecom Software Zone')
INSERT [dbo].[tbl_Zone] ([ID], [ZoneName]) VALUES (9, N'Digital Bangladesh Zone')
SET IDENTITY_INSERT [dbo].[tbl_Zone] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_Visitor]    Script Date: 5/27/2015 10:27:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Visitor] ON [dbo].[tbl_Visitor]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_VisitingZone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VisitingZone_PK_tbl_Visitor] FOREIGN KEY([VID])
REFERENCES [dbo].[tbl_Visitor] ([ID])
GO
ALTER TABLE [dbo].[tbl_VisitingZone] CHECK CONSTRAINT [FK_tbl_VisitingZone_PK_tbl_Visitor]
GO
ALTER TABLE [dbo].[tbl_VisitingZone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VisitingZone_PK_tbl_Zone] FOREIGN KEY([ZID])
REFERENCES [dbo].[tbl_Zone] ([ID])
GO
ALTER TABLE [dbo].[tbl_VisitingZone] CHECK CONSTRAINT [FK_tbl_VisitingZone_PK_tbl_Zone]
GO
ALTER TABLE [dbo].[tbl_Zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Zone_tbl_Zone1] FOREIGN KEY([ID])
REFERENCES [dbo].[tbl_Zone] ([ID])
GO
ALTER TABLE [dbo].[tbl_Zone] CHECK CONSTRAINT [FK_tbl_Zone_tbl_Zone1]
GO
USE [master]
GO
ALTER DATABASE [FairManagementDB] SET  READ_WRITE 
GO
