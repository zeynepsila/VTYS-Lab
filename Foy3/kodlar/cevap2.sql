--birimler tablosu veri ekleme
INSERT INTO birimler (birim_id, birim_ad) VALUES
(1, 'Yaz�l�m'),
(2, 'Donan�m'),
(3, 'G�venlik');

--calisanlar tablosu veri ekleme
INSERT INTO calisanlar (calisan_id, ad, soyad, maas, katilmaTarihi, calisan_birim_id) VALUES 
(1, '�smail', '��eri', 100000, '2014-02-20', 1),
(2, 'Hami', 'Sat�lm��', 80000, '2014-06-11', 1),
(3, 'Durmu�', '�ahin', 300000, '2023-02-20', 2),
(4, 'Ka�an', 'Yazar', 500000, '2014-02-20', 3),
(5, 'Meryem', 'Soysald�', 500000, '2014-06-11', 3),
(6, 'Duygu', 'Ak�ehir', 200000, '2014-06-11', 2), 
(7, 'K�bra', 'Seyhan', 75000, '2014-01-20', 1),
(8, 'G�lcan', 'Y�ld�z', 90000, '2014-04-11', 3);


--ikramiye tablosu veri ekleme
INSERT INTO ikramiye (ikramiye_calisan_id, ikramiye_ucret, ikramiye_tarih) VALUES 
(1, 5000, '2016-02-20'),
(2, 3000, '2016-06-11'),
(3, 4000, '2016-02-20'),
(1, 4500, '2016-02-20'),
(2, 3500, '2016-06-11');

--unvan tablosu veri ekleme
INSERT INTO unvan (unvan_calisan_id, unvan_calisan, unvan_tarih) VALUES 
(1, 'Y�netici', '2016-02-20'),
(2, 'Personel', '2016-06-11'),
(8, 'Personel', '2016-06-11'),
(5, 'M�d�r', '2016-06-11'),
(4, 'Y�netici Yard�mc�s�', '2016-06-11'),
(7, 'Personel', '2016-06-11'),
(6, 'Tak�m Lideri', '2016-06-11'),
(3, 'Tak�m Lideri', '2016-06-11');