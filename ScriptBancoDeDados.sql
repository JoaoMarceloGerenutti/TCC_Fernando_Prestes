USE [db_salao]
GO
/****** Object:  Table [dbo].[BDEB_Clientes]    Script Date: 20/04/2020 14:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BDEB_Clientes](
	[codCli] [int] IDENTITY(1,1) NOT NULL,
	[nomeCliente] [nvarchar](50) NULL,
	[Telefone] [nvarchar](11) NULL,
 CONSTRAINT [PK_BDEB_Clientes] PRIMARY KEY CLUSTERED 
(
	[codCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BDEB_Produtos]    Script Date: 20/04/2020 14:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BDEB_Produtos](
	[codProduto] [int] IDENTITY(1,1) NOT NULL,
	[nomeProduto] [nvarchar](50) NULL,
	[Preco] [float] NULL,
	[Marca] [nvarchar](50) NULL,
	[Quantidade] [int] NULL,
	[Obs] [nvarchar](max) NULL,
 CONSTRAINT [PK_BDEB_Produtos] PRIMARY KEY CLUSTERED 
(
	[codProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BDEB_ServicoProduto]    Script Date: 20/04/2020 14:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BDEB_ServicoProduto](
	[codProduto] [int] NULL,
	[codServico] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BDEB_Servicos]    Script Date: 20/04/2020 14:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BDEB_Servicos](
	[codServico] [int] IDENTITY(1,1) NOT NULL,
	[DataS] [datetime] NULL,
	[nomeServico] [nvarchar](50) NULL,
	[Obs] [nvarchar](max) NULL,
	[precoCobrado] [float] NULL,
	[codCli] [int] NULL,
	[Horario] [time](0) NULL,
 CONSTRAINT [PK_BDEB_Servicos] PRIMARY KEY CLUSTERED 
(
	[codServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/04/2020 14:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[loginUser] [varchar](50) NOT NULL,
	[senha] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BDEB_ServicoProduto]  WITH CHECK ADD  CONSTRAINT [FK_BDEB_ServicoProduto_BDEB_Produtos] FOREIGN KEY([codProduto])
REFERENCES [dbo].[BDEB_Produtos] ([codProduto])
GO
ALTER TABLE [dbo].[BDEB_ServicoProduto] CHECK CONSTRAINT [FK_BDEB_ServicoProduto_BDEB_Produtos]
GO
ALTER TABLE [dbo].[BDEB_ServicoProduto]  WITH CHECK ADD  CONSTRAINT [FK_BDEB_ServicoProduto_BDEB_Servicos] FOREIGN KEY([codServico])
REFERENCES [dbo].[BDEB_Servicos] ([codServico])
GO
ALTER TABLE [dbo].[BDEB_ServicoProduto] CHECK CONSTRAINT [FK_BDEB_ServicoProduto_BDEB_Servicos]
GO
ALTER TABLE [dbo].[BDEB_Servicos]  WITH CHECK ADD  CONSTRAINT [FK_BDEB_Servicos_BDEB_Clientes] FOREIGN KEY([codCli])
REFERENCES [dbo].[BDEB_Clientes] ([codCli])
GO
ALTER TABLE [dbo].[BDEB_Servicos] CHECK CONSTRAINT [FK_BDEB_Servicos_BDEB_Clientes]
GO
