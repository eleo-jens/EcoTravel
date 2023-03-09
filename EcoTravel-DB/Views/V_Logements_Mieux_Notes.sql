CREATE VIEW [dbo].[Logements_Mieux_Notes]
	AS 
	SELECT DISTINCT [L].* FROM [Logement] AS L
	JOIN [Reservation] ON [L].[idLogement] = [Reservation].[idLogement] 
	JOIN [Avis] ON [Avis].[idReservation] = [Reservation].[idReservation] 
	WHERE 
			(SELECT AVG([Avis].[note]) 
			FROM [Avis] JOIN [Reservation] 
			ON [Avis].idReservation = [Reservation].idReservation 
			WHERE Reservation.idLogement = L.idLogement) 
		>= 
			(SELECT ROUND(AVG([Avis].[note]),2) FROM [Avis])
