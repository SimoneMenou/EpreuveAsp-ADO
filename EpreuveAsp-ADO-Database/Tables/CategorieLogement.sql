CREATE TABLE [dbo].[CategorieLogement]
(
	[IdCategorie] INT NOT NULL IDENTITY, 
    [Type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_CategorieLogement] PRIMARY KEY ([IdCategorie])
)

GO

CREATE INDEX [UK_CategorieLogement_Type] ON [dbo].[CategorieLogement] ([Type])
