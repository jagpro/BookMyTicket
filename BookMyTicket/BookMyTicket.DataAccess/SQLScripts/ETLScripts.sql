--create database BookMyTicket
--go


insert into dbo.Theatre (Name, [Location], MetaData)
select 'PVR','Chennai','Phone: 044-43487348'
union all select 'PVR','Mumbai','Phone: 022-8347384738'
union all select 'PVR','Delhi','Phone: 011-3748374383'
go

select * from dbo.Theatre
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
select * from Movie
go


insert into Show (TheatreID, MovieID, ScreenDateFrom, ScreenDateTo, ShowTime, AvailableSeats, MetaData)
select 1, 1, '1/1/2017','10/10/2017','10:00 am', 250, 'Some useful info'
union all select 1, 2, '1/1/2017','4/4/2017','10:00 am', 250, 'Some useful info'
union all select 1, 3, '1/1/2017','4/4/2017','10:00 am', 250, 'Some useful info'
union all select 2, 1, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
union all select 2, 2, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
union all select 2, 3, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
union all select 3, 1, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
union all select 3, 2, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
union all select 3, 3, '1/1/2017','4/4/2017','01:00 pm', 250, 'Some useful info'
go

select * from Theatre
go
select * from Movie
go
select * from Show
go


select s.ShowTime, m.Name, t.Name, t.Location from Show s with(nolock)
left join Movie m with(nolock) on m.ID = s.MovieID
left join Threatre t with(nolock) on t.ID = s.TheatreID

