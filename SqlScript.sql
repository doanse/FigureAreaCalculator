--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
--Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT p.Name as ProductName, c.Name as CategoryName FROM [Product] p
LEFT JOIN [ProductCategory] pc on p.ProductID = pc.ProductID
LEFT JOIN [Category] c on c.CategoryID = pc.CategoryID