CREATE TABLE [dbo].[CategorieLogement]
(
	[IdCategorieLogement] INT PRIMARY KEY NOT NULL IDENTITY, 
    [Nom] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Logement_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)
