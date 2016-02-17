create table x(
	ID bigint not null identity(1,1),
	Seed int not null,
	X int not null,
	Y int not null,
	Scale smallint not null,
	Height float not null
	primary key(ID)
)