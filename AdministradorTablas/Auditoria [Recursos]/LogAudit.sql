if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LogAudit]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LogAudit]
GO

CREATE TABLE [dbo].[LogAudit] (
	[cid] [int] IDENTITY (1, 1) NOT NULL ,
	[TableName] [varchar] (128) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[TableAction] [char] (1) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[ActionQuery] [nvarchar] (512) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[ModifiedDate] [datetime] NOT NULL ,
	[ModifiedBy] [varchar] (20) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[TerminalName] [varchar] (20) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[OldValues] [nvarchar] (1500) COLLATE Modern_Spanish_CI_AS NULL ,
	[NewValues] [nvarchar] (1500) COLLATE Modern_Spanish_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LogAudit] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[cid]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LogAudit] ADD 
	CONSTRAINT [DF__LogAudit__Modifi__023D5A04] DEFAULT (getdate()) FOR [ModifiedDate],
	CONSTRAINT [DF__LogAudit__Modifi__03317E3D] DEFAULT (suser_sname()) FOR [ModifiedBy],
	CONSTRAINT [DF__LogAudit__Termin__0425A276] DEFAULT (host_name()) FOR [TerminalName]
GO

