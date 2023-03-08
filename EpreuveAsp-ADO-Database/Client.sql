CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(50) NULL, 
    [Prenom] NVARCHAR(50) NULL, 
    [AdresseMail] NCHAR(255) NULL,
    [MotDePasse] NVARCHAR(MAX) NULL, 
    [Pays] NVARCHAR(50) NULL, 
    [Telephone] NCHAR(10) NULL, 
   
    
)
