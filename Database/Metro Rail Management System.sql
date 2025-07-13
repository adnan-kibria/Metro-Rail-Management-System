USE [Metro Rail Management System]
GO
/****** Object:  Table [dbo].[Fare_management1]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fare_management1](
	[F_ID] [int] IDENTITY(1,1) NOT NULL,
	[From_Station] [varchar](max) NOT NULL,
	[To_Station] [varchar](max) NOT NULL,
	[Ticket_Price] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Fare_management1] PRIMARY KEY CLUSTERED 
(
	[F_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone_No] [int] NULL,
	[Date_Of_Birth] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[NID_No] [int] NULL,
	[Address] [nvarchar](max) NULL,
	[Date_Of_Travel] [datetime] NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Probation_Passenger]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Probation_Passenger](
	[Pro_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone_No] [int] NULL,
	[Date_Of_Birth] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[NID_No] [int] NULL,
	[Address] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
	[Token] [nvarchar](50) NULL,
 CONSTRAINT [PK_Probation_Passenger] PRIMARY KEY CLUSTERED 
(
	[Pro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revenue]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revenue](
	[R_ID] [int] IDENTITY(1,1) NOT NULL,
	[Total_Ticket_Sold] [int] NULL,
	[Total_Ticket_Cost] [int] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Revenue] PRIMARY KEY CLUSTERED 
(
	[R_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales_Report]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Report](
	[Sales_ID] [int] IDENTITY(1,1) NOT NULL,
	[Day] [nvarchar](50) NULL,
	[Month] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Total_Revenue] [int] NULL,
	[Total_Passenger_Count] [int] NULL,
 CONSTRAINT [PK_Sales_Report] PRIMARY KEY CLUSTERED 
(
	[Sales_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StationDetails]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StationDetails](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[Station_Name] [nvarchar](50) NOT NULL,
	[Station_Location] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StationDetails] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[T_ID] [int] IDENTITY(1,1) NOT NULL,
	[Phone_No] [int] NULL,
	[From_Station] [varchar](50) NULL,
	[To_Station] [varchar](max) NULL,
	[Date] [datetime] NULL,
	[Total_Ticket] [int] NULL,
	[Total_Amount] [float] NULL,
	[Unique_Token] [varchar](max) NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[NID_No] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIP_Passenger]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIP_Passenger](
	[VIP_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone_No] [int] NOT NULL,
	[Date_Of_Birth] [datetime] NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[NID_No] [int] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Balance] [int] NULL,
	[Token] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_VIP_Passenger] PRIMARY KEY CLUSTERED 
(
	[VIP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zone_Analysis]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zone_Analysis](
	[Zone_ID] [int] IDENTITY(1,1) NOT NULL,
	[Station_Name] [nvarchar](50) NULL,
	[Total_Ticket_Sold] [int] NULL,
 CONSTRAINT [PK_Zone_Analysis] PRIMARY KEY CLUSTERED 
(
	[Zone_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Fare_management1] ON 
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (1, N'Uttara North
', N'Uttara Center
', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (2, N'Uttara North', N'Uttara South', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (4, N'Uttara North', N'Pallabi ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (5, N'Uttara North', N'Mirpur-11', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (6, N'Uttara North ', N'Mirpur-10', N'40
')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (7, N'Uttara North', N'Kajipara', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (8, N'Uttara North', N'Shewrapara
', N'50')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (10, N'Uttara North', N'Agargaon', N'60')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (11, N'Uttara Center', N'Uttara North', N'20
')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (12, N'Uttara Center', N'Uttara South ', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (13, N'Uttara Center', N'Pallabi', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (14, N'Uttara Center', N'Mirpur-11    ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (15, N'Uttara Center', N'Mirpur-10', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (16, N'Uttara Center', N'Kajipara
', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (17, N'Uttara Center', N'Shewrapara
', N'40
')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (18, N'Uttara Center', N'Agargaon', N'50')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (20, N'Uttara South ', N'Uttara North', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (21, N'Uttara South', N'Uttara Center', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (22, N'Uttara South', N'Pallabi', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (24, N'Uttara South ', N'Mirpur-11', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (25, N'Uttara South', N'Mirpur-10', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (26, N'Uttara South', N'Kajipara
', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (28, N'Uttara South', N'Shewrapara
', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (29, N'Uttara South', N'Agargaon', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (30, N'Pallabi', N'Uttara North ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (31, N'Pallabi ', N'Uttara Center', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (32, N'Pallabi', N'Uttara South', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (33, N'Pallabi', N'Mirpur-11', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (34, N'Pallabi', N'Mirpur-10', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (36, N'Pallabi', N'Kajipara
', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (37, N'Pallabi', N'Shewrapara
', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (38, N'Pallabi', N'Agargaon', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (39, N'Mirpur-11 ', N'Uttara North', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (40, N'Mirpur-11 ', N'Uttara Center', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (41, N'Mirpur-11', N'Uttara South ', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (42, N'Mirpur-11', N'Pallabi', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (43, N'Mirpur-11', N'Mirpur-10', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (44, N'Mirpur-11 ', N'Kajipara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (45, N'Mirpur-11', N'Shewrapara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (46, N'Mirpur-11', N'Agargaon', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (47, N'Mirpur-10', N'Uttara North', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (48, N'Mirpur-10', N'Uttara Center', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (49, N'Mirpur-10', N'Uttara South ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (50, N'Mirpur-10', N'Pallabi', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (51, N'Mirpur-10', N'Mirpur-11', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (52, N'Mirpur-10', N'Kajipara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (53, N'Mirpur-10', N'Shewrapara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (54, N'Mirpur-10', N'Agargaon', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (55, N'Kajipara', N'Uttara North ', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (56, N'Kajipara', N'Uttara Center', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (57, N'Kajipara', N'Uttara South ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (58, N'Kajipara', N'Pallabi ', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (59, N'Kajipara', N'Mirpur-11', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (60, N'Kajipara', N'Mirpur-10', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (61, N'Kajipara', N'Shewrapara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (62, N'Kajipara', N'Agargaon', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (63, N'Shewrapara', N'Uttara North', N'50')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (64, N'Shewrapara', N'Uttara Center', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (65, N'Shewrapara', N'Uttara South', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (66, N'Shewrapara', N'Pallabi ', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (67, N'Shewrapara', N'Mirpur-11', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (68, N'Shewrapara', N'Mirpur-10', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (69, N'Shewrapara', N'Kajipara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (70, N'Shewrapara', N'Agargaon', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (71, N'Agargaon', N'Uttara North', N'60')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (72, N'Agargaon', N'Uttara Center', N'50')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (73, N'Agargaon', N'Uttara South ', N'40')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (74, N'Agargaon', N'Pallabi', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (75, N'Agargaon ', N'Mirpur-11', N'30')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (76, N'Agargaon', N'Mirpur-10', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (77, N'Agargaon', N'Kajipara', N'20')
GO
INSERT [dbo].[Fare_management1] ([F_ID], [From_Station], [To_Station], [Ticket_Price]) VALUES (78, N'Agargaon', N'Shewrapara', N'20')
GO
SET IDENTITY_INSERT [dbo].[Fare_management1] OFF
GO
SET IDENTITY_INSERT [dbo].[Passenger] ON 
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (1, N'Raisul', N'rais@gmail.com', 12783999, CAST(N'2005-12-06T00:00:00.000' AS DateTime), N'Male', 8427822, N'Chittagong', CAST(N'2025-02-04T12:11:55.770' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (2, NULL, NULL, 1837826, CAST(N'2002-06-12T00:00:00.000' AS DateTime), NULL, NULL, NULL, CAST(N'2025-02-04T12:11:55.770' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (3, N'Minar', N'minar@gmail.com', 14831793, CAST(N'2001-02-01T00:00:00.000' AS DateTime), N'Male', 498723, N'Dhaka', CAST(N'2025-02-04T12:11:55.770' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (4, N'Ushmita', N'ushmita@gmail.com', 1387328, NULL, NULL, NULL, NULL, CAST(N'2025-02-04T12:11:55.770' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (5, NULL, NULL, 17610000, NULL, NULL, NULL, NULL, CAST(N'2025-02-05T23:04:12.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (6, NULL, NULL, 13740000, NULL, NULL, NULL, NULL, CAST(N'2025-02-05T23:52:30.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (7, NULL, NULL, 15000000, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:12:37.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (8, NULL, NULL, 1655552220, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:22:53.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (9, NULL, NULL, 19888222, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:29:27.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (10, NULL, NULL, 1288666, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:31:19.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (11, NULL, NULL, 12556699, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:38:25.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (12, NULL, NULL, 1977222, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:42:56.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (13, NULL, NULL, 16220000, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:44:58.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (14, NULL, NULL, 17555888, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:50:34.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (15, NULL, NULL, 172299, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T00:58:25.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (16, NULL, NULL, 76228782, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T01:13:23.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (17, NULL, NULL, 532778, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T01:15:32.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (18, N'Adnan', N'kibria@gmail.com', 1979000000, CAST(N'2000-12-01T00:00:00.000' AS DateTime), N'Male', 763487236, N'Gurudaspur,Natore', CAST(N'2025-02-06T01:17:00.790' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (19, NULL, NULL, 1482700, NULL, NULL, NULL, NULL, CAST(N'2025-02-06T02:06:42.000' AS DateTime))
GO
INSERT [dbo].[Passenger] ([P_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Date_Of_Travel]) VALUES (20, N'Kibria', N'adnan@gmail.com', 1761000000, CAST(N'2003-12-01T00:00:00.000' AS DateTime), N'Male', 73793, N'Gurudaspur,Natore', CAST(N'2025-02-06T02:12:47.083' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Passenger] OFF
GO
SET IDENTITY_INSERT [dbo].[Revenue] ON 
GO
INSERT [dbo].[Revenue] ([R_ID], [Total_Ticket_Sold], [Total_Ticket_Cost], [Date]) VALUES (1, 50, 1300, CAST(N'2025-03-02' AS Date))
GO
INSERT [dbo].[Revenue] ([R_ID], [Total_Ticket_Sold], [Total_Ticket_Cost], [Date]) VALUES (2, 100, 5530, CAST(N'2025-04-02' AS Date))
GO
INSERT [dbo].[Revenue] ([R_ID], [Total_Ticket_Sold], [Total_Ticket_Cost], [Date]) VALUES (3, 20, 640, CAST(N'2025-04-02' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Revenue] OFF
GO
SET IDENTITY_INSERT [dbo].[Sales_Report] ON 
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (1, N'4', N'2', N'2025', 10000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (2, N'4', N'2', N'2025', 1000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (3, N'4', N'2', N'2025', 3000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (4, N'4', N'2', N'2025', 15000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (5, N'4', N'2', N'2025', 5000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (6, N'4', N'2', N'2025', 3000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (7, N'4', N'2', N'2025', 2000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (8, N'4', N'2', N'2025', 100, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (9, N'4', N'2', N'2025', 20000, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (10, N'4', N'2', N'2025', 500, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (11, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (12, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (13, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (14, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (15, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (16, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (17, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (18, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (19, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (20, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (21, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (22, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (23, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (24, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (25, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (26, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (27, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (28, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (29, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (30, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (31, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (32, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (33, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (34, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (35, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (36, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (37, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (38, N'4', N'2', N'2025', NULL, 4)
GO
INSERT [dbo].[Sales_Report] ([Sales_ID], [Day], [Month], [Year], [Total_Revenue], [Total_Passenger_Count]) VALUES (39, N'4', N'2', N'2025', NULL, 4)
GO
SET IDENTITY_INSERT [dbo].[Sales_Report] OFF
GO
SET IDENTITY_INSERT [dbo].[StationDetails] ON 
GO
INSERT [dbo].[StationDetails] ([S_ID], [Station_Name], [Station_Location], [Status]) VALUES (1, N'Uttara_Uttar', N'Uttara', N'Enable')
GO
INSERT [dbo].[StationDetails] ([S_ID], [Station_Name], [Station_Location], [Status]) VALUES (2, N'Pallabi', N'Pallabi', N'Enable')
GO
INSERT [dbo].[StationDetails] ([S_ID], [Station_Name], [Station_Location], [Status]) VALUES (3, N'Mirpur_10', N'Mirpur_10', N'Enable')
GO
SET IDENTITY_INSERT [dbo].[StationDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 
GO
INSERT [dbo].[Ticket] ([T_ID], [Phone_No], [From_Station], [To_Station], [Date], [Total_Ticket], [Total_Amount], [Unique_Token]) VALUES (1, 76228782, N'Pallabi', N'Kajipara', CAST(N'2025-02-06T01:13:23.000' AS DateTime), 2, 80, N'CS92')
GO
INSERT [dbo].[Ticket] ([T_ID], [Phone_No], [From_Station], [To_Station], [Date], [Total_Ticket], [Total_Amount], [Unique_Token]) VALUES (2, 532778, N'Uttara_South', N'Mirpur_11', CAST(N'2025-02-06T01:15:32.000' AS DateTime), 2, 80, N'PA26')
GO
INSERT [dbo].[Ticket] ([T_ID], [Phone_No], [From_Station], [To_Station], [Date], [Total_Ticket], [Total_Amount], [Unique_Token]) VALUES (3, 1482700, N'Uttara_Center', N'Mirpur_11', CAST(N'2025-02-06T02:06:42.000' AS DateTime), 2, 80, N'TV44')
GO
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON 
GO
INSERT [dbo].[UserInfo] ([User_ID], [Name], [Email], [Username], [Password], [Date_Of_Birth], [Gender], [NID_No], [Address], [Role]) VALUES (1, N'Adnan', N'adnan@gmail.com', N'adnan', N'0987', CAST(N'2003-12-01' AS Date), N'Male', 7468238, N'Dhaka', N'admin')
GO
INSERT [dbo].[UserInfo] ([User_ID], [Name], [Email], [Username], [Password], [Date_Of_Birth], [Gender], [NID_No], [Address], [Role]) VALUES (2, N'Raisul', N'raisul@gmail.com', N'raisul', N'1234', CAST(N'2002-01-06' AS Date), N'Male', 76464887, N'Dhaka', N'employee')
GO
INSERT [dbo].[UserInfo] ([User_ID], [Name], [Email], [Username], [Password], [Date_Of_Birth], [Gender], [NID_No], [Address], [Role]) VALUES (1001, N'Minar', N'minar@gmail.com', N'minar', N'7654', CAST(N'2003-01-03' AS Date), N'Male', 76288320, N'Dhaka', N'employee')
GO
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[VIP_Passenger] ON 
GO
INSERT [dbo].[VIP_Passenger] ([VIP_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Balance], [Token]) VALUES (1, N'Kibria', N'adnan@gmail.com', 1761000000, CAST(N'2003-12-01T00:00:00.000' AS DateTime), N'Male', 73793, N'Gurudaspur,Natore', 200, N'XE80')
GO
INSERT [dbo].[VIP_Passenger] ([VIP_ID], [Name], [Email], [Phone_No], [Date_Of_Birth], [Gender], [NID_No], [Address], [Balance], [Token]) VALUES (2, N'Adnan', N'kibria@gmail.com', 1979000000, CAST(N'2000-12-01T00:00:00.000' AS DateTime), N'Male', 763487236, N'Gurudaspur,Natore', 700, N'QE49')
GO
SET IDENTITY_INSERT [dbo].[VIP_Passenger] OFF
GO
SET IDENTITY_INSERT [dbo].[Zone_Analysis] ON 
GO
INSERT [dbo].[Zone_Analysis] ([Zone_ID], [Station_Name], [Total_Ticket_Sold]) VALUES (1, N'Uttara_Uttar', 100)
GO
INSERT [dbo].[Zone_Analysis] ([Zone_ID], [Station_Name], [Total_Ticket_Sold]) VALUES (2, N'Mirpu_10', 20)
GO
INSERT [dbo].[Zone_Analysis] ([Zone_ID], [Station_Name], [Total_Ticket_Sold]) VALUES (3, N'Pallabi', 50)
GO
SET IDENTITY_INSERT [dbo].[Zone_Analysis] OFF
GO
ALTER TABLE [dbo].[Passenger] ADD  CONSTRAINT [DF_Date_Of_Travel]  DEFAULT (getdate()) FOR [Date_Of_Travel]
GO
ALTER TABLE [dbo].[Zone_Analysis]  WITH CHECK ADD  CONSTRAINT [FK_Zone_Analysis_Zone_Analysis] FOREIGN KEY([Zone_ID])
REFERENCES [dbo].[Zone_Analysis] ([Zone_ID])
GO
ALTER TABLE [dbo].[Zone_Analysis] CHECK CONSTRAINT [FK_Zone_Analysis_Zone_Analysis]
GO
/****** Object:  StoredProcedure [dbo].[GenerateRandomTicketCode]    Script Date: 2/6/2025 3:08:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerateRandomTicketCode]
AS
BEGIN
    DECLARE @letters CHAR(2)
    DECLARE @numbers CHAR(2)

    -- Generate 2 random uppercase letters
    SET @letters = CHAR(65 + ABS(CHECKSUM(NEWID())) % 26) +
                   CHAR(65 + ABS(CHECKSUM(NEWID())) % 26)

    -- Generate 2 random digits
    SET @numbers = CAST(ABS(CHECKSUM(NEWID())) % 90 + 10 AS CHAR(2))

    -- Insert combined code into TicketTable
    INSERT INTO VIP_Table (Token)
    VALUES (@letters + @numbers)
END;
GO
