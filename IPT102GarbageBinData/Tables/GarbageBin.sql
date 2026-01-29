CREATE TABLE [dbo].[GarbageBin]
(
	[Id] NVARCHAR(40) NOT NULl, 
    [BinCode] NVARCHAR(40) NULL, 
    [Location] NVARCHAR(256) NULL, 
    [Capacity] NUMERIC(10, 2) NULL, 
    [Status] NVARCHAR(10) NULL, 
    
    CONSTRAINT PK_Courses_ID PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_GarbageBin_BinCode]
ON [dbo].[GarbageBin]([BinCode] ASC)
WHERE [BinCode] IS NOT NULL