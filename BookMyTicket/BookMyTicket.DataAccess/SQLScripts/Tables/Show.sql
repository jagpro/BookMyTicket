use BookMyTicket
go

--drop table Show
create table Show
(
	ID int identity(1,1) not null constraint PK_Show_ID primary key(ID),	
	TheatreID int not null constraint FK_Show_TheatreID references dbo.Theatre(ID),
	MovieID int not null constraint FK_Show_MovieID references dbo.Movie(ID),
	ScreenDateFrom datetime null,
	ScreenDateTo datetime null,
	ShowTime varchar(10),
	AvailableSeats int not null,
	MetaData varchar(2000) null,
	CreatedBy int not null constraint DF_Show_CreatedBy default(1),
	CreatedDate datetime not null constraint DF_Show_CreatedDate default(getdate()),
	ModifiedBy int not null constraint DF_Show_ModifiedBy default(1),
	ModifiedDate datetime not null constraint DF_Show_ModifiedDate default(getdate()),
	Active bit not null constraint DF_Show_Active default(1),
	Deleted bit not null constraint DF_Show_Deleted default(0)
)
go
