CREATE TABLE [dbo].[Logement]
(
	[IdLogement] INT  NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [DateCreation] DATETIME2 NOT NULL DEFAULT GETDATE(),
    [DescriptionCourte] NVARCHAR(300) NOT NULL, 
    [DescriptionLongue] NVARCHAR(MAX) NULL, 
    [Chambrenb] INT NOT NULL, 
    [Salledebainnb] INT NOT NULL, 
    [WCnb] INT NOT NULL, 
    [Piecenb] INT NOT NULL, 
    [MaxPersonne] INT NOT NULL, 
    [Balcon] BIT NOT NULL, 
    [Wifi] BIT NOT NULL, 
    [MiniBar]BIT NOT NULL, 
    [AnimauxAdmis] BIT NOT NULL, 
    [Piscine]BIT NOT NULL, 
    [Voiturier] BIT NOT NULL, 
    [RoomService] BIT NOT NULL, 
    [Prix] MONEY NOT NULL, 

    [IdProprietaire] INT NOT NULL,
    [IdCategorie] INT NOT NULL, 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([IdLogement]), 
    CONSTRAINT [FK_Logement_Proprietaire] FOREIGN KEY ([IdProprietaire]) REFERENCES [Proprietaire]([IdProprietaire]), 
    CONSTRAINT [FK_Logement_Categorie] FOREIGN KEY (IdCategorie) REFERENCES [CategorieLogement]([IdCategorie]),
    
  )
