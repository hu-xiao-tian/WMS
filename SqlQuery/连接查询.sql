select * from LoginUser
select * from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv

select [UserName],[UserEmail],[UserNickname],[UserSignature],[UserPortraitUrl],LoginUser.[UserLv],[UserTel],[LvInstructions] from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv
select [AutoId],[UserName],[UserEmail],[UserNickname],[UserSignature],[UserPortraitUrl],LoginUser.[UserLv],[UserTel],[LvInstructions] 
                from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv