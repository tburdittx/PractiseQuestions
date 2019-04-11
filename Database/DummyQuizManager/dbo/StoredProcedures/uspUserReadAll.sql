-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE uspUserReadAll 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT [Id]
      ,[FirstName]
      ,[Surname]
      ,[Username]
      ,[Password]
      ,[EmailAddress]
  FROM [dbo].[User]

END
GO
