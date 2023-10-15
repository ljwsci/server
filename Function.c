模块:
Finction name(db,字段名)
Dim 记录集 As DAO.Recordset(db)
记录集.AddNew
记录集!字段名=字段名
记录集.Update
记录集.Close
Set 记录集 = Nothing
字段名.Value= Null
End Function