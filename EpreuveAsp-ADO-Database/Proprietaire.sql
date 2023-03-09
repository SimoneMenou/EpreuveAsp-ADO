CREATE TABLE [dbo].[Proprietaire]
(
	[Id] INT PRIMARY KEY NOT NULL IDENTITY, 
    CONSTRAINT [FK_Proprietaire_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn]) , 
   
)
