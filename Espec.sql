Create Table produto(
id_p integer primary key not null identity (1,1),
Marca varchar(30)not null,
Tipo varchar(15) not null,
modelo varchar(50),
especificação1 varchar (50),
especificação2 varchar (50),
especificação3 varchar (50),
Qtd integer not null,
valor money not null,
Data_Cadastro varchar (12) not null,
id_F integer not null,
foreign key (id_F) references Fornecedor (Id_for));

insert into produto values ('AsRock','Placa-Mãe','A320M','AMD AM4','ATX','DDR4',10,350,'05/08/2019',1);
insert into produto values ('AsRock','Placa-Mãe','H310M-HG4','Intel LGA 1151','mATX','DDR4',10,350,'05/08/2019',2);
insert into produto values ('AsRock','Placa-Mãe','B450 Steel Legend','AMD AM4','ATX','DDR4',10,700,'05/08/2019',3);
insert into produto values ('Gigabyte','Placa-Mãe','GA-B250-FinTech Mining','Intel LGA 1151','mATX','DDR4',10,350,'05/08/2019',4);
insert into produto values ('Gigabyte','Placa-Mãe','B360 Aorus Gaming 3','Intel LGA 1151','ATX','DDR4',10,450,'05/08/2019',5);
insert into produto values ('Asus','Placa-Mãe','TUF H310M-Plus Gaming/BR','Intel LGA 1151','mATX','DDR4',10,400,'05/08/2019',6);
insert into produto values ('Asus','Placa-Mãe','Prime A320M-K','AMD AM4','mATX','DDR4',10,300,'05/08/2019',7);
insert into produto values ('Asus','Placa-Mãe','ROG Strix B450-F Gaming','AMD AM4','ATX','DDR4',10,750,'05/08/2019',8);
insert into produto values ('MSI','Placa-Mãe','B350M Pro-VH Plus','AMD AM4','mATX','DDR4',10,400,'05/08/2019',9);
insert into produto values ('MSI','Placa-Mãe','Z390-A Pro','Intel LGA 1151','ATX','DDR4',10,700,'05/08/2019',10);
insert into produto values ('Intel','Processador','Core i9-9900K','LGA 1151','Octa-Core','3.60 GHz (5.00 GHz Turbo Boost)',10,1500,'05/08/2019',7);
insert into produto values ('Intel','Processador','Core i5 7400','LGA 1151','Quad-Core','3.0 GHZ (3.5 GHz Turbo Boost)',10,550,'05/08/2019',4);
insert into produto values ('Intel','Processador','Core i3-8100','LGA 1151','Quad-Core','3.6GHz',10,900,'05/08/2019',3);
insert into produto values ('Intel','Processador','Core i7-9700K','LGA1151','Octa-Core','3.60 GHz (4.90 Ghz Turbo Boost)',10,2000,'05/08/2019',1);
insert into produto values('Amd','Processador','AMD Ryzen 3 2200G','AM4','Quad Core','3.5GHz (3.7GHz Max Turbo)',10,350,'05/08/2019',2);
insert into produto values('Amd','Processador','AMD Ryzen 5 2400G','AM4','Six Core','3.6GHz (3.9GHz Max Turbo)',10,500,'05/08/2019',8);
insert into produto values('Amd','Processador','AMD Ryzen 5 1600','AM4','Six Core','3.2GHz (3.6GHz Max Turbo)',10,500,'05/08/2019',4);
insert into produto values('Amd','Processador','AMD Ryzen 7 2700X','AM4','Octa Core','3.7GHz (4.35GHz Max Turbo)',10,1000,'05/08/2019',6);
insert into produto values('HyperX','Memoria-Ram','Fury','16GB','DDR4','2400MHz',20,500,'05/08/2019',4);
insert into produto values('HyperX','Memoria-Ram','Fury','8GB','DDR4','2666MHz',20,200,'05/08/2019',4);
insert into produto values('HyperX','Memoria-Ram','Fury','4GB','DDR4','2400MHz',20,120,'05/08/2019',9);
insert into produto values('HyperX','Memoria-Ram','Fury RGB','8GB','DDR4','2400MHz',20,300,'05/08/2019',10);
insert into produto values('Adata','Memoria-Ram','XPG Spectrix','8GB','DDR4','3600MHz',20,400,'05/08/2019',6);
insert into produto values('Adata','Memoria-Ram','XPG Gammix D10','16GB','DDR4','2666MHz',20,450,'05/08/2019',4);
insert into produto values('Adata','Memoria-Ram','XPG Flame','4GB','DDR4','2666MHz',20,150,'05/08/2019',6);
insert into produto values('Corsair','Memoria-Ram','Vengeance LPX','8GB','DDR4','2400Mhz',20,200,'05/08/2019',2);
insert into produto values('Corsair','Memoria-Ram','Vengeance RGB Pro','16GB','DDR4','2666MHz',20,700,'05/08/2019',2);
insert into produto values('Corsair','Memoria-Ram','Dominator Platinum','16GB','DDR4','2666MHz',20,600,'05/08/2019',6);
insert into produto values('Corsair','Memoria-Ram','Vengeance LPX','4GB','DDR4','2400Mhz',20,150,'05/08/2019',4);
insert into produto values('Team-Group','Memoria-Ram','T-Force Vulcan Z','16GB','DDR4','2666MHz',20,450,'05/08/2019',2);
insert into produto values('Team-Group','Memoria-Ram','T-Force Night Hawk','8GB','DDR4','2666MHz',20,250,'05/08/2019',7);
insert into produto values ('Cooler-Master','Fonte','MWE Gold','ATX','80 Plus Gold','550W',15,200,'05/08/2019',6);
insert into produto values ('Cooler-Master','Fonte','Master MWE','ATX','80 Plus Gold','650W',15,250,'05/08/2019',3);
insert into produto values('Corsair','Fonte','CX','ATX','80 Plus Bronze','650W',15,250,'05/08/2019',3);
insert into produto values('Corsair','Fonte','CX','ATX','80 Plus Bronze','750W',15,350,'05/08/2019',9);
insert into produto values('Cougar','Fonte','VTE','ATX','80 Plus Bronze','400W',15,200,'05/08/2019',8);
insert into produto values('Cougar','Fonte','CMX V3','ATX','80 Plus Bronze','1000W',15,550,'05/08/2019',5);
insert into produto values('Evga','Fonte','100-W1-0600-K','ATX','80 Plus White','600W',15,200,'05/08/2019',4);
insert into produto values('Evga','Fonte','110-BQ-0750-V','ATX','80 Plus Bronze','750W',15,350,'05/08/2019',9);
insert into produto values('Toshiba','Hd','P300','1TB','3.5','SATA III',30,200,'05/08/2019',10);
insert into produto values('Seagate','Hd','BarraCuda','1TB','3.5','SATA III',30,200,'05/08/2019',1);
insert into produto values('Seagate','Hd','BarraCuda','2TB','3.5','SATA III',30,250,'05/08/2019',1);
insert into produto values('Western-Digital','Hd','Blue','1TB','3.5','SATA III',30,150,'05/08/2019',1);
insert into produto values('Western-Digital','Hd','WD Purple Surveillance','1TB','3.5','SATA III',30,200,'05/08/2019',5);
insert into produto values('Western-Digital','SSD','Green','240GB','SATA III','Leitura 545MB/s e Gravação 465MB/s',25,120,'05/08/2019',5);
insert into produto values('Western-Digital','SSD','Green','120GB','SATA III','Leitura 545MB/s e Gravação 430MB/s',25,100,'05/08/2019',5);
insert into produto values('Western-Digital','SSD','Green','480GB','SATA III','Leitura 545MB/s e Gravação 430MB/s',25,300,'05/08/2019',2);
insert into produto values('Corsair','SSD','Force LE 200','120GB','SATA III','Leitura 550MB/s e Gravação 500MB/s',25,150,'05/08/2019',7);
insert into produto values('Kingston','SSD','A400','120GB','SATA III','Leitura 500MB/s/s e Gravação 320MB/s',25,120,'05/08/2019',8);
insert into produto values('Kingston','SSD','A400','240GB','SATA III','Leitura 500MB/s e Gravação 350MB/s',25,300,'05/08/2019',8);
insert into produto values('Crucial','SSD','BX 500','120GB','SATA III','Leitura 540MB/s e Gravação 500MB/s',25,100,'05/08/2019',4);
insert into produto values('Adata','SSD-NVME','XPG Gammix S11 Pro','512GB','M.2 NVMe','Leitura 3500MB/s e Gravação 2300MB/s',20,450,'05/08/2019',2);
insert into produto values('Samsung','SSD-NVME','970 EVO Plus','500GB','M.2 NVMe','Leitura 3500MB/s e Gravação 3200MB/s',20,500,'05/08/2019',1);
insert into produto values('Crucial','SSD-NVME','P1','1TB','M.2 NVMe','Leitura 2000MB/s e Gravação 1700MB/s',20,600,'05/08/2019',10);
insert into produto values('Corsair','Gabinete','Gamer Crystal Series 460X','RGB','Vidro Temperado','ATX',15,600,'05/08/2019',10);
insert into produto values('Cooler-Master','Gabinete','Master MasterBox Q300P','3 Coolers','RGB','ATX',15,350,'05/08/2019',10);
insert into produto values('Thermaltake','Gabinete','CORE P3 SE Snow Edition','Lateral de Vidro','ATX','Torre média',15,550,'05/08/2019',10);
insert into produto values('SilverStone','Gabinete','Silverstone Primera Series','Vidro temperado','ATX','RGB',15,1000,'05/08/2019',5);
insert into produto values('Cooler-Master','Cooler','Hyper TX3 EVO','Intel e AMD','1 Cooler','120mm',15,100,'05/08/2019',5);
insert into produto values('PcYes','Cooler','Zero K Z2','Intel e AMD','1 Cooler','92 mm',30,50,'05/08/2019',7);
insert into produto values('DeepCool','Cooler','Gammaxx 300','Intel e AMD','1 Cooler','120 mm',30,50,'05/08/2019',3);
insert into produto values('Cooler-Master','WaterCooler','Masterliquid Lite 120','Intel e Amd','1 Coolers','120 mm',30,200,'05/08/2019',5);
insert into produto values('PCYes','WaterCooler','Nix','Intel e AMD','3 Coolers','360 mm',30,400,'05/08/2019',3);
insert into produto values('Galax','Placa-de-Video','NVIDIA GeForce','GTX 1660','6GB','GDDR5',20,1100,'05/08/2019',3);
insert into produto values('Galax','Placa-de-Video','NVIDIA GeForce','RTX 2060','6GB','GDDR6',20,1600,'05/08/2019',5);
insert into produto values('Gigabyte','Placa-de-Video','AMD Radeon','RX 580','8GB','GDDR5',20,1100,'05/08/2019',8);
insert into produto values('Gigabyte','Placa-de-Video','NVIDIA GeForce','RTX 2080','8GB','GDDR6',20,2400,'05/08/2019',7);
insert into produto values('Gigabyte','Placa-de-Video','AMD Radeon','RX 570 Gaming','8GB','GDDR5',20,800,'05/08/2019',2);
insert into produto values('MSI','Placa-de-Video','AMD Radeon','RX 580 Armor MK2','8GB','GDDR5',20,900,'05/08/2019',4);


select  id_p,Marca,Tipo,modelo,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto 
inner join Fornecedor on produto.id_F = Fornecedor.Id_For;
