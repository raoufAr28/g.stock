USE [GESTION_DE_STOCK]
GO
/****** Object:  Table [dbo].[table_categorie]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_categorie](
	[ID_Categorie] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Categorie] [nchar](255) NOT NULL,
 CONSTRAINT [PK_table_categorie] PRIMARY KEY CLUSTERED 
(
	[ID_Categorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_client]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Client] [nchar](255) NOT NULL,
	[Prenom_Client] [nchar](255) NOT NULL,
	[Telephone_Client] [nchar](255) NOT NULL,
	[Adress_Client] [nchar](255) NOT NULL,
	[Email_Client] [nchar](255) NOT NULL,
	[Ville_Client] [nchar](255) NOT NULL,
 CONSTRAINT [PK_table_client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_commande]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_commande](
	[ID_Commande] [int] IDENTITY(1,1) NOT NULL,
	[Date_Commande] [datetime] NOT NULL,
	[ID_Client] [int] NOT NULL,
 CONSTRAINT [PK_table_commande] PRIMARY KEY CLUSTERED 
(
	[ID_Commande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_detailsCommande]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_detailsCommande](
	[ID_Commande] [int] NOT NULL,
	[ID_Produit] [int] NOT NULL,
	[Quantite] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_employee]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_employee](
	[Nom_employee] [nchar](255) NOT NULL,
	[mot_de_passe] [nchar](255) NOT NULL,
 CONSTRAINT [PK_table_employee] PRIMARY KEY CLUSTERED 
(
	[Nom_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_produit]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_produit](
	[ID_Produit] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Produit] [nchar](255) NOT NULL,
	[Quantite_Produit] [int] NOT NULL,
	[Prix_Produit] [nchar](255) NOT NULL,
	[Image_Produit] [image] NOT NULL,
	[ID_Categorie] [int] NOT NULL,
 CONSTRAINT [PK_table_produit] PRIMARY KEY CLUSTERED 
(
	[ID_Produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_utilisateur]    Script Date: 24/04/2025 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_utilisateur](
	[Nom_utilisateur] [nchar](255) NOT NULL,
	[mot_de_passe] [nchar](255) NOT NULL,
 CONSTRAINT [PK_table_utilisateur] PRIMARY KEY CLUSTERED 
(
	[Nom_utilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[table_commande]  WITH CHECK ADD  CONSTRAINT [FK_table_commande_table_client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[table_client] ([ID_Client])
GO
ALTER TABLE [dbo].[table_commande] CHECK CONSTRAINT [FK_table_commande_table_client]
GO
ALTER TABLE [dbo].[table_detailsCommande]  WITH CHECK ADD  CONSTRAINT [FK_table_detailsCommande_table_commande] FOREIGN KEY([ID_Commande])
REFERENCES [dbo].[table_commande] ([ID_Commande])
GO
ALTER TABLE [dbo].[table_detailsCommande] CHECK CONSTRAINT [FK_table_detailsCommande_table_commande]
GO
ALTER TABLE [dbo].[table_detailsCommande]  WITH CHECK ADD  CONSTRAINT [FK_table_detailsCommande_table_produit] FOREIGN KEY([ID_Produit])
REFERENCES [dbo].[table_produit] ([ID_Produit])
GO
ALTER TABLE [dbo].[table_detailsCommande] CHECK CONSTRAINT [FK_table_detailsCommande_table_produit]
GO
ALTER TABLE [dbo].[table_produit]  WITH CHECK ADD  CONSTRAINT [FK_table_produit_table_categorie] FOREIGN KEY([ID_Categorie])
REFERENCES [dbo].[table_categorie] ([ID_Categorie])
GO
ALTER TABLE [dbo].[table_produit] CHECK CONSTRAINT [FK_table_produit_table_categorie]
GO
