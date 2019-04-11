CREATE PROCEDURE uspUserCreate
	(@firstName nvarchar(526),
	@surname nvarchar(526),
	@username nvarchar(526),
	@password nvarchar (526),
	@emailAddress nvarchar (526))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO [dbo].[User]
           ([FirstName]
           ,[Surname]
           ,[Username]
           ,[Password]
           ,[EmailAddress])
     VALUES
           (@firstName,
		   @surname,
		   @username, 
		   @password,
		   @emailAddress)
END
GO
