CREATE TABLE [dbo].[Indisponibilites]
(
	[IdIndispos] INT  NOT NULL IDENTITY, 
    [Debut] DATE NOT NULL, 
    [Fin] DATE NOT NULL, 
    CONSTRAINT [PK_Indisponibilites] PRIMARY KEY ([IdIndispos]), 
    [IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_Indispos_Indisponibilites] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    
    
   
   
)
