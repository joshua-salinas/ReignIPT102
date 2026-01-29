CREATE PROCEDURE [dbo].[DeleteGarbageBin]
	@Id NVARCHAR(40) = NULL

AS
BEGIN
	DELETE FROM [dbo].[GarbageBin] 
	WHERE 
		[Id] = @Id;
END
	