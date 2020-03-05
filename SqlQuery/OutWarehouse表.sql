--(未最终确定，还未执行)
create table OutWarehouse(
	AutoId int primary key identity(1,1),
	Name nvarchar(50) not null,
	PinyinCode nvarchar(100),
	BarCode nvarchar(50) not null,
	ProducedDate nvarchar(10),
	SName nvarchar(50),
	CName nvarchar(50),
	TName nvarchar(50),
	WId nvarchar(10),
	InPrice float,
	OutPrice float,
	OutType nvarchar(50),
	OutTime DateTime default getDate()
)


insert into OutWarehouse
([Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[CName],[TName],[WId],[InPrice],[OutPrice],[OutType])
values
(@Name,@PinyinCode,@BarCode,@ProducedDate,@SName,@CName,@TName,@WId,@InPrice,@OutPrice,@OutType)