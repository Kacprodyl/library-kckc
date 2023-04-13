USE [master]
GO

/****** Object:  Database [library-kckc]    Script Date: 13.04.2023 17:50:42 ******/
CREATE DATABASE [library-kckc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'library-kckc_Data', FILENAME = N'c:\dzsqls\library-kckc.mdf' , SIZE = 30720KB , MAXSIZE = 30720KB , FILEGROWTH = 22528KB )
 LOG ON 
( NAME = N'library-kckc_Logs', FILENAME = N'c:\dzsqls\library-kckc.ldf' , SIZE = 8192KB , MAXSIZE = 30720KB , FILEGROWTH = 22528KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library-kckc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [library-kckc] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [library-kckc] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [library-kckc] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [library-kckc] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [library-kckc] SET ARITHABORT OFF 
GO

ALTER DATABASE [library-kckc] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [library-kckc] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [library-kckc] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [library-kckc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [library-kckc] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [library-kckc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [library-kckc] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [library-kckc] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [library-kckc] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [library-kckc] SET  ENABLE_BROKER 
GO

ALTER DATABASE [library-kckc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [library-kckc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [library-kckc] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [library-kckc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [library-kckc] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [library-kckc] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [library-kckc] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [library-kckc] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [library-kckc] SET  MULTI_USER 
GO

ALTER DATABASE [library-kckc] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [library-kckc] SET DB_CHAINING OFF 
GO

ALTER DATABASE [library-kckc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [library-kckc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [library-kckc] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [library-kckc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [library-kckc] SET QUERY_STORE = ON
GO

ALTER DATABASE [library-kckc] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [library-kckc] SET  READ_WRITE 
GO

