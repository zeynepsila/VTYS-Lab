--CREATE LOGIN vtyslabodev WITH PASSWORD = '123', DEFAULT_DATABASE = vtyslabodev;

--USE vtysodev;
--CREATE USER vtyslabodev FOR LOGIN vtyslabodev;

--GRANT INSERT, UPDATE TO vtyslabodev; -- Ekleme ve Değiştirme yetkileri
--GRANT UPDATE, INSERT TO vtyslabodev; -- Değiştirme ve Ekleme yetkileri
--GRANT DELETE, INSERT TO vtyslabodev; -- Silme ve Ekleme yetkileri

-- Kullanıcıdan tüm yetkileri kaldır
USE vtyslabodev;
REVOKE ALL FROM vtyslabodev;

-- Kullanıcıyı market veritabanından sil
DROP LOGIN vtyslabodev;