CREATE TABLE [ELearning].[dbo].[Answer] (
    [AnswerID]      INT           IDENTITY (1, 1) NOT NULL,
    [Code]      NVARCHAR (50) NULL,
    [Text] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AnswerID] ASC)
    )
    
INSERT INTO [ELearning].[dbo].[Answer] ([Code],[Text] )VALUES('LION', 'Lion')
INSERT INTO [ELearning].[dbo].[Answer] ([Code],[Text] )VALUES('HORSE', 'Horse')
GO
