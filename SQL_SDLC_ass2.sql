create database tunesource
go
use tunesource;
go
create table [cd]
(	cd_id varchar(5) not null primary key,
	cd_title nvarchar(100) not null,
	cd_price int default(0) not null,
	cd_details nvarchar(200) null,
	cd_image varchar(20) not null,
	cd_established int default(2019) not null,
	[type_id] int not null)
go
create table [customer]
(	[customer_id] varchar(5) not null primary key,
	[customer_name] nvarchar(100) not null,
	[customer_username] int default(0) not null,
	[customer_password] nvarchar(200) null,
	[customer_email] varchar(20) not null)
go
create table [admin]
(	[admin_id] varchar(5) not null primary key,
	[admin_name] nvarchar(100) not null,
	[admin_username] int default(0) not null,
	[admin_password] nvarchar(200) null,
	[customer_email] varchar(20) not null,
	[customer_id] varchar(5) foreign key references [customer]([customer_id]),
	[purchase_id] varchar(5) not null,
	cd_id varchar(5) foreign key references [cd](cd_id),
	song_id varchar(10) foreign key references [songs](song_id))
go
create table [songs]
(	song_id varchar(10) not null primary key,
	song_name nvarchar(50) not null, 
	song_authors nvarchar(50) null,
	song_lyrics nvarchar(300) null,
	song_time int null)
go
create table giftcard
(	giftcard_number varchar(10) not null primary key,
	[customer_id] varchar(5) foreign key references [customer](	[customer_id]),
	[song_id] varchar(10) foreign key references [songs]([song_id]),
	[admin_id] varchar(5) foreign key references [admin]([admin_id]),
	[customer_name] nvarchar(100) not null,
)
go
create table [purchase] 
(	[purchase_id] varchar(5) not null primary key,
	[customer_id] varchar(5) foreign key references [customer]([customer_id]),
	giftcard_number varchar(10) foreign key references giftcard(giftcard_number),
)
create table account 
(	[account_id] varchar(5) not null primary key,
	[customer_id] varchar(5) foreign key references [customer]([customer_id]),
	[purchase_id] varchar(5) foreign key references [purchase]([purchase_id]),	[customer_username] int default(0) not null,

)
create table [typeofmusic]
(
	[type_id] int identity(1,1) primary key,
	[type_name] nvarchar(50) not null,
	[type_ descriptions] nvarchar(300) not null
)
go
create table [songsandcd]
(	song_id varchar(10) not null,
	cd_id varchar(5) not null)

--create realationship between MUsic and CD
alter table [cd]
add constraint fk_typeid foreign key ([type_id]) references [typeofmusic]([type_id])
go

alter table [songsandcd]
add constraint fk_cdid foreign key (cd_id) references [cd](cd_id)
go

alter table [songsandcd]
add constraint fk_songid foreign key (song_id) references [songs](song_id)
go

alter table [songsandcd]add constraint pk_songcd primary key(song_id, cd_id)

insert into [typeofmusic]([type_name],[type_ descriptions])values
('pop', 'dhfvie'),
('blue', 'kwdbk'),
('jazz', 'dhfvdie'),
('Anime', 'kdwdbk'),
('Classical', 'dfvie'),
('Comedy', 'kwdebk'),
('Country', 'drhfvie'),
('Dance', 'wdbk'),
('Rock Music', 'kwdeqbk'),
('Dubstep', 'drhvie'),
('Techno', 'wbk'),
('Electro', 'drohvie'),
('Indie Rock', 'wbk'),
( 'Disney', 'drhvvie'),
( 'Easy Listening', 'wabk'),
( 'Fitness & Workout', 'rohvie'),
( 'Hip-Hop/Rap', 'wqbk'),
('Holiday', 'drvie'),
('Industrial', 'wbsk'),
('Inspirational – Christian & Gospel', 'drie')
go
select*from [cd]
insert into [cd] values('CD001', 'Aquemini', 30, '', 'cd001.jpg', 1971, 9),
('CD002', 'Give It Up', 20, '', 'cd002.jpg', 1972, 9),
('CD003', 'Taylor Swift: Red ', 13, '', 'cd003.jpg', 2012, 1),
('CD004', 'Born This Way', 19, '', 'cd004.jpg', 2011, 1),
('CD005', 'The Best of Anime', 13, '', 'cd005.jpg', 1998, 4),
('CD006', 'Shirō Sagisu BLEACH 5th Anniversary BOX', 15, '', 'cd006.jpg', 2009, 4),
('CD007', 'A Winter Symphony ', 10, '', 'cd007.jpg', 2008, 5),
('CD008', 'A Charlie Brown Christmas', 9, '', 'cd008.jpg', 1965, 3),	
('CD009', 'Top Workout CD', 13, '', 'cd009.jpg', 2018, 16),
('CD010','Healing Rhythms CD', 18, '', 'cd010.jpg', 2018, 20)
go

alter table [songsandcd]
add note nvarchar(50) null
go


