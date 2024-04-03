--CREATE LOGIN vtyslabodev WITH PASSWORD = '123', DEFAULT_DATABASE = vtyslabodev;

--USE vtysodev;
--CREATE USER vtyslabodev FOR LOGIN vtyslabodev;

--GRANT INSERT, UPDATE TO vtyslabodev; -- Ekleme ve Deðiþtirme yetkileri
--GRANT UPDATE, INSERT TO vtyslabodev; -- Deðiþtirme ve Ekleme yetkileri
--GRANT DELETE, INSERT TO vtyslabodev; -- Silme ve Ekleme yetkileri

-- Kullanýcýdan tüm yetkileri kaldýr
USE vtyslabodev;
REVOKE ALL FROM vtyslabodev;

-- Kullanýcýyý market veritabanýndan sil
DROP LOGIN vtyslabodev;