-- Fakülteler tablosuna veri ekleme
INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES 
(4, 'Edebiyat Fakültesi'),
(5, 'Hukuk Fakültesi'),
(6, 'Týp Fakültesi');

-- Bölümler tablosuna veri ekleme
INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES 
(4, 'Türk Dili ve Edebiyatý', 4),
(5, 'Hukuk', 5),
(6, 'Týp', 6);

-- Öðrenciler tablosuna veri ekleme
INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES 
(4, 'Elif', 'Çelik', 4),
(5, 'Ali', 'Kurt', 5),
(6, 'Zeynep', 'Þahin', 6);

-- Dersler tablosuna veri ekleme
INSERT INTO tDers (dersID, dersAd) VALUES 
(4, 'Türk Edebiyatý'),
(5, 'Anayasa Hukuku'),
(6, 'Anatomi');

-- Öðrenci Ders tablosuna veri ekleme
INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil, vize, final) VALUES 
(4, 4, '2024', 'Bahar', 85, 90),
(5, 5, '2024', 'Bahar', 78, 88),
(6, 6, '2024', 'Bahar', 82, 89);
