CREATE TABLE [dbo].[Notes]
(
	[IdNotes] INT  NOT NULL IDENTITY, 
    [Propre] INT NULL, 
    [Equipement] INT NULL, 
    [Accueil] INT NULL, 
    [IdClient] INT NOT NULL,
    [IdLogement] INT NOT NULL, 

    CONSTRAINT [PK_Notes] PRIMARY KEY ([IdNotes]),
    
    CONSTRAINT [CK_Notes_Propre] CHECK ([Propre] BETWEEN 1 AND 5), 
    CONSTRAINT [CK_Notes_Equipement] CHECK ([Equipement] BETWEEN 1 AND 5), 
    CONSTRAINT [CK_Notes_Accueil] CHECK ([Accueil] BETWEEN 1 AND 5), 
    CONSTRAINT [FK_Client_Notes] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [FK_Logement_Notes] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
)
