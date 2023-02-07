SELECT Product.name, Category.name 
FROM Product 
  LEFT JOIN Product_Category ON Product.id = Product_Category.product_id
  LEFT JOIN Category ON Product_Category.category_id = Category.id
