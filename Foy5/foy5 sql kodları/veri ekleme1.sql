-- Fakülteler tablosuna veri ekleme
INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES 
(1, 'Mühendislik Fakültesi'),
(2, 'Fen Fakültesi'),
(3, 'Ýþletme Fakültesi');

-- Bölümler tablosuna veri ekleme
INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES 
(1, 'Bilgisayar Mühendisliði', 1),
(2, 'Matematik', 2),
(3, 'Ýþletme', 3);

-- Öðrenciler tablosuna veri ekleme
INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES 
(1, 'Ahmet', 'Yýlmaz', 1),
(2, 'Ayþe', 'Kaya', 2),
(3, 'Mehmet', 'Demir', 3);

-- Dersler tablosuna veri ekleme
INSERT INTO tDers (dersID, dersAd) VALUES 
(1, 'Veritabaný Yönetimi'),
(2, 'Lineer Cebir'),
(3, 'Muhasebe');

-- Öðrenci Ders tablosuna veri ekleme
INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil, vize, final) VALUES 
(1, 1, '2024', 'Bahar', 70, 80),
(2, 2, '2024', 'Bahar', 75, 85),
(3, 3, '2024', 'Bahar', 80, 90);
