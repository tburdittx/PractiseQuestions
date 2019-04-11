-- =============================================
-- Author:		Tara Burditt
-- Create date: 31/03/2019
-- Description:	Reads All System Admin by Id
-- =============================================
CREATE PROCEDURE uspSystemAdminReadById
	@id bigint
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
  where Id=@id
END
GO
