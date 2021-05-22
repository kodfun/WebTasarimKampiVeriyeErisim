--CREATE DATABASE AdresDefteriDb;
--GO

USE AdresDefteriDb;

CREATE TABLE Adresler
(
	Id INT PRIMARY KEY IDENTITY,
	Ad NVARCHAR(50) NOT NULL,	
	Soyad NVARCHAR(50),
	Telefon NVARCHAR(15), 	
	Adres NVARCHAR(400)
);

INSERT INTO Adresler(Ad, Soyad, Telefon, Adres) VALUES
(N'Ali', N'Yılmaz', N'+905051234567', N'Çamlıca Mah.'),
(N'Ece', N'Şahin', N'+905351234567', N'Bahçelievler Mah.'),
(N'Can', N'Öz', N'+905451234567', N'Keçiören, Ankara');