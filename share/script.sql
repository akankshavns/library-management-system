USE [master]
GO
/****** Object:  Database [LibraryDB]    Script Date: 16-07-2024 09:10:14 ******/
CREATE DATABASE [LibraryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryDB', FILENAME = N'C:\Users\HP\LibraryDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryDB_log', FILENAME = N'C:\Users\HP\LibraryDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LibraryDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LibraryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryDB] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LibraryDB] SET QUERY_STORE = OFF
GO
USE [LibraryDB]
GO
/****** Object:  Table [dbo].[AddBooks]    Script Date: 16-07-2024 09:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddBooks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](50) NULL,
	[AuthorName] [varchar](50) NULL,
	[publicationName] [varchar](50) NULL,
	[purchaseDate] [date] NULL,
	[price] [float] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librarian]    Script Date: 16-07-2024 09:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librarian](
	[Id] [int] NOT NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentInformation]    Script Date: 16-07-2024 09:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInformation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EnrollmentNumber] [varchar](50) NULL,
	[StudentName] [varchar](50) NULL,
	[RollNumber] [bigint] NULL,
	[StudentPhoto] [image] NULL,
	[Department] [varchar](50) NULL,
	[Semester] [nchar](10) NULL,
	[Contact] [bigint] NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AddBooks] ON 

INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (1, N'The House by the highway', N'nitesh singh', N'xyz', CAST(N'2023-02-01' AS Date), 150, 4)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (2, N'123', N'456', N'234', CAST(N'2023-01-02' AS Date), 30, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (8, N'123', N'456', N'234', CAST(N'2023-01-02' AS Date), 30, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (9, N'123', N'456', N'234', CAST(N'2023-01-03' AS Date), 30, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (10, N'123', N'456', N'234', CAST(N'2024-08-08' AS Date), 30, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (11, N'123', N'456', N'234', CAST(N'2023-02-01' AS Date), 300, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (12, N'123', N'456', N'234', CAST(N'2023-01-02' AS Date), 300, 23)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (13, N'sql basics', N'barboze', N'abc', CAST(N'2028-09-17' AS Date), 456, 3)
INSERT [dbo].[AddBooks] ([Id], [BookName], [AuthorName], [publicationName], [purchaseDate], [price], [quantity]) VALUES (14, N'abcdef', N'djgjdg', N'jidigr', CAST(N'2024-06-20' AS Date), 234, 344)
SET IDENTITY_INSERT [dbo].[AddBooks] OFF
GO
INSERT [dbo].[Librarian] ([Id], [userName], [password]) VALUES (1, N'Akanksha', N'1311')
INSERT [dbo].[Librarian] ([Id], [userName], [password]) VALUES (2, N'vikash', N'1432')
GO
SET IDENTITY_INSERT [dbo].[StudentInformation] ON 

INSERT [dbo].[StudentInformation] ([Id], [EnrollmentNumber], [StudentName], [RollNumber], [StudentPhoto], [Department], [Semester], [Contact], [Email], [Address]) VALUES (4, N'ECC2214003', N'Akanksha Mishara', 14204, 0x53797374656D2E57696E646F77732E466F726D732E50696374757265426F782C2053697A654D6F64653A2053747265746368496D616765, N'BCA', N'5         ', 8573070101, N'makanksha858@gmail.com', N'jhunsi prayagraj')
INSERT [dbo].[StudentInformation] ([Id], [EnrollmentNumber], [StudentName], [RollNumber], [StudentPhoto], [Department], [Semester], [Contact], [Email], [Address]) VALUES (5, N'ECC2214036', N'abcd', 14039, 0x53797374656D2E57696E646F77732E466F726D732E50696374757265426F782C2053697A654D6F64653A2053747265746368496D616765, N'BCA', N'5         ', 1234567821, N'djkjka@gmail.com', N'prayagraj')
INSERT [dbo].[StudentInformation] ([Id], [EnrollmentNumber], [StudentName], [RollNumber], [StudentPhoto], [Department], [Semester], [Contact], [Email], [Address]) VALUES (7, N'ECC2214039', N'Vikash Gupta', 221407, 0x53797374656D2E57696E646F77732E466F726D732E50696374757265426F782C2053697A654D6F64653A2053747265746368496D616765, N'BCA', N'V         ', 9794366574, N'000153vikash@gmail.com', N'Bhadohi')
SET IDENTITY_INSERT [dbo].[StudentInformation] OFF
GO
USE [master]
GO
ALTER DATABASE [LibraryDB] SET  READ_WRITE 
GO
