USE [Users]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25.10.2020 11:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Role] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Login], [Email], [Password], [Role]) VALUES (4, N'Sebastian', N'seb@o2.pl', N'꼗﹧梌整ગ埲恷Ꙉ�杛齷켟狽䝼㾣ᵵ', N'Admin')
INSERT [dbo].[Users] ([UserID], [Login], [Email], [Password], [Role]) VALUES (6, N'Adam', N'adam3@gmail.com', N'锟鷶聍譍ﾬó뫿ꅷ쉮炮莏簫ಫ', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
