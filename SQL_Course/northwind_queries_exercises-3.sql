--86 a.Bu ülkeler hangileri..?
select distinct country from customers order by country asc;

--87 En Pahalı 5 ürün
select unit_price from products
order by unit_price desc
limit 5;

--88 ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?
select count(*) as SiparisSayisi from orders
where customer_id='ALFKI';

--89 Ürünlerimin toplam maliyeti
select sum(unit_price*units_in_stock)as ToplamMaliyet from products;

--90 Şirketim, şimdiye kadar ne kadar ciro yapmış..?
select sum(unit_price*units_in_stock)as ToplamMaliyet from products;

--91 Ortalama Ürün Fiyatım
select avg(unit_price) as OrtalamaFiyat from products;

--92 En Pahalı Ürünün Adı
select product_name from products
order by unit_price desc
limit 1;

--93 En az kazandıran sipariş
select
    orders.order_id,
    sum(products.unit_price * order_details.quantity) as gain
from
    orders
inner join
    order_details on orders.order_id = order_details.order_id
inner join
    products on order_details.product_id = products.product_id
group by
    orders.order_id
order by
    gain
limit 1;

--94 Müşterilerimin içinde en uzun isimli müşteri
select company_name,length(company_name) from customers
order by length(company_name) desc
limit 1;

--95 Çalışanlarımın Ad, Soyad ve Yaşları
SELECT first_name, last_name, EXTRACT(YEAR FROM AGE(birth_date)) as age
FROM Employees;

--96 Hangi siparişte toplam ne kadar kazanmışım..?
select products.product_name,  sum(order_details.quantity) as totalsale
from products
join order_details on products.product_id = order_details.product_id
group by products.product_name
order by totalsale desc;

--97 Hangi siparişte toplam ne kadar kazanmışım..?
select orders.order_id AS "Sipariş ID", sum(order_details.unit_price * order_details.quantity) AS "Toplam Kazanç"
from orders
inner join order_details ON orders.order_id = order_details.order_id
group by orders.order_id;

--98 Hangi kategoride toplam kaç adet ürün bulunuyor..?
select categories.category_name AS "Kategori Adı", COUNT(products.product_id) AS "Toplam Ürün Sayısı"
from categories
inner join products ON categories.category_id = products.category_id
group by categories.category_name;

--99 1000 Adetten fazla satılan ürünler?
select *
from (
  select products.product_name, sum(order_details.quantity) as totalsalesquantity
  from products
  join order_details on products.product_id = order_details.product_id
  group by products.product_name
) as subquery
where totalsalesquantity > 1000
order by totalsalesquantity desc;

--100 Hangi Müşterilerim hiç sipariş vermemiş..?
SELECT customer_id, company_name
from customers
where customer_id not in (select distinct customer_id from orders);

--101 Hangi tedarikçi hangi ürünü sağlıyor ?
select suppliers.company_name as supplier, products.product_name as product
from suppliers
join products on suppliers.supplier_id = products.supplier_id
order by supplier, product;

--102. Hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş..?
select orders.order_id AS OrderID,
shippers.company_name AS ShipperName,
orders.shipped_date AS ShippedDate
from orders
inner join shippers ON orders.ship_via = shippers.shipper_id;

--103. Hangi siparişi hangi müşteri verir..?
select orders.order_id AS OrderID,
customers.contact_name AS CustomerName
from orders
inner join customers on orders.customer_id = customers.customer_id;

--104. Hangi çalışan, toplam kaç sipariş almış..?
select employees.employee_id AS EmployeeID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
count(orders.order_id) AS TotalOrders
from employees
left join orders on employees.employee_id = orders.employee_id
group by employees.employee_id, EmployeeName
order by TotalOrders desc;

--105. En fazla siparişi kim almış..?
select employees.employee_id AS EmployeeID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
count(orders.order_id) AS TotalOrders
from employees
left join orders on employees.employee_id = orders.employee_id
group by employees.employee_id, EmployeeName
order by TotalOrders desc
limit 1;

--106. Hangi siparişi, hangi çalışan, hangi müşteri vermiştir..?
select orders.order_id AS OrderID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
concat(customers.contact_name, '(', customers.customer_id,')') AS CustomerName
from orders
inner join employees on orders.employee_id = employees.employee_id
inner join customers on orders.customer_id = customers.customer_id;

--107. Hangi ürün, hangi kategoride bulunmaktadır..? Bu ürünü kim tedarik etmektedir..?
select products.product_name AS ProductName,
categories.category_name AS CategoryName,
suppliers.company_name AS SupplierName
from products
inner join categories ON products.category_id = categories.category_id
inner join suppliers on products.supplier_id = suppliers.supplier_id;

--108. Hangi siparişi hangi müşteri vermiş, hangi çalışan almış, hangi tarihte, hangi kargo şirketi tarafından gönderilmiş hangi üründen kaç adet alınmış, hangi fiyattan alınmış, ürün hangi kategorideymiş bu ürünü hangi tedarikçi sağlamış
select orders.order_id,
	   customers.company_name,
	   customers.contact_name,
	   orders.shipped_date,
	   orders.ship_name,
	   products.product_name,
	   order_details.quantity,
	   categories.category_name,
	   suppliers.company_name
from orders 
inner join order_details on order_details.order_id=orders.order_id
inner join customers on customers.customer_id=orders.customer_id
inner join products on products.product_id= order_details.product_id
inner join suppliers on suppliers.supplier_id= products.supplier_id
inner join categories on categories.category_id=products.category_id;

--109. Altında ürün bulunmayan kategoriler
select categories.category_id,categories.category_name, products.product_name
from categories
left join products ON categories.category_id = products.category_id
where products.product_id IS NULL;

--110. Manager ünvanına sahip tüm müşterileri listeleyiniz.
select *
from customers
where customers.contact_title like '%Manager%';

--111. FR ile başlayan 5 karekter olan tüm müşterileri listeleyiniz.
select *
from customers
where customers.company_name like '%Fr' and length(customers.company_name)=5;

--112. (171) alan kodlu telefon numarasına sahip müşterileri listeleyiniz.
select *
from customers
where customers.phone like '(171)%';

--113. BirimdekiMiktar alanında boxes geçen tüm ürünleri listeleyiniz.
select *
from products
where products.quantity_per_unit like '%boxes%';

--114. Fransa ve Almanyadaki (France,Germany) Müdürlerin (Manager) Adını ve Telefonunu listeleyiniz.(MusteriAdi,Telefon)
SELECT c.contact_name, c.phone
FROM customers c
WHERE c.contact_title like '%Manager%' and c.country IN ('France','Germany');

--115. En yüksek birim fiyata sahip 10 ürünü listeleyiniz.
SELECT product_name,unit_price 
from products
order by unit_price desc
limit 10;

--116. Müşterileri ülke ve şehir bilgisine göre sıralayıp listeleyiniz.
select c.country, c.city  from customers c
order by c.country, c.city;

--117. Personellerin ad,soyad ve yaş bilgilerini listeleyiniz.
SELECT first_name, last_name, EXTRACT(YEAR FROM AGE(birth_date)) as age
FROM Employees;

--118. 35 gün içinde sevk edilmeyen satışları listeleyiniz.
SELECT *
FROM orders
WHERE order_date < NOW() - INTERVAL '35 days' AND shipped_date IS NULL;

--119. Birim fiyatı en yüksek olan ürünün kategori adını listeleyiniz. (Alt Sorgu)
select product_name,unit_price, products.category_id, categories.category_name
from products
JOIN categories ON products.category_id = categories.category_id
order by unit_price desc
limit 1;
--120. Kategori adında 'on' geçen kategorilerin ürünlerini listeleyiniz. (Alt Sorgu)
select products.product_name, categories.category_name
from products
join categories on products.category_id = categories.category_id
where categories.category_name like '%on%';

--121. Konbu adlı üründen kaç adet satılmıştır.
select products.product_name, sum(order_details.quantity) as totalsalesquantity
from products
join order_details on products.product_id = order_details.product_id
where products.product_name = 'Konbu'
group by products.product_name;

--122. Japonyadan kaç farklı ürün tedarik edilmektedir.
select count(distinct products.product_id) as differentproductcount,
suppliers.country as country
from products
join suppliers on products.supplier_id = suppliers.supplier_id
where suppliers.country = 'Japan'
group by suppliers.country;

--123. 1997 yılında yapılmış satışların en yüksek, en düşük ve ortalama nakliye ücretlisi ne kadardır?
select 
    max(freight) as maxshippingfee,
    min(freight) as minshippingfee,
    avg(freight) as avgshippingfee
from orders
where extract(year from order_date) = 1997;

--124. Faks numarası olan tüm müşterileri listeleyiniz.
select city, address, fax
from customers
where fax is not null and fax != ''
order by city;

--125. 1996-07-16 ile 1996-07-30 arasında sevk edilen satışları listeleyiniz. 
select ship_city, ship_name, shipped_date
from orders where orders.shipped_date
between '1996-07-16' and '1996-07-30'
order by shipped_date;


