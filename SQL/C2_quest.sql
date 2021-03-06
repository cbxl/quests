USE [C2-quest]
GO
/****** Object:  Table [dbo].[Grocery]    Script Date: 26/10/2020 16:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grocery](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/10/2020 16:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[calories] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grocery] ON 

INSERT [dbo].[Grocery] ([id], [price], [date]) VALUES (1, CAST(24 AS Decimal(18, 0)), CAST(N'1899-12-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Grocery] ([id], [price], [date]) VALUES (2, CAST(12 AS Decimal(18, 0)), CAST(N'1899-12-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Grocery] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [calories]) VALUES (1, N'Poisson', CAST(15 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([id], [name], [calories]) VALUES (2, N'Carottes', CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([id], [name], [calories]) VALUES (3, N'Navet', CAST(1 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
