--CREATE LOGIN vtyslabodev WITH PASSWORD = '123', DEFAULT_DATABASE = vtyslabodev;

--USE vtysodev;
--CREATE USER vtyslabodev FOR LOGIN vtyslabodev;

--GRANT INSERT, UPDATE TO vtyslabodev; -- Ekleme ve De�i�tirme yetkileri
--GRANT UPDATE, INSERT TO vtyslabodev; -- De�i�tirme ve Ekleme yetkileri
--GRANT DELETE, INSERT TO vtyslabodev; -- Silme ve Ekleme yetkileri

-- Kullan�c�dan t�m yetkileri kald�r
USE vtyslabodev;
REVOKE ALL FROM vtyslabodev;

-- Kullan�c�y� market veritaban�ndan sil
DROP LOGIN vtyslabodev;