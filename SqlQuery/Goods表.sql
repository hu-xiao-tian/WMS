--(未最终确定，还未执行)
create table TOutWarehouse(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	WId int not null,
	WName nvarchar(50) not null,
	BarCode nvarchar(50) not null,
	TId int not null,
	TName nvarchar(50) not null,
	SId int not null,
	SName int not null,
	ImageUrl nvarchar(4000),
	ProducedDate Date not null,
	EffectiveTime int,--玩具啥的应该是没有有效期的
	InPrice float not null,
	OutPrice float not null,
	IsInWarehouse bit not null,
	Description nvarchar(2000) default '无'
)