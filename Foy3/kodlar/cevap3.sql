SELECT c.ad, c.soyad, c.maas
FROM calisanlar c
INNER JOIN birimler b ON c.calisan_birim_id = b.birim_id
WHERE b.birim_ad = 'Yaz�l�m' OR b.birim_ad = 'Donan�m';