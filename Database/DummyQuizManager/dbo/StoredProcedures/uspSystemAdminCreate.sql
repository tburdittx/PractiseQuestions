-- =============================================
-- Author:		Tara Burditt
-- Create date: 31/03/2019
-- Description:	Creates system Admin
-- =============================================
CREATE PROCEDURE uspSystemAdminCreate 
	@userId bigint,
	@startDate DateTime2(7),
	@endDate DateTime2(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [dbo].[SystemAdmin]
           ([UserId]
           ,[StartDate]
           ,[EndDate])
     VALUES
           (@userId
          ,@startDate,
		  @endDate)
END
GO
