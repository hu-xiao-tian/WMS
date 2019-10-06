create table LoginUser(
AutoId int primary key identity(1,1),
UserName nvarchar(20) not null,
UserPassword nvarchar(20) not null,
UserEmail nvarchar(50),
UserNickname nvarchar(20),
UserSignature nvarchar(200),
UserPortraitUrl nvarchar(2000)
)


ALTER TABLE LoginUser
ADD
CONSTRAINT LoginUser_no_unique_constraint UNIQUE (UserName)


ALTER TABLE LoginUser
ADD UserLV int 

alter table LoginUser alter column UserPassword nvarchar(50);


insert into LoginUser(UserName,UserPassword,UserLV) Values('55746039','f336d685d739b90cae3cfd5b02c8b67a',5)--管理员最高权限5级账号