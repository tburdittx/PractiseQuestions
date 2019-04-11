-- =============================================
-- Author:		Tara Burditt
-- Create date: 31/03/2019
-- Description:	Delete system admin by Id
-- =============================================
CREATE PROCEDURE uspSystemAdminDelete 
@id bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
DELETE FROM [dbo].[SystemAdmin]
      WHERE Id=@id
END
GO
