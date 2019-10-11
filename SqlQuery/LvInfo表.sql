create table LvInfo(
AutoId int primary key identity(1,1),
UserLv int not null,
LvInstructions nvarchar(20) not null
)

insert into LvInfo(UserLv,LvInstructions) values(5,'总经理')
insert into LvInfo(UserLv,LvInstructions) values(4,'副经理')
insert into LvInfo(UserLv,LvInstructions) values(3,'主管')
insert into LvInfo(UserLv,LvInstructions) values(2,'小队长')
insert into LvInfo(UserLv,LvInstructions) values(1,'员工')
insert into LvInfo(UserLv,LvInstructions) values(0,'未授权用户')