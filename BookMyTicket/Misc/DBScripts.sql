--create database BookMyTicket
--go

use BookMyTicket
go

--drop table Theatre
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
insert into dbo.Theatre (Name, [Location], MetaData)
select 'PVR','Chennai','Phone: 044-43487348'
union all select 'PVR','Mumbai','Phone: 022-8347384738'
union all select 'PVR','Delhi','Phone: 011-3748374383'
go

select * from dbo.Theatre
go


create table Movie
(
	ID int identity(1,1) not null primary key,
	Name varchar(50) not null,
	MetaData varchar(2000) null,
	CreatedBy int not null default(1),
	CreatedDate datetime not null default(getdate()),
	ModifiedBy int not null default(1),
	ModifiedDate datetime not null default(getdate()),
	Active bit not null default(1),
	Deleted bit not null default(0),
)
go

create table Show
(
	TheatreID int not null references dbo.Threatre(ID),
	MovieID int not null references dbo.Movie(ID),
	ScreenDateFrom datetime null,
	ScreenDateTo datetime null,
	ShowTime varchar(10),
	MetaData varchar(2000) null,
	Active bit not null default(1),
	Deleted bit not null default(0),
	CreatedBy int not null default(1),
	CreatedDate datetime not null default(getdate()),
	ModifiedBy int not null default(1),
	ModifiedDate datetime not null default(getdate())	
)
go

--drop table show
--drop table Threatre
--drop table Movie


insert into Movie (Name, MetaData)
select 'Basha', 'Raijini, Nakma, IMBD 5/5'
union all select 'Dashavatharam','Kamalhasan, IMDB 5/5'
union all select 'Iron Man','Someone, IMDB 4.9/5'
union all select 'Movie3','Actors, IMDB rating'
union all select 'Movie4','Actors, IMDB rating'
union all select'Movie5','Actors, IMDB rating'
go


insert into Show (TheatreID, MovieID, ScreenDateFrom, ScreenDateTo, ShowTime, MetaData)
select 1, 1, '1/1/2017','10/10/2017','10:00 am', 'Some useful info'
union all select 1, 2, '1/1/2017','4/4/2017','10:00 am', 'Some useful info'
union all select 1, 3, '1/1/2017','4/4/2017','10:00 am', 'Some useful info'
union all select 2, 1, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
union all select 2, 2, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
union all select 2, 3, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
union all select 3, 1, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
union all select 3, 2, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
union all select 3, 3, '1/1/2017','4/4/2017','01:00 pm', 'Some useful info'
go

select * from Threatre
go
select * from Movie
go
select * from Show
go


select s.ShowTime, m.Name, t.Name, t.Location from Show s with(nolock)
left join Movie m with(nolock) on m.ID = s.MovieID
left join Threatre t with(nolock) on t.ID = s.TheatreID

