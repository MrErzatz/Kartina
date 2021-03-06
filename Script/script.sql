USE [master]
GO
/****** Object:  Database [Kartina_V2]    Script Date: 17/01/2019 14:34:11 ******/
CREATE DATABASE [Kartina_V2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kartina_V2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Kartina_V2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kartina_V2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Kartina_V2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kartina_V2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kartina_V2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kartina_V2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kartina_V2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kartina_V2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kartina_V2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kartina_V2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kartina_V2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kartina_V2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kartina_V2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kartina_V2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kartina_V2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kartina_V2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kartina_V2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kartina_V2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kartina_V2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kartina_V2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kartina_V2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kartina_V2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kartina_V2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kartina_V2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kartina_V2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kartina_V2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kartina_V2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kartina_V2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kartina_V2] SET  MULTI_USER 
GO
ALTER DATABASE [Kartina_V2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kartina_V2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kartina_V2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kartina_V2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kartina_V2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kartina_V2] SET QUERY_STORE = OFF
GO
USE [Kartina_V2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Kartina_V2]
GO
/****** Object:  Table [dbo].[Adresse]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresse](
	[idAdresse] [int] IDENTITY(1,1) NOT NULL,
	[rue] [varchar](50) NULL,
	[codePostal] [int] NULL,
	[ville] [varchar](50) NULL,
	[pays] [varchar](50) NULL,
	[typeAdresse] [varchar](1) NULL,
 CONSTRAINT [PK_Adresse] PRIMARY KEY CLUSTERED 
(
	[idAdresse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cadre]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadre](
	[idCadre] [int] IDENTITY(1,1) NOT NULL,
	[nomCadre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cadre] PRIMARY KEY CLUSTERED 
(
	[idCadre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CadreFinition]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CadreFinition](
	[idCadre] [int] NOT NULL,
	[idFinition] [int] NOT NULL,
 CONSTRAINT [PK_CadreFinition] PRIMARY KEY CLUSTERED 
(
	[idCadre] ASC,
	[idFinition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commande]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commande](
	[idCommande] [int] IDENTITY(1,1) NOT NULL,
	[numeroCommande] [int] NOT NULL,
	[dateCommande] [date] NOT NULL,
	[prixCommande] [float] NOT NULL,
	[statutCommande] [varchar](150) NOT NULL,
	[idUtilisateur] [int] NOT NULL,
	[idStatut] [int] NULL,
 CONSTRAINT [PK_Commande] PRIMARY KEY CLUSTERED 
(
	[idCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Finition]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Finition](
	[idFinition] [int] IDENTITY(1,1) NOT NULL,
	[nomFinition] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Finition] PRIMARY KEY CLUSTERED 
(
	[idFinition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Format]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Format](
	[idFormat] [int] IDENTITY(1,1) NOT NULL,
	[nomFormat] [varchar](50) NULL,
 CONSTRAINT [PK_Format] PRIMARY KEY CLUSTERED 
(
	[idFormat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormatFinition]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormatFinition](
	[idFormat] [int] NOT NULL,
	[idFinition] [int] NOT NULL,
 CONSTRAINT [PK_FormatFinition] PRIMARY KEY CLUSTERED 
(
	[idFormat] ASC,
	[idFinition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LigneCommande]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LigneCommande](
	[idPhoto] [int] NOT NULL,
	[idCommande] [int] NOT NULL,
	[idFormat] [int] NOT NULL,
	[idFinition] [int] NOT NULL,
	[idCadre] [int] NOT NULL,
	[quantite] [int] NOT NULL,
	[prix] [float] NOT NULL,
 CONSTRAINT [PK_LigneCommande] PRIMARY KEY CLUSTERED 
(
	[idPhoto] ASC,
	[idCommande] ASC,
	[idFormat] ASC,
	[idFinition] ASC,
	[idCadre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orientation]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orientation](
	[idOrientation] [int] IDENTITY(1,1) NOT NULL,
	[nomOrientation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Orientation] PRIMARY KEY CLUSTERED 
(
	[idOrientation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 17/01/2019 14:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photo](
	[idPhoto] [int] IDENTITY(1,1) NOT NULL,
	[idFormat] [int] NULL,
	[idTheme] [int] NULL,
	[titrePhoto] [varchar](100) NOT NULL,
	[descriptionPhoto] [varchar](max) NULL,
	[prixPhoto] [float] NOT NULL,
	[largeurPhoto] [float] NOT NULL,
	[hauteurPhoto] [float] NOT NULL,
	[idUtilisateur] [int] NOT NULL,
	[idOrientation] [int] NULL,
	[dateDepose] [date] NOT NULL,
 CONSTRAINT [PK_Photo] PRIMARY KEY CLUSTERED 
(
	[idPhoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhotoFormat]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhotoFormat](
	[idPhoto] [int] NOT NULL,
	[idFormat] [int] NOT NULL,
 CONSTRAINT [PK_PhotoFormat] PRIMARY KEY CLUSTERED 
(
	[idPhoto] ASC,
	[idFormat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhotoTag]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhotoTag](
	[idPhoto] [int] NOT NULL,
	[idTag] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfilUtilisateur]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfilUtilisateur](
	[idProfilUtilisateur] [int] IDENTITY(1,1) NOT NULL,
	[typeProfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProfilUtilisateur] PRIMARY KEY CLUSTERED 
(
	[idProfilUtilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statut]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statut](
	[idStatut] [int] IDENTITY(1,1) NOT NULL,
	[nomStatut] [varchar](100) NULL,
 CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED 
(
	[idStatut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[idTag] [int] IDENTITY(1,1) NOT NULL,
	[nomTag] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[idTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Theme]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theme](
	[idTheme] [int] IDENTITY(1,1) NOT NULL,
	[titreTheme] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Theme] PRIMARY KEY CLUSTERED 
(
	[idTheme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThemePhoto]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThemePhoto](
	[idPhoto] [int] NOT NULL,
	[idTheme] [int] NOT NULL,
 CONSTRAINT [PK_ThemePhoto] PRIMARY KEY CLUSTERED 
(
	[idPhoto] ASC,
	[idTheme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThemeTag]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThemeTag](
	[idTheme] [int] NOT NULL,
	[idTag] [int] NOT NULL,
 CONSTRAINT [PK_ThemeTag] PRIMARY KEY CLUSTERED 
(
	[idTheme] ASC,
	[idTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 17/01/2019 14:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[idUtilisateur] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NULL,
	[prenom] [varchar](50) NULL,
	[description] [varchar](200) NULL,
	[email] [nchar](10) NULL,
	[motPass] [nchar](10) NULL,
	[civilité] [nchar](10) NULL,
	[telephone] [nchar](10) NULL,
	[idProfilUtilisateur] [int] NULL,
	[idAdresse] [int] NOT NULL,
 CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[idUtilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CadreFinition]  WITH CHECK ADD  CONSTRAINT [FK_CadreFinition_Cadre] FOREIGN KEY([idCadre])
REFERENCES [dbo].[Cadre] ([idCadre])
GO
ALTER TABLE [dbo].[CadreFinition] CHECK CONSTRAINT [FK_CadreFinition_Cadre]
GO
ALTER TABLE [dbo].[CadreFinition]  WITH CHECK ADD  CONSTRAINT [FK_CadreFinition_Finition] FOREIGN KEY([idFinition])
REFERENCES [dbo].[Finition] ([idFinition])
GO
ALTER TABLE [dbo].[CadreFinition] CHECK CONSTRAINT [FK_CadreFinition_Finition]
GO
ALTER TABLE [dbo].[Commande]  WITH CHECK ADD  CONSTRAINT [FK_Commande_Statut] FOREIGN KEY([idStatut])
REFERENCES [dbo].[Statut] ([idStatut])
GO
ALTER TABLE [dbo].[Commande] CHECK CONSTRAINT [FK_Commande_Statut]
GO
ALTER TABLE [dbo].[FormatFinition]  WITH CHECK ADD  CONSTRAINT [FK_FormatFinition_Finition] FOREIGN KEY([idFinition])
REFERENCES [dbo].[Finition] ([idFinition])
GO
ALTER TABLE [dbo].[FormatFinition] CHECK CONSTRAINT [FK_FormatFinition_Finition]
GO
ALTER TABLE [dbo].[FormatFinition]  WITH CHECK ADD  CONSTRAINT [FK_FormatFinition_Format] FOREIGN KEY([idFormat])
REFERENCES [dbo].[Format] ([idFormat])
GO
ALTER TABLE [dbo].[FormatFinition] CHECK CONSTRAINT [FK_FormatFinition_Format]
GO
ALTER TABLE [dbo].[LigneCommande]  WITH CHECK ADD  CONSTRAINT [FK_LigneCommande_Cadre] FOREIGN KEY([idCadre])
REFERENCES [dbo].[Cadre] ([idCadre])
GO
ALTER TABLE [dbo].[LigneCommande] CHECK CONSTRAINT [FK_LigneCommande_Cadre]
GO
ALTER TABLE [dbo].[LigneCommande]  WITH CHECK ADD  CONSTRAINT [FK_LigneCommande_Commande] FOREIGN KEY([idCommande])
REFERENCES [dbo].[Commande] ([idCommande])
GO
ALTER TABLE [dbo].[LigneCommande] CHECK CONSTRAINT [FK_LigneCommande_Commande]
GO
ALTER TABLE [dbo].[LigneCommande]  WITH CHECK ADD  CONSTRAINT [FK_LigneCommande_Finition] FOREIGN KEY([idFinition])
REFERENCES [dbo].[Finition] ([idFinition])
GO
ALTER TABLE [dbo].[LigneCommande] CHECK CONSTRAINT [FK_LigneCommande_Finition]
GO
ALTER TABLE [dbo].[LigneCommande]  WITH CHECK ADD  CONSTRAINT [FK_LigneCommande_Format] FOREIGN KEY([idFormat])
REFERENCES [dbo].[Format] ([idFormat])
GO
ALTER TABLE [dbo].[LigneCommande] CHECK CONSTRAINT [FK_LigneCommande_Format]
GO
ALTER TABLE [dbo].[LigneCommande]  WITH CHECK ADD  CONSTRAINT [FK_LigneCommande_Photo] FOREIGN KEY([idPhoto])
REFERENCES [dbo].[Photo] ([idPhoto])
GO
ALTER TABLE [dbo].[LigneCommande] CHECK CONSTRAINT [FK_LigneCommande_Photo]
GO
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD  CONSTRAINT [FK_Photo_Orientation] FOREIGN KEY([idOrientation])
REFERENCES [dbo].[Orientation] ([idOrientation])
GO
ALTER TABLE [dbo].[Photo] CHECK CONSTRAINT [FK_Photo_Orientation]
GO
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD  CONSTRAINT [FK_Photo_Utilisateur] FOREIGN KEY([idUtilisateur])
REFERENCES [dbo].[Utilisateur] ([idUtilisateur])
GO
ALTER TABLE [dbo].[Photo] CHECK CONSTRAINT [FK_Photo_Utilisateur]
GO
ALTER TABLE [dbo].[PhotoFormat]  WITH CHECK ADD  CONSTRAINT [FK_PhotoFormat_Format] FOREIGN KEY([idFormat])
REFERENCES [dbo].[Format] ([idFormat])
GO
ALTER TABLE [dbo].[PhotoFormat] CHECK CONSTRAINT [FK_PhotoFormat_Format]
GO
ALTER TABLE [dbo].[PhotoFormat]  WITH CHECK ADD  CONSTRAINT [FK_PhotoFormat_Photo1] FOREIGN KEY([idPhoto])
REFERENCES [dbo].[Photo] ([idPhoto])
GO
ALTER TABLE [dbo].[PhotoFormat] CHECK CONSTRAINT [FK_PhotoFormat_Photo1]
GO
ALTER TABLE [dbo].[PhotoTag]  WITH CHECK ADD  CONSTRAINT [FK_PhotoTag_Photo] FOREIGN KEY([idPhoto])
REFERENCES [dbo].[Photo] ([idPhoto])
GO
ALTER TABLE [dbo].[PhotoTag] CHECK CONSTRAINT [FK_PhotoTag_Photo]
GO
ALTER TABLE [dbo].[PhotoTag]  WITH CHECK ADD  CONSTRAINT [FK_PhotoTag_Tag] FOREIGN KEY([idTag])
REFERENCES [dbo].[Tag] ([idTag])
GO
ALTER TABLE [dbo].[PhotoTag] CHECK CONSTRAINT [FK_PhotoTag_Tag]
GO
ALTER TABLE [dbo].[ThemePhoto]  WITH CHECK ADD  CONSTRAINT [FK_ThemePhoto_Photo] FOREIGN KEY([idPhoto])
REFERENCES [dbo].[Photo] ([idPhoto])
GO
ALTER TABLE [dbo].[ThemePhoto] CHECK CONSTRAINT [FK_ThemePhoto_Photo]
GO
ALTER TABLE [dbo].[ThemePhoto]  WITH CHECK ADD  CONSTRAINT [FK_ThemePhoto_Theme] FOREIGN KEY([idTheme])
REFERENCES [dbo].[Theme] ([idTheme])
GO
ALTER TABLE [dbo].[ThemePhoto] CHECK CONSTRAINT [FK_ThemePhoto_Theme]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Adresse] FOREIGN KEY([idAdresse])
REFERENCES [dbo].[Adresse] ([idAdresse])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Adresse]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_ProfilUtilisateur] FOREIGN KEY([idProfilUtilisateur])
REFERENCES [dbo].[ProfilUtilisateur] ([idProfilUtilisateur])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_ProfilUtilisateur]
GO
USE [master]
GO
ALTER DATABASE [Kartina_V2] SET  READ_WRITE 
GO
