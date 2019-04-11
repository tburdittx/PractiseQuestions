-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE uspUserUpdate
(
@id bigint ,
	@firstName nvarchar(526),
	@surname nvarchar(526),
	@username nvarchar(526),
	@password nvarchar (526),
	@emailAddress nvarchar (526)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[User]
   SET [FirstName] = @firstName
      ,[Surname] = @surname
      ,[Username] = @username
      ,[Password] = @password
      ,[EmailAddress] = @emailAddress
 WHERE Id=@id
END
GO
