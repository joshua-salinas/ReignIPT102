CREATE PROCEDURE [dbo].[UpdateGarbageBin]
	@Id NVARCHAR(40) = NULL,
	@BinCode NVARCHAR(40) = NULL,
	@Location NVARCHAR(256) = NULL,
	@Capacity NUMERIC(10,2) = NULL,
	@Status NVARCHAR(10) = NULL
AS
BEGIN
		-- check if record exists before updating 
		-- if not exists, do not perform update
	UPDATE [dbo].[GarbageBin] 
	SET 
		[BinCode] = @BinCode,
		[Location] = @Location,
		[Capacity] = @Capacity,
		[Status] = @Status
	WHERE 
		[Id] = @Id;
END