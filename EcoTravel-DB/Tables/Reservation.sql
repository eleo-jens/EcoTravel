CREATE TABLE [dbo].[Reservation]
(
	[idReservation] INT IDENTITY NOT NULL,
	[dateDebutSejour] DATE NOT NULL, 
    [dateFinSejour] DATE NOT NULL, 
    [assurance] BIT NOT NULL, 
    [dateReservation] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [dateAnnulation] DATETIME2 NULL, 
    [nbAdulte] TINYINT NOT NULL,
    [nbEnfant] TINYINT NOT NULL,
    [annulationParClient] BIT NULL,
    [idClient] INT NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([idReservation]), 
    CONSTRAINT [CK_Reservation_dateDebutSejour] CHECK ([dateDebutSejour] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateFinSejour] CHECK ([dateFinSejour] > [dateDebutSejour]),
    CONSTRAINT [CK_Reservation_dateReservation] CHECK ([dateReservation] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateAnnulation] CHECK ([dateAnnulation] BETWEEN [dateReservation] AND [dateFinSejour]),
    CONSTRAINT [CK_Reservation_nbAdulte] CHECK (nbAdulte >= 1),
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]), 
    CONSTRAINT [FK_Reservation_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement])
)
