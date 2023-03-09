CREATE VIEW [dbo].[Reservarions_Pays]
	AS SELECT [Reservation].*, [Logement].[pays] 
	FROM [Reservation]
	JOIN [Logement] ON [Reservation].[idLogement] = [Logement].[idLogement]