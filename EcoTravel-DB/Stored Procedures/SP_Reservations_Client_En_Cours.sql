CREATE PROCEDURE [dbo].[SP_Reservations_Client_En_Cours]
	@id int
AS
	SELECT * FROM [Reservation] 
	WHERE [idClient] = @id AND GETDATE() <= [dateDebutSejour] AND [dateAnnulation] IS NULL
