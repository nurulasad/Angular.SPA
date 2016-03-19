CREATE TABLE [ELearning].[dbo].[Animal] (
    [AnimalID]      INT           IDENTITY (1, 1) NOT NULL,
    [AnswerID]      INT,
    [Item]       NVARCHAR (50) NULL,
    [Name]      NVARCHAR (50) NULL,
    [Code] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AnimalID] ASC),
    
        CONSTRAINT [FK_dbo.AnimalID_dbo.AnswerID] FOREIGN KEY ([AnswerID]) 
        REFERENCES [ELearning].[dbo].[Answer] ([AnswerID]) ON DELETE CASCADE
)

    
INSERT INTO [ELearning].[dbo].[Animal]([Item],[Name],[Code],[AnswerID] ) VALUES ('lion.gif','Lion','LION',1)

INSERT INTO [ELearning].[dbo].[Animal]([Item],[Name],[Code],[AnswerID]) VALUES ('horse.gif','Horse','Horse',2) 
GO



