CREATE TABLE [dbo].[Avis]
(
	[idAvis] INT IDENTITY NOT NULL, 
	[date] DATETIME2 NOT NULL DEFAULT GETDATE(),
	[commentaire] NVARCHAR(MAX) NULL, 
	[note] TINYINT NOT NULL, 
    [idReservation] INT NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([idAvis]), 
	CONSTRAINT [CK_Avis_date] CHECK ([date] >= GETDATE()),
	CONSTRAINT [CK_Avis_commentaire] CHECK (LEN([commentaire]) >= 3 OR [commentaire] IS NULL), 
	CONSTRAINT [CK_Avis_note] CHECK ([note] <= 5),
    CONSTRAINT [FK_Avis_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation])
)
