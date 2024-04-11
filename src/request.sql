-- Создание таблицы Products
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255)
);

-- Создание таблицы Categories
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(255)
);

-- Создание таблицы ProductCategory для связи продуктов с категориями
CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Добавление данных в таблицу Products
INSERT INTO Products (ProductID, ProductName)
VALUES
    (1, 'Product 1'),
    (2, 'Product 2'),
    (3, 'Product 3'),
    (4, 'Product 4');

-- Добавление данных в таблицу Categories
INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, 'Category A'),
    (2, 'Category B'),
    (3, 'Category C');

-- Добавление связей между продуктами и категориями в таблицу ProductCategory
INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES
    (1, 1),
    (1, 2),
    (2, 2),
    (3, 3);

-- SQL запрос для выбора всех пар "Имя продукта - Имя категории"
SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;
