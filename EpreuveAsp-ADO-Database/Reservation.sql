CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT PRIMARY KEY NOT NULL IDENTITY, 
    [Check-in] DATE NULL, 
    [check-out] DATE NULL, 
    [Nb Adulte] INT NULL, 
    [Nb Enfants] INT NULL, 
    [Annulation] BOOLEAN DEFAULT 0, 
    [AnnulationDate] DATETIME NULL, 
    CONSTRAINT [FK_Client] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn]), 
    CONSTRAINT [FK_Logement] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn]), 
   
)
