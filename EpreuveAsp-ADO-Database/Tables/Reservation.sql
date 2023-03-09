CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT  NOT NULL IDENTITY, 
    [Checkin] DATETIME2 NOT NULL, 
    [checkout] DATETIME2 NOT NULL, 
    [NbAdulte] INT NOT NULL, 
    [NbEnfants] INT NULL, 
    [Annulation] BIT NOT NULL DEFAULT 0, 
    [AnnulationDate] DATETIME NULL, 
    [IdClient] INT NOT NULL,
    [IdLogement] INT NOT NULL, 

    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]), 
    CONSTRAINT [CK_Reservation_Checkin] CHECK ([Checkin] < [checkout] ), 
    CONSTRAINT [CK_Reservation_Check_Date] CHECK ([Checkin]>= GETDATE () AND [checkout]>GETDATE ()), 
    CONSTRAINT [FK_Client_Reservation] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [FK_Logement_Reservation]  FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    CONSTRAINT [CK_NbAdulteMin_NbAdulte] CHECK ([NbAdulte] >= 1), 
    
    
   
)
