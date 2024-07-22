CREATE TABLE tFakulte (
    fakulteID INT PRIMARY KEY,
    fakulteAd VARCHAR(100) NOT NULL
);

CREATE TABLE tBolum (
    bolumID INT PRIMARY KEY,
    bolumAd VARCHAR(100) NOT NULL,
    fakulteID INT,
    FOREIGN KEY (fakulteID) REFERENCES tFakulte(fakulteID)
);

CREATE TABLE tOgrenci (
    ogrenciID INT PRIMARY KEY,
    ad VARCHAR(100) NOT NULL,
    soyad VARCHAR(100) NOT NULL,
    bolumID INT,
    FOREIGN KEY (bolumID) REFERENCES tBolum(bolumID)
);

CREATE TABLE tDers (
    dersID INT PRIMARY KEY,
    dersAd VARCHAR(100) NOT NULL
);

CREATE TABLE tOgrenciDers (
    ogrenciID INT,
    dersID INT,
    yil VARCHAR(10), -- yýl VARCHAR olarak tanýmlandý
    yariyil VARCHAR(10), -- yarýyýl VARCHAR olarak tanýmlandý
    vize INT,
    final INT,
    PRIMARY KEY (ogrenciID, dersID),
    FOREIGN KEY (ogrenciID) REFERENCES tOgrenci(ogrenciID),
    FOREIGN KEY (dersID) REFERENCES tDers(dersID)
);