CREATE TABLE [dbo].[Table1]
(
	[IdPhoto] INT PRIMARY KEY NOT NULL IDENTITY, 
    [Photo] NCHAR(10) NULL, 
    CONSTRAINT [FK_logement_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn]) 
)
