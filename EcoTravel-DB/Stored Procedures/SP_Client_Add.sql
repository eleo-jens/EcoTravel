CREATE PROCEDURE [dbo].[SP_Client_Add]
	@email NVARCHAR(255),
	@password NVARCHAR(32),
	@nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@pays CHAR(2),
	@telephone VARCHAR(20)
AS
	INSERT INTO [Client] ([email], [password], [nom], [prenom], [pays], [telephone])
	OUTPUT [inserted].[idClient]
	VALUES (@email, HASHBYTES('SHA_512', @password), @nom, @prenom, @pays, @telephone)