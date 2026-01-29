CREATE PROCEDURE [dbo].[GetGarbageBin]
    @Code NVARCHAR(40) = NULL
AS
BEGIN
    SELECT 
        a.[Id]       AS GarbageBinId,
        a.[BinCode]  AS GarbageBinCode,
        a.[Location] AS GarbageBinLocation,
        a.[Capacity] AS GarbageBinCapacity,
        a.[Status]   AS GarbageBinStatus
    FROM [dbo].[GarbageBin] a
    WHERE a.[BinCode] = @Code;
END
GO
