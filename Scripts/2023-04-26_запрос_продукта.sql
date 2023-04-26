


/*

В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

Tables:

1. Products (id, Name)
2. Categories(id, Code, Name)
3. Product_Category (id, refProduct, refCategory)
*/


Select (p.Name +' - '+ ISNULL(c.Name,' [Нет категории] ')) as 'Имя продукта – Имя категории'
from Products p
left join Product_Category cp on cp.refProduct=p.id
left join Categories c on c.id=cp.refCategory







