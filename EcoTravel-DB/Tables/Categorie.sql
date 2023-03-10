CREATE TABLE [dbo].[Categorie]
(
	[idCategorie] INT IDENTITY NOT NULL,
	[nom] NVARCHAR(50) NOT NULL UNIQUE, 
    CONSTRAINT [PK_Categorie] PRIMARY KEY ([idCategorie])
)
