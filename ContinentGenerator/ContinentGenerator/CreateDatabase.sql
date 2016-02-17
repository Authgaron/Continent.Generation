if object_id('dbo.HeightMap', 'U') is not null
	drop table dbo.HeightMap;
if object_id('dbo.WorldNames', 'U') is not null
	drop table dbo.WorldNames;

create table dbo.WorldNames(
	Seed int not null,
	Name varchar(35),
	primary key(Seed)
);

create table HeightMap(
	Seed int not null,
	X int not null,
	Y int not null,
	Scale smallint not null,
	Height float not null,
	primary key(Seed, Scale, X, Y),
	foreign key(Seed) references WorldNames(Seed)
);
