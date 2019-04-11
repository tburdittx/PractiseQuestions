-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE uspUserRead 
	@id bigint
AS
BEGIN
	SELECT [Id]
      ,[FirstName]
      ,[Surname]
      ,[Username]
      ,[Password]
      ,[EmailAddress]
  FROM [dbo].[User]
  where Id=@id
END
GO
