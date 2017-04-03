use BookMyTicket
go

create table dbo.Movie
(
	ID int identity(1,1) not null constraint PK_Movie_ID primary key(ID),
	Name varchar(50) not null,
	MetaData varchar(2000) null,
	CreatedBy int not null constraint DF_Movie_CreatedBy default(1),
	CreatedDate datetime not null constraint DF_Movie_CreatedDate default(getdate()),
	ModifiedBy int not null constraint DF_Movie_ModifiedBy default(1),
	ModifiedDate datetime not null constraint DF_Movie_ModifiedDate default(getdate()),
	Active bit not null constraint DF_Movie_Active default(1),
	Deleted bit not null constraint DF_Movie_Deleted default(0)	
)
go
