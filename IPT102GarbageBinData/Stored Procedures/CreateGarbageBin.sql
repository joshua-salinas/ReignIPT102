CREATE PROCEDURE [dbo].[CreateGarbageBin]
	 @Id NVARCHAR(40) = NULL,
     @BinCode NVARCHAR(40) = NULL,
     @Location NVARCHAR(256) = NULL,
     @Capacity NUMERIC(10,2) = NULL,
     @Status NVARCHAR(10) = NULL

AS
BEGIN
    INSERT INTO [dbo].[GarbageBin] 
    (
        [Id],
        [BinCode],
        [Location],
        [Capacity],
        [Status]
    )
    VALUES 
    (
        @Id,
        @BinCode,
        @Location,
        @Capacity,
        @Status
    );
END
	