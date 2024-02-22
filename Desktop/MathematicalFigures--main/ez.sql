SELECT products.name,categorys.name FROM test.products 
LEFT JOIN product_catigory  ON products.id = product_catigory.product_id
LEFT JOIN categorys  on product_catigory.catigory_id=categorys.id

;
