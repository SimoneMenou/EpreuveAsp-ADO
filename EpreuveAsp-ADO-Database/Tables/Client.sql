CREATE TABLE [dbo].[Client]
(
	[IdClient] INT  NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [AdresseMail] NVARCHAR(255) NOT NULL,
    [MotDePasse] NVARCHAR(32) NOT NULL, 
    [Pays] NVARCHAR(50) NOT NULL, 
    [Telephone] NVARCHAR(20) NOT NULL, 

    CONSTRAINT GestionEmail  CHECK(AdresseMail LIKE '%___@___%.__%'),
    CONSTRAINT [Telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([Telephone], '+', '00'), '/', ''), '.', '')) = 1), 
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient])
   

)

GO

CREATE UNIQUE INDEX [UK_Client_AdresseMail] ON [dbo].[Client] ([AdresseMail])

GO

CREATE UNIQUE INDEX [UK_Client_Telephone] ON [dbo].[Client] ([Telephone])
