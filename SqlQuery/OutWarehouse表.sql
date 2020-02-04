--(未最终确定，还未执行)
create table TOutWarehouse(
	Id int primary key identity(1,1),
	Gid int not null,
	BarCode nvarchar(50) not null,
	GName nvarchar(50) not null,
	SId int not null,
	SName nvarchar(50) not null,
	WId int not null,
	WName nvarchar(50) not null,
	GType nvarchar(50) not null,
	InCount int not null,
	InPrice float not null,
	InDate Date default convert(varchar(100), getdate(), 20)
)