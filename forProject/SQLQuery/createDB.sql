use [gameMarket2]
--=================================1 branch=================================
create table [roles] --roles -> users -> user-game -> games
(
[id] int primary key identity(0,1),
[role] varchar(10) default 'user' not null
);

go
create table [users] --users -> user-game -> games
(
[login] varchar(100) primary key not null,
[password] varchar(16) not null,
[roleId] int default 'user' not null
constraint users_role_FK foreign key ([roleId]) references [roles]([id])
on delete set default 
on update cascade
);


--=================================2 branch=================================
go
create table [placemarks]-- placemarks -> game-placemark -> games
(
[id] int primary key identity(0,1),
[placemarker] nvarchar (40) unique not null
);


--=================================3 branch=================================
go
create table [gameStudios] -- gameStudios -> games
(
[id] int primary key identity(0,1),
[studioName] nvarchar(40) unique not null
);
--=================================4 branch=================================
go
create table [servers] -- servers -> games
(
[id] int primary key identity(0,1),
[location] nvarchar(100) not null,
[satus] bit not null,
[information] nvarchar(200) not null
);

--=================================-games-=================================
go
create table [games] -- game -> servers, user-game, game-placemark, gameStudio
(
[id] int primary key identity(0,1),
[gameStudioId] int not null,
[name] nvarchar(40) unique not null,
[serverId] int not null,
[Price] float not null,
constraint [games_gameStudioId_FK] foreign key ([gameStudioId]) references [gameStudios]([id])
on delete no action
on update cascade,
constraint [games_sererId_FK] foreign key ([serverId]) references [servers]([id])
on delete set default 
);

go
create table [user-game] -- user-game -> games
(
[id] int primary key identity(0,1),
[userLogin] varchar(100) not null,
[gameId] int not null,
constraint [user-game_userLogin_FK] foreign key ([userLogin]) references [users]([login])
on delete cascade
on update cascade,
constraint [user-game_gameId_FK] foreign key ([gameId]) references [games]([id])
on delete cascade
on update cascade
);

go
create table [game-placemark]-- game-placemark -> games
(
[id] int primary key identity(0,1),
[gameId] int not null,
[placemarkId] int not null,
constraint [game-placemark_gameId_FK] foreign key ([gameId]) references [games]([id])
on delete cascade
on update cascade,
constraint [game-placemark_placemarkId_FK] foreign key ([placemarkId]) references [placemarks]([id])
on delete cascade
on update cascade
);

go

CREATE TABLE Pictures 
(
	id int primary key identity(0,1),
	gameId int unique null,
    pictureName NVARCHAR(40) not null,
    picFileName NVARCHAR(100) unique not null,
    PictureData VARBINARY(max) not null,
	constraint [gameId_Pictures_FK] foreign key ([gameId]) references [games]([id])
	on delete cascade
	on update cascade
)

go

create PROCEDURE [dbo].[usp_ImportImage] 
(
   @gameOwnerId int,
   @PicName NVARCHAR (100),
   @ImageFolderPath NVARCHAR (1000),
   @Filename NVARCHAR (1000)
)
AS
BEGIN
   DECLARE @Path2OutFile NVARCHAR (2000);
   DECLARE @tsql NVARCHAR (2000);
   SET NOCOUNT ON
   SET @Path2OutFile = CONCAT (
         @ImageFolderPath
         ,'\'
         , @Filename
         );
   SET @tsql = 'insert into Pictures  (pictureName, picFileName, PictureData)' +
               ' SELECT ' + '''' + @PicName + '''' + ',' + '''' + @Filename + '''' + ', * ' + 
               'FROM Openrowset( Bulk ' + '''' + @Path2OutFile + '''' + ', Single_Blob) as img'
   EXEC (@tsql)
   update [Pictures] set [gameId] = @gameOwnerId where [picFileName] = @Filename
   SET NOCOUNT OFF
END