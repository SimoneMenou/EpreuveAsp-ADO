CREATE TABLE [dbo].[Indisponibilites]
(
	[Id] INT PRIMARY KEY NOT NULL IDENTITY, 
    [Debut] DATE NULL, 
    [Fin] DATE NULL, 
    CONSTRAINT [FK_Logement_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)
