USE [master]
GO

/****** Object:  Database [ResManager]    Script Date: 26/10/2019 2:44:32 CH ******/
CREATE DATABASE [ResManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ResManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ResManager.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ResManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ResManager_log.LDF' , SIZE = 4736KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ResManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ResManager] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ResManager] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ResManager] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ResManager] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ResManager] SET ARITHABORT OFF 
GO

ALTER DATABASE [ResManager] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ResManager] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ResManager] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ResManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ResManager] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ResManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ResManager] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ResManager] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ResManager] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ResManager] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ResManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ResManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ResManager] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ResManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ResManager] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ResManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ResManager] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ResManager] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ResManager] SET  MULTI_USER 
GO

ALTER DATABASE [ResManager] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ResManager] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ResManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ResManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ResManager] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ResManager] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ResManager] SET  READ_WRITE 
GO

