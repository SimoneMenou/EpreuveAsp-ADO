CREATE TABLE [dbo].[Client]
(
	[IdClient] INT PRIMARY KEY NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [AdresseMail] NVARCHAR(50) NOT NULL,
    [MotDePasse] NVARCHAR(MAX) NOT NULL, 
    [Pays] NVARCHAR(50) NOT NULL, 
    [Telephone] NCHAR(10) NOT NULL, 

)
