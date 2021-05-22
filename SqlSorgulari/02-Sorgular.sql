CREATE DATABASE GirisDb;
GO

USE GirisDb;

CREATE TABLE Sehirler
(
	Id INT PRIMARY KEY,
	SehirAd NVARCHAR(50)
);

INSERT INTO Sehirler (Id, SehirAd) VALUES (1, N'Adana');
INSERT INTO Sehirler (Id, SehirAd) VALUES (2, N'Adıyaman');
INSERT INTO Sehirler (Id, SehirAd) VALUES (6, N'Ankara');
INSERT INTO Sehirler (Id, SehirAd) VALUES (7, N'Antalya');
INSERT INTO Sehirler (Id, SehirAd) VALUES (17, N'Çanakkale');
INSERT INTO Sehirler (Id, SehirAd) VALUES (21, N'Diyarbakır');
INSERT INTO Sehirler (Id, SehirAd) VALUES (23, N'Elazığ');
INSERT INTO Sehirler (Id, SehirAd) VALUES (25, N'Erzurum');
INSERT INTO Sehirler (Id, SehirAd) VALUES (26, N'Eskişehir');
INSERT INTO Sehirler (Id, SehirAd) VALUES (31, N'Hatay');
INSERT INTO Sehirler (Id, SehirAd) VALUES (34, N'İstanbul');
INSERT INTO Sehirler (Id, SehirAd) VALUES (35, N'İzmir');
INSERT INTO Sehirler (Id, SehirAd) VALUES (36, N'Kars');
INSERT INTO Sehirler (Id, SehirAd) VALUES (38, N'Kayseri');
INSERT INTO Sehirler (Id, SehirAd) VALUES (41, N'Kocaeli');
INSERT INTO Sehirler (Id, SehirAd) VALUES (42, N'Konya');
INSERT INTO Sehirler (Id, SehirAd) VALUES (44, N'Malatya');
INSERT INTO Sehirler (Id, SehirAd) VALUES (46, N'Kahramanmaraş');
INSERT INTO Sehirler (Id, SehirAd) VALUES (48, N'Muğla');
INSERT INTO Sehirler (Id, SehirAd) VALUES (51, N'Niğde');
INSERT INTO Sehirler (Id, SehirAd) VALUES (54, N'Sakarya');
INSERT INTO Sehirler (Id, SehirAd) VALUES (55, N'Samsun');
INSERT INTO Sehirler (Id, SehirAd) VALUES (58, N'Sivas');
INSERT INTO Sehirler (Id, SehirAd) VALUES (61, N'Trabzon');
INSERT INTO Sehirler (Id, SehirAd) VALUES (65, N'Van');
INSERT INTO Sehirler (Id, SehirAd) VALUES (76, N'Iğdır');
INSERT INTO Sehirler (Id, SehirAd) VALUES (80, N'Osmaniye');
INSERT INTO Sehirler (Id, SehirAd) VALUES (81, N'Düzce');

-- tüm şehirler
SELECT * FROM Sehirler;

-- toplam şehir sayısı
SELECT COUNT(*) FROM Sehirler;

-- ankara'yı angara yapalım
UPDATE Sehirler SET SehirAd = N'Angara' WHERE Id = 6;