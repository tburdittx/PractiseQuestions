
CREATE TABLE [dbo].[User](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](526) NOT NULL,
	[Surname] [nvarchar](526) NOT NULL,
	[Username] [nvarchar](526) NOT NULL,
	[Password] [nvarchar](526) NOT NULL,
	[EmailAddress] [nvarchar](526) NOT NULL
) ON [PRIMARY]
GO
