USE [Label_Print]
GO
/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 18-08-2021 17:55:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](500) NOT NULL,
	[LastName] [nvarchar](500) NOT NULL,
	[UserName] [nvarchar](500) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Mobile] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](500) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[ProfilePhoto] [nvarchar](4000) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
 CONSTRAINT [PK_EmployeeMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EmployeeMaster] ON 

INSERT [dbo].[EmployeeMaster] ([Id], [FirstName], [LastName], [UserName], [Password], [Mobile], [Email], [Address], [ProfilePhoto], [CreatedBy], [CreationTime]) VALUES (1, N'test', N'test', N'test@gmail.com', N'h6h7+hewrhS55cl6andT+Q==', N'9988776600', N'test@gmail.com', N'noida', NULL, 1, CAST(N'2021-08-17T16:12:31.537' AS DateTime))
INSERT [dbo].[EmployeeMaster] ([Id], [FirstName], [LastName], [UserName], [Password], [Mobile], [Email], [Address], [ProfilePhoto], [CreatedBy], [CreationTime]) VALUES (2, N'test', N'test', N'test2@gmail.com', N'68rZ/43FXJU=', N'9999988888', N'test2@gmail.com', N'noida', NULL, 1, CAST(N'2021-08-18T16:34:10.647' AS DateTime))
INSERT [dbo].[EmployeeMaster] ([Id], [FirstName], [LastName], [UserName], [Password], [Mobile], [Email], [Address], [ProfilePhoto], [CreatedBy], [CreationTime]) VALUES (3, N'test', N'test', N'test3@gmail.cpom', N'68rZ/43FXJU=', N'9999988888', N'test3@gmail.com', N'noida', NULL, 1, CAST(N'2021-08-18T17:21:35.987' AS DateTime))
INSERT [dbo].[EmployeeMaster] ([Id], [FirstName], [LastName], [UserName], [Password], [Mobile], [Email], [Address], [ProfilePhoto], [CreatedBy], [CreationTime]) VALUES (4, N'test', N'test', N'test3@gmail.com', N'68rZ/43FXJU=', N'9999988888', N'test3@gmail.com', N'noida', NULL, 1, CAST(N'2021-08-18T17:26:23.390' AS DateTime))
INSERT [dbo].[EmployeeMaster] ([Id], [FirstName], [LastName], [UserName], [Password], [Mobile], [Email], [Address], [ProfilePhoto], [CreatedBy], [CreationTime]) VALUES (5, N'test', N'test', N'test4@gmail.com', N'68rZ/43FXJU=', N'9999988888', N'test4@gmail.com', N'noida', N'http://localhost:1082/UploadedFiles/Recovery Drill.png', 1, CAST(N'2021-08-18T17:38:58.253' AS DateTime))
SET IDENTITY_INSERT [dbo].[EmployeeMaster] OFF
ALTER TABLE [dbo].[EmployeeMaster] ADD  CONSTRAINT [DF_EmployeeMaster_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
