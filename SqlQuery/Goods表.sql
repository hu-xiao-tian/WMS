--(未最终确定，还未执行)
create table Goods(
	AutoId int primary key identity(1,1),--自增id用于统计
	Name nvarchar(50) not null,
	PinyinCode nvarchar(100) not null,
	BarCode nvarchar(50) not null,--条形码，同一货物的条形码相同
	ImageName nvarchar(4000),
	TId int not null,
	SId int not null,
	ProducedDate nvarchar(10) not null,
	EffectiveTime int,--玩具啥的应该是没有有效期的
	InPrice float not null,
	OutPrice float,
	WId nvarchar(10) not null,
	Description nvarchar(1000)
)

Insert into Goods( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId],[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],[WId])
Values('卫龙大面筋','WeiLongDaMianJin','12121212','卫龙大面筋.jpg',1,1,'20200303',180,3,5,'No1')
Insert into Goods( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId],[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],[WId])
Values('康师傅方便面','KangShiFuFangBianMian','13131313','康师傅方便面.jpg',1,1,'20200304',180,3,4,'No1')
Insert into Goods( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId],[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],[WId])
Values('卫龙考拉','WeiLongKaoLa','15151515','卫龙考拉.jpg',1,1,'20200304',180,300,400,'No3')

Select * from Goods
Select * from Warehouse

Select * from Goods Where datediff(day,GETDATE(),dateadd(day,[EffectiveTime],[ProducedDate]))>179
select datediff(day,GETDATE(),dateadd(day,180,'20191212'))


select Goods.[AutoId],Goods.[Name],Goods.[PinyinCode],[BarCode],[ImageName], 
[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName,
Warehouse.[Id] as WId,Warehouse.[Name] as WName
from Goods inner join GoodsType on Goods.TId = GoodsType.AutoId
inner join Supplier on Goods.SId = Supplier.AutoId
inner join Warehouse on Goods.WId = Warehouse.Id

select Name,BarCode,COUNT(BarCode) as Count from Goods group by Name,BarCode

select Name,PinyinCode,BarCode,COUNT(BarCode) as Count from
(select * from Goods WHERE [EffectiveTime]>0 AND datediff(day,GETDATE(),dateadd(day,[EffectiveTime],[ProducedDate]))<180) as TempTB
group by Name,BarCode,PinyinCode 

select [Name],[PinyinCode],[BarCode],[ProducedDate],[EffectiveTime],COUNT(BarCode) as Count from
(select * from Goods WHERE [EffectiveTime]>0 AND datediff(day,GETDATE(),dateadd(day,[EffectiveTime],[ProducedDate]))<180) as TempTB
Where Name like '%面%'
group by Name,BarCode,PinyinCode,[ProducedDate],[EffectiveTime]