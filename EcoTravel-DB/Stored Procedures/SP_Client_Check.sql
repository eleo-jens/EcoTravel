CREATE PROCEDURE [dbo].[SP_Client_Check]
	@email NVARCHAR(255),
	@password NVARCHAR(32)
AS
	SELECT [idClient] FROM [Client]
	WHERE [email] = @email AND [password] = HASHBYTES('SHA2_256', @password)