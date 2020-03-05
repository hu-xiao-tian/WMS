--(未最终确定，还未执行)
create table InWarehouse(
	AutoId int primary key identity(1,1),
	Name nvarchar(50) not null,
	PinyinCode nvarchar(100),
	BarCode nvarchar(50) not null,
	ProducedDate nvarchar(10),
	SName nvarchar(50),
	TName nvarchar(50),
	WId nvarchar(10),
	InPrice float,
	InType nvarchar(10),
	InCount int,
	InTime DateTime default getDate()
)

insert into InWarehouse
([Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[TName],[WId],[InPrice],[InType],[InCount])
values
(@Name,@PinyinCode,@BarCode,@ProducedDate,@SName,@TName,@WId,@InPrice,@InType,@InCount)