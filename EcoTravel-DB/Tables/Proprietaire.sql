CREATE TABLE [dbo].[Proprietaire]
(
	[idProprietaire] INT NOT NULL,
	CONSTRAINT [PK_Proprietaire] PRIMARY KEY ([idProprietaire]), 
    CONSTRAINT [FK_Proprietaire_Client] FOREIGN KEY ([idProprietaire]) REFERENCES [Client]([idClient])

)
