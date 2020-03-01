
create table ClientType(
AutoId int primary key identity(1,1),
Name nvarchar(50) not null,
RankNum int not null
)

insert into ClientType ([Name],[RankNum]) values ('食品',1) 
insert into ClientType ([Name],[RankNum]) values ('日用品',2) 

select * from ClientType

--类型名称，作为赛选条件应该为不重复的
ALTER TABLE ClientType
ADD
CONSTRAINT Name_no_unique_constraint UNIQUE (Name)
