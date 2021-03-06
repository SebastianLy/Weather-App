USE [Weathers]
GO
/****** Object:  Table [dbo].[Weathers]    Script Date: 25.10.2020 11:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weathers](
	[WeatherID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[General] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Temperature] [float] NOT NULL,
	[Temperaturemax] [float] NOT NULL,
	[Temperaturemin] [float] NOT NULL,
	[Pressure] [float] NOT NULL,
	[Humidity] [float] NOT NULL,
	[WindSpeed] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Weathers] PRIMARY KEY CLUSTERED 
(
	[WeatherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Weathers] ON 

INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (1, CAST(N'2020-10-24T06:58:18.577' AS DateTime), N'Drizzle', N'light intensity drizzle', 13.04, 13.89, 12.22, 1010, 100, 4.6)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (2, CAST(N'2020-10-24T11:28:05.820' AS DateTime), N'Clouds', N'scattered clouds', 15.55, 16.67, 14.44, 1013, 72, 4.1)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (3, CAST(N'2020-10-24T11:30:53.737' AS DateTime), N'Clouds', N'scattered clouds', 15.55, 16.67, 14.44, 1013, 72, 4.1)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (4, CAST(N'2020-10-24T11:31:29.913' AS DateTime), N'Clouds', N'scattered clouds', 15.55, 16.67, 14.44, 1013, 72, 4.1)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (5, CAST(N'2020-10-24T12:28:56.733' AS DateTime), N'Clouds', N'scattered clouds', 15.7, 17.22, 14.44, 1013, 77, 5.1)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (6, CAST(N'2020-10-24T16:29:01.597' AS DateTime), N'Clear', N'clear sky', 13.06, 14.44, 12, 1014, 87, 1.5)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (7, CAST(N'2020-10-25T07:11:18.740' AS DateTime), N'Fog', N'fog', 8.92, 10.56, 6, 1016, 100, 2.6)
INSERT [dbo].[Weathers] ([WeatherID], [Date], [General], [Description], [Temperature], [Temperaturemax], [Temperaturemin], [Pressure], [Humidity], [WindSpeed]) VALUES (8, CAST(N'2020-10-25T09:44:31.593' AS DateTime), N'Fog', N'fog', 12.47, 13.89, 9, 1016, 100, 4.1)
SET IDENTITY_INSERT [dbo].[Weathers] OFF
GO
