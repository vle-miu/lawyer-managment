USE [DemoDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/27/2020 5:53:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LawyerOffice]    Script Date: 3/27/2020 5:53:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LawyerOffice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[ImgProfile] [nvarchar](1000) NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Latitude] [float] NOT NULL,
	[Longtitude] [float] NOT NULL,
	[Introduction] [nvarchar](1500) NULL,
	[Price] [decimal](18, 4) NULL,
	[WorkingTime] [nvarchar](200) NULL,
	[Email] [nvarchar](500) NULL,
	[Phone] [nchar](10) NOT NULL,
	[HomePage] [nvarchar](1000) NULL,
	[Others] [nvarchar](1000) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[UpdatedUser] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/27/2020 5:53:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](500) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](100) NULL,
	[Age] [int] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedUser] [int] NULL,
	[UpdatedUser] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200227092549_Initial', N'3.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200227095712_removeNickname', N'3.1.1')
SET IDENTITY_INSERT [dbo].[LawyerOffice] ON 

INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (1, N'NAM THÁI', N'assets/img/icon/office-thumbnail.png', N'91 Trần Văn Kiểu, Phường 10, Quận 6, Thành phố Hồ Chí Minh', 10.7354, 106.626817, N'Văn phòng luật sư Nam Thai', CAST(5000000.0000 AS Decimal(18, 4)), N'8h-17h, Thứ 2-6 hàng tuần', N'namthai@gmail.com', N'023004553 ', N'https://namethai.com', NULL, CAST(N'2020-03-27T08:17:50.247' AS DateTime), CAST(N'2020-03-27T08:17:50.243' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (2, N'MINH KHÔI', N'assets/img/icon/office-thumbnail.png', N'377A Phan Văn Trị, Phường 11, Quận Bình Thạnh, Thành phố Hồ Chí Minh', 10.818496, 106.694804, N'Văn phòng luật sư Minh Khoi', CAST(5000000.0000 AS Decimal(18, 4)), N'8h-17h, Thứ 2-7 hàng tuần', N'minhkhoi@gmail.com', N'022863666 ', N'https://minhkhoi.com', NULL, CAST(N'2020-03-27T08:20:23.343' AS DateTime), CAST(N'2020-03-27T08:20:23.343' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (3, N'THỦ KHOA', N'assets/img/icon/office-thumbnail.png', N'số 26/3/2 (tầng trệt) Đường số 12, Khu phố 4, phường Tam Bình, quận Thủ Đức, Thành phố Hồ Chí Minh', 10.86546, 106.731173, N'Văn phòng luật sư Thu Khoa', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'thukhoa@gmail.com', N'020789891 ', N'https://thukhoa.com', NULL, CAST(N'2020-03-27T08:22:21.087' AS DateTime), CAST(N'2020-03-27T08:22:21.087' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (4, N'VĨNH AN - JEFF LEONG, POON & WONG', N'assets/img/icon/office-thumbnail.png', N'85/2B Trần Kế Xương ,
Phường 7, Quận Phú Nhuận, Thành
phố Hồ Chí Minh', 10.802819, 106.688097, N'Văn phòng luật sư VĨNH AN - JEFF LEONG, POON & WONG', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'vinhan-support@gmail.com', N'020789891 ', N'https://vinhan-support.com', NULL, CAST(N'2020-03-27T08:26:14.050' AS DateTime), CAST(N'2020-03-27T08:26:14.050' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (6, N'SÀI GÒN GIA ĐỊNH', N'assets/img/icon/office-thumbnail.png', N'99 đường số 19, Phường 8, Quận Gò Vấp, Thành phố Hồ Chí Minh', 10.840342, 106.655063, N'Văn phòng luật sư SÀI GÒN GIA ĐỊNH', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'saigon-giadinh@gmail.com', N'0801740062', N'https://saigon-giadinh.com', NULL, CAST(N'2020-03-27T08:28:53.123' AS DateTime), CAST(N'2020-03-27T08:28:53.123' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (8, N'HOÀNG VIỆT LUẬT', N'assets/img/icon/office-thumbnail.png', N'số 459 Hai Bà Trưng, Phường 8, Quận 3, Thành phố Hồ Chí Minh', 10.791723, 106.686963, N'HOÀNG VIỆT LUẬT', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'hoangvietluat@gmail.com', N'0912174062', N'https://hoangvietluat.com', NULL, CAST(N'2020-03-27T08:30:22.447' AS DateTime), CAST(N'2020-03-27T08:30:22.447' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (9, N'BIZLAW VIỆT NAM', N'assets/img/icon/office-thumbnail.png', N'Central Plaza (Phòng 1403), 17 Lê Duẩn, phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh', 10.784136, 106.70259, N'BIZLAW VIỆT NAM', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'bizlaw-vietnam@gmail.com', N'0915274062', N'https://bizlaw-vietnam.com', NULL, CAST(N'2020-03-27T08:32:18.920' AS DateTime), CAST(N'2020-03-27T08:32:18.920' AS DateTime), 3, 3)
INSERT [dbo].[LawyerOffice] ([ID], [Name], [ImgProfile], [Address], [Latitude], [Longtitude], [Introduction], [Price], [WorkingTime], [Email], [Phone], [HomePage], [Others], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (10, N'INVEST CONSULT SÀI GÒN', N'assets/img/icon/office-thumbnail.png', N'số 11 (tầng 2) Trần Quý Khoách, Phường Tân Định, Quận 1, Thành phố Hồ Chí Minh', 10.793732, 106.689373, N'Cong ty luat INVEST CONSULT SÀI GÒN', CAST(5000000.0000 AS Decimal(18, 4)), N'8h30-17h30, Thứ 2-6 hàng tuần', N'investconsult-saigon@gmail.com', N'0915274123', N'https://investconsult-saigon.com', NULL, CAST(N'2020-03-27T08:34:25.730' AS DateTime), CAST(N'2020-03-27T08:34:25.730' AS DateTime), 3, 3)
SET IDENTITY_INSERT [dbo].[LawyerOffice] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [Address], [Age], [FirstName], [LastName], [Role], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (2, N'nguyenbh', N'15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', N'nguyenbh@gmail.com', N'Binh Dinh', 30, N'Nguyen', N'Banh', N'Admin', CAST(N'2020-02-26T04:10:14.067' AS DateTime), CAST(N'2020-03-13T08:19:11.357' AS DateTime), 0, 3)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [Address], [Age], [FirstName], [LastName], [Role], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (3, N'nhatlv', N'15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', N'nhatlv2@gmail.com', N'Binh Hai - Binh Son - Quang Ngai', 26, N'Nhat2', N'Le2', N'Admin', CAST(N'2020-02-26T04:32:03.170' AS DateTime), CAST(N'2020-02-26T04:34:21.363' AS DateTime), 2, 3)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [Address], [Age], [FirstName], [LastName], [Role], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (4, N'cuongnv', N'15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', N'cuongnv@gmail.com', N'Ha Tinh', 26, N'Cuong', N'Nguyen', N'User', CAST(N'2020-02-26T04:32:57.727' AS DateTime), CAST(N'2020-02-26T04:32:57.727' AS DateTime), 2, 2)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [Address], [Age], [FirstName], [LastName], [Role], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (5, N'thaont', N'15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', N'thaont@gmail.com', N'Da Nang', 24, N'Thao', N'Nguyen', N'User', CAST(N'2020-02-26T04:35:29.820' AS DateTime), CAST(N'2020-02-26T04:35:29.820' AS DateTime), 2, 2)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [Address], [Age], [FirstName], [LastName], [Role], [CreatedDate], [UpdatedDate], [CreatedUser], [UpdatedUser]) VALUES (10, N'trangnt', N'15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', N'trangnt@gmail.com', N'Da Nang', 30, N'Trang', N'Nguyen', N'user', CAST(N'2020-03-13T09:27:23.033' AS DateTime), CAST(N'2020-03-13T09:27:23.033' AS DateTime), 3, 3)
SET IDENTITY_INSERT [dbo].[User] OFF
