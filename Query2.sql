-- 1.Initialize
IF OBJECT_ID('dbo.CategoryToProduct', 'U') IS NOT NULL
DROP TABLE dbo.CategoryToProduct;

IF OBJECT_ID('dbo.Category', 'U') IS NOT NULL
DROP TABLE dbo.Category;

IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL
DROP TABLE dbo.Product;

CREATE TABLE dbo.Category (
	IDCategory INT IDENTITY(1,1),
	Name VARCHAR(100),
	PRIMARY KEY(IDCAtegory)
)

CREATE TABLE dbo.Product(
	IDProduct INT IDENTITY(1,1),
	Name VARCHAR(100),
	PRIMARY KEY (IDProduct)
)

CREATE TABLE dbo.CategoryToProduct(
	ID INT IDENTITY(1,1),
	IDCategory INT,
	IDProduct INT,
	PRIMARY KEY (ID)
)

ALTER TABLE dbo.CategoryToProduct 
ADD CONSTRAINT FK_Category_to_product 
FOREIGN KEY (IDCategory) 
REFERENCES dbo.Category (IDCategory) 
ON UPDATE CASCADE
ON DELETE SET NULL; 

ALTER TABLE dbo.CategoryToProduct 
ADD CONSTRAINT FK_Product_to_Category 
FOREIGN KEY (IDProduct) 
REFERENCES dbo.Product (IDProduct) 
ON UPDATE CASCADE
ON DELETE CASCADE; 

-- 2. ADD Data
INSERT INTO dbo.Category ([Name])
VALUES ('Cat 1'), ('Cat 2');

INSERT INTO dbo.Product([Name])
VALUES ('Prod 1'), ('Prod 2');

INSERT INTO dbo.CategoryToProduct ([IDCategory],[IDProduct])
SELECT
	[IDCategory],
	[IDProduct]
FROM
	dbo.Category,
	dbo.Product;
--¬ задании не сказано, что нет повторов среди продуктов, поэтому удвоение записей
INSERT INTO dbo.CategoryToProduct ([IDCategory],[IDProduct])
SELECT
	[IDCategory],
	[IDProduct]
FROM
	dbo.Category,
	dbo.Product;


INSERT INTO dbo.Product([Name])
VALUES ('Prod Not Cat 3'), ('Prod Not Cat 4');

--SELECT	*
--FROM dbo.Category;

--SELECT	*
--FROM dbo.Product;

--SELECT	*
--FROM dbo.CategoryToProduct;

-- 3. Query
SELECT
	DISTINCT
	Product.Name [ProductName],
	Category.Name [CategodyName]
FROM
	dbo.Product 
	LEFT JOIN dbo.CategoryToProduct on Product.IDProduct = CategoryToProduct.IDProduct
	LEFT JOIN dbo.Category on Category.IDCategory = CategoryToProduct.IDCategory
	;