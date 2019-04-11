-- =============================================
-- Author:		Tara Burditt
-- Create date: 31/03/2019
-- Description:	Update system admin by Id
-- =============================================
CREATE PROCEDURE uspSystemAdminUpdate 
	@id bigint,
	@userId bigint,
	@startDate DateTime2(7),
	@endDate DateTime2(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
UPDATE [dbo].[SystemAdmin]
   SET [UserId] = @userId
      ,[StartDate] = @startDate
      ,[EndDate] = @endDate
 WHERE Id=@id
END
GO
