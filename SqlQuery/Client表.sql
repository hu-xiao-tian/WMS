--(未最终确定，还未执行)
create table Client(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
Address nvarchar(100) not null,
Tel nvarchar(20) not null --供应商与客户电话与个人不同，也许区号为别国也可能为座机，未找到合适解决方案前不做处理
)


