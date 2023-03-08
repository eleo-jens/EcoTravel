CREATE TABLE [dbo].[Disponibilite]
(
	[idDispo] INT IDENTITY NOT NULL,
	[dateDebutDispo] DATE NOT NULL, 
    [dateFinDispo] DATE NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Disponibilite] PRIMARY KEY ([idDispo]),
    CONSTRAINT [CK_Reservation_dateDebutDispo] CHECK ([dateDebutDispo] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateFinDispo] CHECK ([dateFinDispo] > [dateDebutDispo]), 
    CONSTRAINT [FK_Disponibilite_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement])
)
