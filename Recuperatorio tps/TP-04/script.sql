USE [master]
GO
/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 28/7/2022 17:44:09 ******/
CREATE USER [##MS_PolicyEventProcessingLogin##] FOR LOGIN [##MS_PolicyEventProcessingLogin##] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 28/7/2022 17:44:09 ******/
CREATE USER [##MS_AgentSigningCertificate##] FOR LOGIN [##MS_AgentSigningCertificate##]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 28/7/2022 17:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Precio] [int] NOT NULL,
	[FechaElaboracion] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Lemon pie', 300, '2022-06-21 23:24:17.460','2022-06-24 23:24:42.790',6)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Pepas', 200, '2022-06-22 00:07:20.893','2022-06-23 00:07:20.893',8)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Medialunas', 50, '2022-06-22 00:08:03.857','2022-06-25 00:08:03.857',10)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Rosca', 320, '2022-06-22 00:08:42.587','2022-06-26 00:08:42.587',3)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Chocotorta', 500, '2022-06-22 01:40:03.470','2022-06-27 01:40:03.470',10)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Pastafrola', 250, '2022-06-21 23:24:17.460','2022-06-23 23:24:17.460',6)
GO
INSERT [dbo].[Productos] ([nombre], [Precio], [FechaElaboracion], [FechaVencimiento],[Cantidad]) VALUES ('Lemon pie', 300, '2022-06-21 23:24:17.460','2022-06-24 23:24:42.790',6)
GO

