--(未最终确定，还未执行)
create table TInWarehouse(
	Id int primary key identity(1,1),
	Gid int not null,
	BarCode nvarchar(50) not null,
	GName nvarchar(50) not null,
	CId int not null,
	CName nvarchar(50) not null,
	WId int not null,
	WName nvarchar(50) not null,
	GType nvarchar(50) not null,
	OutCount int not null,
	OutPrice float not null,
	OutDate Date default convert(varchar(100), getdate(), 20)
)