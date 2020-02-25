--(未最终确定，还未执行)
create table Supplier(
AutoId int primary key identity(1,1),
CompanyName nvarchar(50) not null,
PinyinCode nvarchar(100) not null,
ContactName nvarchar(50),
Area nvarchar(50),
Address nvarchar(100) not null,
WebSite nvarchar(2000),
Tel nvarchar(20) not null, --供应商电话与个人不同，也许区号为别国也可能为座机，未找到合适解决方案前不做处理
Email nvarchar(20) not null,
TypeId int not null,--用类型id去关联，类型修改的时候可以联动性修改
RankNum int not null
)

insert into Supplier
([CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[RankNum])
values
('卫龙','WeiLong','卫龙老板','福建省','福建省福州市','www.weilong.cn','13123456789','weilong@weilong.cn',1,1)

select * from Supplier
select * from SupplierType

update Supplier set TypeId='7' where AutoId = 1

select Supplier.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[Name] as TypeName,Supplier.[RankNum] 
from Supplier inner join SupplierType on Supplier.TypeId = SupplierType.AutoId