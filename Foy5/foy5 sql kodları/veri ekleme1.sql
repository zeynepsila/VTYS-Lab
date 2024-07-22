-- Fak�lteler tablosuna veri ekleme
INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES 
(1, 'M�hendislik Fak�ltesi'),
(2, 'Fen Fak�ltesi'),
(3, '��letme Fak�ltesi');

-- B�l�mler tablosuna veri ekleme
INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES 
(1, 'Bilgisayar M�hendisli�i', 1),
(2, 'Matematik', 2),
(3, '��letme', 3);

-- ��renciler tablosuna veri ekleme
INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES 
(1, 'Ahmet', 'Y�lmaz', 1),
(2, 'Ay�e', 'Kaya', 2),
(3, 'Mehmet', 'Demir', 3);

-- Dersler tablosuna veri ekleme
INSERT INTO tDers (dersID, dersAd) VALUES 
(1, 'Veritaban� Y�netimi'),
(2, 'Lineer Cebir'),
(3, 'Muhasebe');

-- ��renci Ders tablosuna veri ekleme
INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil, vize, final) VALUES 
(1, 1, '2024', 'Bahar', 70, 80),
(2, 2, '2024', 'Bahar', 75, 85),
(3, 3, '2024', 'Bahar', 80, 90);
