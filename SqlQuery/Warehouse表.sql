--(未最终确定，还未执行)
create table Warehouse(
AutoId int primary key identity(1,1),
Id nvarchar(10) not null,
Name nvarchar(50) not null,
Address nvarchar(100) not null,
Area float default 0,
Tel nvarchar(20) not null,
Contacts nvarchar(20) not null,
IsUse bit default 1,
IsDefault bit default 0,
Description nvarchar(2000) default '无',
)
ALTER TABLE Warehouse
ADD
CONSTRAINT Id_no_unique_constraint UNIQUE (Id)

