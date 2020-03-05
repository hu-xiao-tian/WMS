--(未最终确定，还未执行)
create table WStatistics(
	AutoId int primary key identity(1,1),
	InPrice float not null,
	OutPrice float not null,
	BadPrice float not null,
	ProfitPrice float not null,
	DateCode int not null,
)
truncate table WStatistics