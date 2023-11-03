--25 En çok satılan ürününün adı, kategorisinin adı ve tedarikçisinin adı
SELECT 	products.product_name, categories.category_name, suppliers.company_name,
	SUM(order_details.quantity) AS total_quantity
FROM products
JOIN Categories ON products.category_id = categories.category_id
JOIN Suppliers  ON products.supplier_id= suppliers.supplier_id
JOIN order_details ON products.product_id = order_details.product_id
GROUP BY products.product_name, categories.category_name, suppliers.company_name
LIMIT 1;

--26 Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.
SELECT products.product_id,products.product_name, suppliers.company_name, suppliers.phone
FROM products
JOIN suppliers ON products.supplier_id = suppliers.supplier_id
WHERE products.units_in_stock = 0;

--27 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı

SELECT orders.order_date, customers.address,employees.first_name,employees.last_name
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
JOIN employees ON orders.employee_id = employees.employee_id
WHERE orders.order_date BETWEEN '1998-03-01' AND '1998-03-31';

--28 1997 yılı şubat ayında kaç siparişim var?

SELECT COUNT(*) as orders_count_sum
FROM orders
WHERE order_date BETWEEN '1997-02-01' AND '1997-02-28';

--29 London şehrinden 1998 yılında kaç siparişim var?
SELECT COUNT(*) AS orders_on_london
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
WHERE orders.ship_city = 'London' AND orders.order_date BETWEEN '1998-01-01' AND '1998-12-31';

--select * from orders
--WHERE orders.ship_city = 'London'

--30 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası
SELECT customers.contact_name, customers.phone
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
WHERE orders.order_date BETWEEN '1997-01-01' AND '1997-12-31';

--31 Taşıma ücreti 40 üzeri olan siparişlerim

SELECT orders.order_id, orders.order_date,customers.customer_id 
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
WHERE orders.freight > 40;

--SELECT *
--FROM ORDERS
--WHERE orders.freight > 40 ;

--SELECT count(*) as toplam 
--FROM ORDERS
--WHERE orders.freight > 40 ;

--32 Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı
SELECT customers.contact_name,orders.ship_city
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
WHERE orders.freight > 40;

--33 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf)

SELECT 
    UPPER(CONCAT(employees.first_name, ' ', employees.last_name)) AS employee_name, UPPER(orders.ship_city) as city_info, orders.order_date
FROM orders
JOIN employees ON orders.employee_id = employees.employee_id
WHERE orders.order_date BETWEEN '1997-01-01' AND '1997-12-31';

--34 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )
SELECT 
    customers.contact_name AS contact_name,
    CONCAT(SUBSTR(customers.phone, 1, 3), '-', SUBSTR(customers.phone, 4, 4)) AS phone
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
WHERE orders.order_date BETWEEN '1997-01-01' AND '1997-12-31';


--35 Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad

SELECT orders.order_date AS order_date,
    customers.contact_name AS customers,
    UPPER(CONCAT(employees.first_name, ' ', employees.last_name)) AS name_surname
FROM orders
JOIN customers ON orders.customer_id = customers.customer_id
JOIN employees ON orders.employee_id = employees.employee_id;

--36 Geciken siparişlerim?
SELECT shipped_date, required_date
from orders
where shipped_date > required_date;

--37 Geciken siparişlerimin tarihi, müşterisinin adı
SELECT orders.shipped_date, customers.contact_name
from orders 
join customers on orders.customer_id = customers.customer_id
where shipped_date > required_date;

--38 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
SELECT products.product_name, categories.category_name, order_details.quantity
FROM order_details
JOIN products ON order_details.product_id = products.product_id
JOIN categories ON products.category_id = categories.category_id
WHERE order_details.order_id = 10248;

--39 10248 nolu siparişin ürünlerinin adı , tedarikçi adı
SELECT products.product_name, suppliers.company_name, order_details.quantity
FROM order_details
JOIN products ON order_details.product_id = products.product_id
JOIN suppliers ON products.supplier_id = suppliers.supplier_id
WHERE order_details.order_id = 10248;

--40 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti

SELECT employees.employee_id, employees.first_name, employees.last_name, products.product_name, order_details.quantity
FROM orders
JOIN employees ON orders.employee_id = employees.employee_id
JOIN order_details ON orders.order_id = order_details.order_id
JOIN products ON order_details.product_id = products.product_id
WHERE employees.employee_id = 3 AND orders.order_date >= '1997-01-01' AND orders.order_date < '1998-01-01';


--41 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad
Select e.employee_id, e.first_name, e.last_name, od.quantity, o.order_date from orders o
INNER JOIN employees e
ON o.employee_id = e.employee_id
INNER JOIN order_details od
ON od.order_id = o.order_id
INNER JOIN products p
ON od.product_id = p.product_id
WHERE date_part('year',order_date) = 1997
ORDER BY od.quantity DESC limit 1;

--42 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****

select e.employee_id,e.first_name,e.last_name,SUM(od.quantity) from order_details od
INNER JOIN orders o
on od.order_id = o.order_id
INNER JOIN employees e
on o.employee_id = e.employee_id
where date_part('year',order_date) = 1997 
group by  e.employee_id
ORDER BY SUM(od.quantity) DESC  LIMIT 1;

--43 En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?

SELECT products.product_name,products.unit_price,categories.category_name
FROM products 
INNER JOIN categories ON products.category_id = categories.category_id
ORDER BY unit_price DESC LIMIT 1;

--44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
SELECT e.first_name, e.last_name, o.order_date, o.order_id
FROM orders o
JOIN employees e ON o.employee_id = e.employee_id
ORDER BY o.order_date;

--45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?

select AVG(p.unit_price),o.order_date,o.order_id from orders o
INNER JOIN order_details od
on od.order_id =o.order_id
INNER JOIN products p
ON od.product_id = p.product_id
group by o.order_date,o.order_id 
order by o.order_date DESC 
LIMIT 5;

--46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?

SELECT products.product_name, categories.category_name, SUM(order_details.quantity) AS sum_count
FROM orders
JOIN order_details ON orders.order_id = order_details.order_id
JOIN products ON order_details.product_id = products.product_id
JOIN categories ON products.category_id = categories.category_id
where date_part('month',order_date) = 1 
GROUP BY products.product_name, categories.category_name;

--47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?

SELECT quantity FROM order_details
Where quantity > (SELECT AVG(quantity) FROM order_details)
ORDER BY quantity;

--48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı

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

--49. Kaç ülkeden müşterim var
SELECT COUNT(DISTINCT Country) AS customers_count
FROM Customers;

--50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?
Select SUM(order_details.quantity*products.unit_price) from orders 
INNER JOIN employees ON orders.employee_id = employees.employee_id
INNER JOIN order_details ON order_details.order_id = orders.order_id
INNER JOIN products ON order_details.product_id = products.product_id
WHERE employees.employee_id =3 AND order_date >= '1998.01.01';




