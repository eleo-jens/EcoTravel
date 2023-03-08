CREATE TABLE [dbo].[Client]
(
	[idClient] INT IDENTITY NOT NULL,
	[nom] NVARCHAR(50) NOT NULL, 
	[prenom] NVARCHAR(50) NOT NULL, 
	[pays] CHAR(2) NOT NULL, 
	[email] NVARCHAR(255) NOT NULL,
	[telephone] VARCHAR(20) NOT NULL,
	[pass] VARBINARY(32) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY ([idClient]),
	CONSTRAINT [UK_Client_email] UNIQUE ([email]),
	CONSTRAINT [UK_Client_telephone] UNIQUE ([telephone]),
	CONSTRAINT [CK_Client_nom] CHECK (LEN(nom)>=1), 
    CONSTRAINT [CK_Client_prenom] CHECK (LEN(prenom)>=1)
	
)
