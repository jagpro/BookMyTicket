use BookMyTicket
go

create table dbo.Theatre
(
	ID int identity(1,1) not null constraint PK_Theatre_ID primary key(ID),
	Name varchar(50) not null,
	[Location] varchar(50) not null,
	MetaData varchar(2000) null,
	CreatedBy int not null constraint DF_Theatre_CreatedBy default(1),
	CreatedDate datetime not null constraint DF_Theatre_CreatedDate default(getdate()),
	ModifiedBy int not null constraint DF_Theatre_ModifiedBy default(1),
	ModifiedDate datetime not null constraint DF_Theatre_ModifiedDate default(getdate()),
	Active bit not null constraint DF_Theatre_Active default(1),
	Deleted bit not null constraint DF_Theatre_Deleted default(0)	
)
go