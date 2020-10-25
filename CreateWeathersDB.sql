USE [master]
GO

/****** Object:  Database [Weathers]    Script Date: 25.10.2020 10:59:49 ******/
CREATE DATABASE [Weathers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Weathers', FILENAME = N'C:\Users\sebos\Weathers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Weathers_log', FILENAME = N'C:\Users\sebos\Weathers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Weathers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Weathers] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Weathers] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Weathers] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Weathers] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Weathers] SET ARITHABORT OFF 
GO

ALTER DATABASE [Weathers] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Weathers] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Weathers] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Weathers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Weathers] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Weathers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Weathers] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Weathers] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Weathers] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Weathers] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Weathers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Weathers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Weathers] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Weathers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Weathers] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Weathers] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Weathers] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Weathers] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Weathers] SET  MULTI_USER 
GO

ALTER DATABASE [Weathers] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Weathers] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Weathers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Weathers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Weathers] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Weathers] SET QUERY_STORE = OFF
GO

USE [Weathers]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [Weathers] SET  READ_WRITE 
GO
