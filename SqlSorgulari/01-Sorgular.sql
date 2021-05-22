
-- tüm şehirler
SELECT * FROM Sehirler;

-- A ile başlayan şehirler
SELECT * FROM Sehirler WHERE SehirAd LIKE 'a%';

-- yeni şehir ekleyelim
INSERT INTO Sehirler(Id, SehirAd) VALUES(17, N'Çanakkale');

-- çoklu satır ekleme
INSERT INTO Sehirler(Id, SehirAd) VALUES
(65, N'Van'),(25, N'Erzurum'),(48, N'Muğla');


-- yeni şehir ekleyelim
INSERT INTO Sehirler(Id, SehirAd) VALUES(99, N'New York');

-- veri silme
DELETE FROM Sehirler WHERE Id = 99;
