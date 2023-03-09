CREATE VIEW [dbo].[V_Logements_Disponibles]
	AS /*SELECT dateDebutSejour AS 'Date de fin',						
				dateFinSejour AS 'Date de debut',
			  dateDebutDispo AS 'Date de debut',
			  dateFinDispo AS 'Date de fin'
	FROM [Reservation]
	JOIN [Disponibilite] ON [Reservation].[idLogement] = [Disponibilite].[idLogement]*/

	SELECT R2.dateFinSejour AS 'START', R1.dateDebutSejour AS 'FIN'
		FROM Reservation AS R1 
			JOIN Reservation AS R2 on R1.idLogement = R2.idLogement AND R2.dateFinSejour < R1.dateDebutSejour 
		

