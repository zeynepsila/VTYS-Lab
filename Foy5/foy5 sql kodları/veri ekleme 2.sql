-- Fak�lteler tablosuna veri ekleme
INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES 
(4, 'Edebiyat Fak�ltesi'),
(5, 'Hukuk Fak�ltesi'),
(6, 'T�p Fak�ltesi');

-- B�l�mler tablosuna veri ekleme
INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES 
(4, 'T�rk Dili ve Edebiyat�', 4),
(5, 'Hukuk', 5),
(6, 'T�p', 6);

-- ��renciler tablosuna veri ekleme
INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES 
(4, 'Elif', '�elik', 4),
(5, 'Ali', 'Kurt', 5),
(6, 'Zeynep', '�ahin', 6);

-- Dersler tablosuna veri ekleme
INSERT INTO tDers (dersID, dersAd) VALUES 
(4, 'T�rk Edebiyat�'),
(5, 'Anayasa Hukuku'),
(6, 'Anatomi');

-- ��renci Ders tablosuna veri ekleme
INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil, vize, final) VALUES 
(4, 4, '2024', 'Bahar', 85, 90),
(5, 5, '2024', 'Bahar', 78, 88),
(6, 6, '2024', 'Bahar', 82, 89);
