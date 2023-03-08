CREATE PROCEDURE [dbo].[SP_Logements_Mois]

AS
	SELECT * FROM [Logement]
	WHERE [dateAjout] BETWEEN GETDATE() AND (GETDATE() - GETDATE()

