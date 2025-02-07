USE [ĐTH_K22CNT1Lesson07]
GO
/****** Object:  Table [dbo].[dthKhoa]    Script Date: 6/17/2024 9:14:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dthKhoa](
	[ĐthID] [nchar](10) NOT NULL,
	[ĐthTenKh] [nchar](10) NULL,
	[ĐthTrangthai] [nchar](10) NULL,
 CONSTRAINT [PK_dthKhoa] PRIMARY KEY CLUSTERED 
(
	[ĐthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dthSV]    Script Date: 6/17/2024 9:14:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dthSV](
	[ĐthMaSV] [nvarchar](50) NOT NULL,
	[ĐthHoSV] [nvarchar](50) NULL,
	[ĐthTenSV] [nvarchar](50) NULL,
	[ĐthNS] [date] NULL,
	[ĐthPhai] [bit] NULL,
	[ĐthPhone] [nchar](10) NULL,
	[ĐthEmail] [nvarchar](50) NULL,
	[ĐthID] [nchar](10) NULL,
 CONSTRAINT [PK_dthSV] PRIMARY KEY CLUSTERED 
(
	[ĐthMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[dthKhoa] ([ĐthID], [ĐthTenKh], [ĐthTrangthai]) VALUES (N'          ', NULL, NULL)
INSERT [dbo].[dthKhoa] ([ĐthID], [ĐthTenKh], [ĐthTrangthai]) VALUES (N'K22CNT1   ', N'K22CNT11  ', N'True      ')
INSERT [dbo].[dthSV] ([ĐthMaSV], [ĐthHoSV], [ĐthTenSV], [ĐthNS], [ĐthPhai], [ĐthPhone], [ĐthEmail], [ĐthID]) VALUES (N'2210900029', N'Đỗ Trọng', N'Huy', CAST(N'2004-10-20' AS Date), 1, N'0123456789', N'hel0baby@gmail.com', N'K22CNT1   ')
