--61. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
SELECT products.product_name, categories.category_name, suppliers.company_name
FROM products
JOIN categories ON products.category_id = categories.category_id
JOIN suppliers ON products.supplier_id = suppliers.supplier_id
WHERE products.product_id = (
    SELECT product_id
    FROM order_details
    GROUP BY product_id
    ORDER BY SUM(quantity) DESC
    LIMIT 1
);
--62. Kaç ülkeden müşterim var

SELECT COUNT(DISTINCT Country) as customer_countries
FROM Customers;

--63. Hangi ülkeden kaç müşterimiz var
SELECT Country, COUNT(*) AS customer_count
FROM CUSTOMERS
GROUP BY Country
ORDER BY customer_count;

--64. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?

Select CONCAT(employees.first_name,' ',employees.last_name) as full_name, SUM(order_details.quantity*products.unit_price) as total_sale
from orders 
INNER JOIN employees ON orders.employee_id = employees.employee_id
INNER JOIN order_details ON order_details.order_id = orders.order_id
INNER JOIN products ON order_details.product_id = products.product_id
WHERE employees.employee_id =3 AND order_date >= '1997.01.01'
group by full_name;

--65. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?
--ID numarası 10 olan ürünün son 3 aydaki cirosunu ve ismini yazdırıyor
SELECT  p.product_name as pname, SUM(od.quantity * od.unit_price) AS TotalRevenue
FROM order_details od
INNER JOIN orders o ON od.order_id = o.order_id
INNER JOIN products p ON od.product_id = p.product_id
WHERE od.product_id= 10 AND o.order_date >= '1998.03.01'
group by pname;
--select *  from products

--66. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?
SELECT e.employee_id as employee_id, CONCAT(first_name,' ',last_name) AS FULLNAME, (SELECT COUNT(order_id) FROM orders WHERE employee_id = e.employee_id) AS total_orders
FROM employees e 
group by FULLNAME, employee_id
ORDER BY total_orders;

--67. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun
SELECT *
FROM Customers
WHERE customer_id NOT IN (
    SELECT DISTINCT customer_id
    FROM Orders
);

--68. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri
SELECT company_name, contact_name, address, city, country
FROM customers
WHERE Country = 'Brazil';

--69. Brezilya’da olmayan müşteriler
SELECT company_name, country, city
FROM customers
WHERE Country != 'Brazil';

--70. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
SELECT customer_id, company_name, country 
FROM customers
WHERE country IN ('Spain', 'France', 'Germany');

--71. Faks numarasını bilmediğim müşteriler
SELECT company_name, country, city, fax
FROM customers
WHERE fax is null;

--72. Londra’da ya da Paris’de bulunan müşterilerim
SELECT customer_id, company_name, city
FROM customers
WHERE city IN ('London', 'Paris');

--73. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler
SELECT customer_id, company_name, city, contact_title
FROM customers
WHERE city = 'México D.F.' and contact_title= 'Owner';

--74. C ile başlayan ürünlerimin isimleri ve fiyatları
SELECT product_name, unit_price
FROM products
WHERE product_name LIKE 'c%' or product_name LIKE 'C%';

--75. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri
SELECT first_name, last_name, birth_date
FROM employees
WHERE first_name LIKE 'a%' or first_name LIKE 'A%';

--76. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları
SELECT company_name
FROM customers
WHERE company_name like '%Restaurant%' or company_name like '%restaurant%';

--77. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları
SELECT unit_price, product_name
FROM products
WHERE  unit_price >= 50 and unit_price <= 100 
order by unit_price;

--78. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri
SELECT order_id, order_date
FROM orders
WHERE order_date >= '1996.07.01' and order_date <= '1996.12.31';

--79. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
SELECT customer_id, company_name, country 
FROM customers
WHERE country IN ('Spain', 'France', 'Germany');

--80. Faks numarasını bilmediğim müşteriler
SELECT company_name, country, city, fax
FROM customers
WHERE fax is null;

--81. Müşterilerimi ülkeye göre sıralıyorum:
SELECT company_name, country
from customers;

--82. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz
SELECT product_name, unit_price
FROM products
order by unit_price desc;

--83. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz
SELECT product_name, unit_price, units_in_stock
FROM products
order by unit_price desc, units_in_stock;


--84. 1 Numaralı kategoride kaç ürün vardır..?
SELECT count(*)
from products 
WHERE category_id=1;

--85. Kaç farklı ülkeye ihracat yapıyorum..?
SELECT COUNT(DISTINCT ship_country) as ship_countries
from orders;
