
CREATE TABLE [dbo].[SystemAdmin](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL
) ON [PRIMARY]
GO
