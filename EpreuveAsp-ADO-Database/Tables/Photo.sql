CREATE TABLE [dbo].[Table1]
(
	[IdPhoto] INT  NOT NULL IDENTITY, 
    [Photo] NVARCHAR(255) NOT NULL, 
    [IdLogement] INT NOT NULL, 
    CONSTRAINT [PK_Table1] PRIMARY KEY ([IdPhoto]), 
    CONSTRAINT [FK_PhotoLogement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
   
)
