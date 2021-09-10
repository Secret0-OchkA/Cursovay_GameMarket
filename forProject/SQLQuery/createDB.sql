use [gameMarket]
--=================================1 branch=================================
create table [roles] --roles -> users -> user-game -> games
(
[id] int primary key identity(0,1),
[role] varchar(10) default 'user' not null
);

go
use [gameMarket]
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
use [gameMarket]
create table [placemarks]-- placemarks -> game-placemark -> games
(
[id] int primary key identity(0,1),
[placemarker] nvarchar (40) not null
);


--=================================3 branch=================================
go
use [gameMarket]
create table [gameStudios] -- gameStudios -> games
(
[id] int primary key identity(0,1),
[studioName] nvarchar(40) not null
);
--=================================4 branch=================================
go
use [gameMarket]
create table [servers] -- servers -> games
(
[id] int primary key identity(0,1),
[location] nvarchar(100) not null,
[satus] binary not null,
[information] nvarchar(200) not null
);
--=================================-games-=================================
go
use [gameMarket]
create table [games] -- game -> servers, user-game, game-placemark, gameStudio
(
[id] int primary key identity(0,1),
[gameStudioId] int not null,
[name] nvarchar(40) not null,
[serverId] int null,
constraint [games_gameStudioId_FK] foreign key ([gameStudioId]) references [gameStudios]([id]),
constraint [games_sererId_FK] foreign key ([serverId]) references [servers]([id])
on delete cascade
);

go
use [gameMarket]
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
use [gameMarket]
create table [game-placemark]-- game-placemark -> games
(
[id] int primary key identity(0,1),
[gameId] int not null,
[placemarkId] int not null,
constraint [game-placemark_gameId_FK] foreign key ([gameId]) references [games]([id])
on delete cascade,
constraint [game-placemark_placemarkId_FK] foreign key ([placemarkId]) references [placemarks]([id])
on delete cascade
);