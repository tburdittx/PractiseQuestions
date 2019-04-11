-- =============================================
-- Author:		Tara Burditt
-- Create date: 31/03/2019
-- Description:	Reads All System Admin
-- =============================================
CREATE PROCEDURE uspSystemAdminReadAll

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 SELECT [Id]
      ,[UserId]
      ,[StartDate]
      ,[EndDate]
  FROM [dbo].[SystemAdmin]
END
GO
