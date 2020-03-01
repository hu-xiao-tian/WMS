
create table SupplierType(
AutoId int primary key identity(1,1),
Name nvarchar(50) not null,
RankNum int not null
)

insert into SupplierType ([Name],[RankNum]) values ('食品',1) 
insert into SupplierType ([Name],[RankNum]) values ('日用品',2) 

select * from SupplierType

--类型名称，作为赛选条件应该为不重复的
ALTER TABLE SupplierType
ADD
CONSTRAINT Name_no_unique_constraint UNIQUE (Name)