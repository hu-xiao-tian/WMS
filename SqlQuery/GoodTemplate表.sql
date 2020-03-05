
create table GoodsTemplate(
AutoId int primary key identity(1,1),--自增id用于统计
Name nvarchar(50) not null,
PinyinCode nvarchar(100) not null,
BarCode nvarchar(50) not null,--条形码，同一货物的条形码相同
--ImageURL nvarchar(4000) not null, --是因为真的有网址长的吓人，即使是ie支持的URL也长达2083
ImageName nvarchar(4000), --做HTTP请求太影响效率，将图片保存在本地文件夹(命名规则:货物名称.jpg)
TId int,
--TName nvarchar(50),--可能不需要，对象需要有属性但是表中可以省略，使用id关联就够了
SId int,
--SName nvarchar(50),--可能不需要
--Count int, --统计取消了,每一个货物都应该是一个对象
Description nvarchar(1000) --描述暂定1000,毕竟屁话太多也没人看

)
--本表只存储每一种类的货物模板，故条形码唯一(网上看的,同类货物条形码一样)、货物名称唯一。
--拼音码可能会设置为空，就不做唯一约束了
ALTER TABLE GoodsTemplate
ADD
CONSTRAINT BarCode_no_unique_constraint UNIQUE (BarCode)
ALTER TABLE GoodsTemplate
ADD
CONSTRAINT Name_no_unique_constraint UNIQUE (Name)

Insert into GoodsTemplate ( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId])
Values('卫龙大面筋','WeiLongDaMianJin','12121212','卫龙大面筋.jpg',1,1)

Insert into GoodsTemplate ( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId])
Values('康师傅方便面','KangShiFuFangBianMian','13131313','康师傅方便面.jpg',1,1)

Update GoodsTemplate Set [SId] = 1 Where AutoId = 1

select * from GoodsTemplate
select * from Supplier

select GoodsTemplate.[AutoId],GoodsTemplate.[Name],GoodsTemplate.[PinyinCode],[BarCode],[ImageName], 
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName
from GoodsTemplate inner join GoodsType on GoodsTemplate.TId = GoodsType.AutoId
inner join Supplier on GoodsTemplate.SId = Supplier.AutoId