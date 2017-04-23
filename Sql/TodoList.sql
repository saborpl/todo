/****** Object:  Table [dbo].[TodoList]    Script Date: 2017-04-18 23:04:41 ******/
DROP TABLE [dbo].[TodoList]
GO
/****** Object:  Table [dbo].[TodoList]    Script Date: 2017-04-18 23:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Descpription] [nvarchar](255) NULL,
	[TodoDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TodoList] ON 

INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'nowe zleconko2', N'Thanks for the reply, I did try the fill, but this causes my program not to respond for about 3seconds, and then the Listbox that is populated by the dataset flickers.', CAST(N'2017-04-20 00:00:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'ghhg2', N'asddasdsadsededdedexxxx', CAST(N'2017-05-05 00:00:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'COŒ  za cxoœ', N'asdasdsadadsdasadsasdsadsda', CAST(N'2017-04-17 00:00:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'12sdsdadsads', N'asdasdasdasdsad', CAST(N'2017-12-15 22:58:21.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'ghhg2', N'asddasdsadsededdedexxxx', CAST(N'2017-05-03 00:00:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'ghhg2', N'asddasdsadsededdedexxxx', CAST(N'2017-05-05 00:00:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'df', N'sdf', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'cvcv', N'vcxvcvc', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'ewqwe', N'qweqewqwe', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'ddfdf', N'fsf', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'asdasd', N'asdads', CAST(N'2017-08-04 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'dsdfsfdsdf', N'sdfsdfsdf', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'sdfsdfsf', N'sfdsdf', CAST(N'2017-04-16 00:04:00.000' AS DateTime))
INSERT [dbo].[TodoList] ([Id], [Name], [Descpription], [TodoDate]) VALUES (N'xcvdfsdds', N'ggfgdgd', CAST(N'2017-04-16 07:20:00.000' AS DateTime))
