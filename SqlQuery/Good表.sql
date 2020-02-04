--(未最终确定，还未执行)
create table Good(
Id int primary key identity(1,1),--自增id用于统计
BarCode nvarchar(50) not null,--条形码，同一货物的条形码相同
Name nvarchar(50) not null,
ImageURL nvarchar(4000) not null, --此处为4000，是因为真的有网址长的吓人，即使是ie支持的URL也长达2083
TId int,
TName nvarchar(50),
SId int,
SName nvarchar(50),
Count int,
Description nvarchar(1000) --描述暂定1000,毕竟屁话太多也没人看

)
--本表只存储每一种类的货物，故条形码唯一，对条形码做唯一约束
ALTER TABLE Good
ADD
CONSTRAINT UserTel_no_unique_constraint UNIQUE (BarCode)