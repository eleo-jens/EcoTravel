CREATE TABLE [dbo].[Photo]
(
	[idPhoto] INT IDENTITY NOT NULL, 
	[nomPhoto] NVARCHAR(50) NULL, 
    [urlPhoto] NVARCHAR(255) NOT NULL UNIQUE, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([idPhoto]), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement])
)
