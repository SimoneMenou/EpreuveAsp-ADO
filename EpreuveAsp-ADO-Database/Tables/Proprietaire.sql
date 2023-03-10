CREATE TABLE [dbo].[Proprietaire]
(
	[IdProprietaire] INT NOT NULL ,
    
    CONSTRAINT [PK_Proprietaire] PRIMARY KEY ([IdProprietaire]), 
    CONSTRAINT [FK_Proprietaire_Client] FOREIGN KEY ([IdProprietaire]) REFERENCES [Client]([IdClient]), 
    
   
)
