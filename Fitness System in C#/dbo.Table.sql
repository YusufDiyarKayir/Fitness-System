CREATE TABLE [dbo].[kayitTbl]
(
	[KayıtId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [KayıtAdSoyad] VARCHAR(50) NOT NULL, 
    [KayıtYas] INT NOT NULL, 
    [KayıtKilo] INT NOT NULL, 
    [KayıtBoy] INT NOT NULL, 
    [KayıtKanGrubu] VARCHAR(50) NOT NULL, 
    [KayıtAylıkTutar] INT NOT NULL, 
    [KayıtAmacı] VARCHAR(50) NOT NULL, 
    [KayıtAnternör] VARCHAR(50) NOT NULL, 
    [KayıtHastalık] VARCHAR(50) NOT NULL, 
    [KayıtÜyelik] VARCHAR(50) NOT NULL, 
    [KayıtCinsiyet] VARCHAR(50) NOT NULL, 
    [KayıtSaat] VARCHAR(50) NOT NULL
)
