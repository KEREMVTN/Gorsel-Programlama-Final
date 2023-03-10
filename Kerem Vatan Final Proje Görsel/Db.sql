USE [master]
GO
/****** Object:  Database [Final]    Script Date: 17.01.2023 19:41:43 ******/
CREATE DATABASE [Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Final] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [Final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Final] SET  MULTI_USER 
GO
ALTER DATABASE [Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Final] SET QUERY_STORE = OFF
GO
USE [Final]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 17.01.2023 19:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[Id] [int] NOT NULL,
	[Ders_Adı] [nvarchar](50) NULL,
	[Ders_Kredisi] [int] NOT NULL,
	[Okul_Yönetim_Id] [int] NOT NULL,
	[Ders_Rengi] [int] NOT NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 17.01.2023 19:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Id] [int] NOT NULL,
	[Ad_Soyad] [nvarchar](50) NULL,
	[Kayıt_Tarihi] [datetime] NOT NULL,
	[Öğrenci_No] [nvarchar](50) NULL,
	[Doğum_Tarihi] [datetime] NOT NULL,
	[Bölümü] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDers]    Script Date: 17.01.2023 19:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDers](
	[Id] [int] NOT NULL,
	[Ders_Id] [int] NOT NULL,
	[Ogrenci_Id] [int] NOT NULL,
 CONSTRAINT [PK_OgrenciDers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 17.01.2023 19:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] NOT NULL,
	[Ad_Soyad] [nvarchar](50) NULL,
	[Görevi] [nvarchar](50) NULL,
	[Yönetim_Tipi] [int] NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ders] ([Id], [Ders_Adı], [Ders_Kredisi], [Okul_Yönetim_Id], [Ders_Rengi]) VALUES (0, N'Matematik', 1, 0, 1)
INSERT [dbo].[Ders] ([Id], [Ders_Adı], [Ders_Kredisi], [Okul_Yönetim_Id], [Ders_Rengi]) VALUES (1, N'Medeniyet Tarihi', 3, 0, 2)
INSERT [dbo].[Ders] ([Id], [Ders_Adı], [Ders_Kredisi], [Okul_Yönetim_Id], [Ders_Rengi]) VALUES (2, N'Bilgi Güvenliği', 2, 0, 3)
INSERT [dbo].[Ders] ([Id], [Ders_Adı], [Ders_Kredisi], [Okul_Yönetim_Id], [Ders_Rengi]) VALUES (3, N'Bilgisayar Teknolojileri ve Programlama', 3, 3, 4)
GO
INSERT [dbo].[Ogrenci] ([Id], [Ad_Soyad], [Kayıt_Tarihi], [Öğrenci_No], [Doğum_Tarihi], [Bölümü]) VALUES (0, N'Kerem Vatan', CAST(N'2023-01-17T03:11:45.000' AS DateTime), N'20200108012', CAST(N'2001-02-14T03:11:45.000' AS DateTime), N'BIP')
INSERT [dbo].[Ogrenci] ([Id], [Ad_Soyad], [Kayıt_Tarihi], [Öğrenci_No], [Doğum_Tarihi], [Bölümü]) VALUES (1, N'Sadettin Dursun', CAST(N'2023-01-17T03:11:45.000' AS DateTime), N'20200108010', CAST(N'2023-01-17T03:11:45.000' AS DateTime), N'BIP')
INSERT [dbo].[Ogrenci] ([Id], [Ad_Soyad], [Kayıt_Tarihi], [Öğrenci_No], [Doğum_Tarihi], [Bölümü]) VALUES (2, N'Ahmet Burak Durmuş', CAST(N'2023-01-17T03:11:45.000' AS DateTime), N'20200108001', CAST(N'2023-01-17T03:11:45.000' AS DateTime), N'BIP')
GO
INSERT [dbo].[OgrenciDers] ([Id], [Ders_Id], [Ogrenci_Id]) VALUES (0, 0, 0)
INSERT [dbo].[OgrenciDers] ([Id], [Ders_Id], [Ogrenci_Id]) VALUES (1, 1, 0)
INSERT [dbo].[OgrenciDers] ([Id], [Ders_Id], [Ogrenci_Id]) VALUES (2, 0, 1)
INSERT [dbo].[OgrenciDers] ([Id], [Ders_Id], [Ogrenci_Id]) VALUES (3, 0, 2)
INSERT [dbo].[OgrenciDers] ([Id], [Ders_Id], [Ogrenci_Id]) VALUES (4, 1, 2)
GO
INSERT [dbo].[Personel] ([Id], [Ad_Soyad], [Görevi], [Yönetim_Tipi]) VALUES (0, N'Hanifi Arslan', N'Eğitim', 11)
INSERT [dbo].[Personel] ([Id], [Ad_Soyad], [Görevi], [Yönetim_Tipi]) VALUES (1, N'Füsun Er', N'eğitim', 11)
INSERT [dbo].[Personel] ([Id], [Ad_Soyad], [Görevi], [Yönetim_Tipi]) VALUES (2, N'Emrah Sarıçiçek', N'Eğitim', 11)
INSERT [dbo].[Personel] ([Id], [Ad_Soyad], [Görevi], [Yönetim_Tipi]) VALUES (3, N'Tanju Sirmen', N'Eğitim', 11)
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_Personel] FOREIGN KEY([Okul_Yönetim_Id])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_Personel]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_Ders] FOREIGN KEY([Ders_Id])
REFERENCES [dbo].[Ders] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_Ders]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_Ogrenci] FOREIGN KEY([Ogrenci_Id])
REFERENCES [dbo].[Ogrenci] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_Ogrenci]
GO
USE [master]
GO
ALTER DATABASE [Final] SET  READ_WRITE 
GO
