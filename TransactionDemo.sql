/****** Object:  Table [dbo].[TransactionDemo]    Script Date: 4/22/2005 11:06:45 AM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TransactionDemo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TransactionDemo]
GO

/****** Object:  Table [dbo].[TransactionDemo]    Script Date: 4/22/2005 11:06:47 AM ******/
CREATE TABLE [dbo].[TransactionDemo] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[text] [nvarchar] (50) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TransactionDemo] WITH NOCHECK ADD 
	CONSTRAINT [PK_TransactionDemo] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

