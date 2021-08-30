using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Banco_de_Dados
{
    public class Comandos
    {

        static string nomepc = Environment.MachineName.ToString();

        public static SqlConnection conn = new SqlConnection("Data Source="+nomepc+"\\SQLEXPRESS;Initial Catalog=master;Trusted_Connection=True;");

        public void Banco()
        {
            conn.Open();

            SqlCommand Forne = new SqlCommand("Create Table Fornecedor" +
                "(Id_For integer primary key identity(1, 1)," +
                "Nome_Fornecedor varchar(30)," +
                "CNPJ varchar(18) NOT NULL," +
                "CEP varchar(10) not null," +
                "email varchar(40)not null," +
                ");" +
                "insert into fornecedor values('Asus', '83.795.683/0001-48', '63020-340', 'asus_oficial@gmail.com');" +
                "insert into fornecedor values('Officer','18.505.836/0001-03','83203-480','officeer@hotmail.com');" +
                "insert into fornecedor values('Districomp','66.896.647/0001-51','90240-020','districomp@gmail.com');" +
                "insert into fornecedor values('Mazer','52.071.025/0001-80','69307-715','Mazer@linkedin.com');" +
                "insert into fornecedor values('SND','02.101.894/0001-31','06472-001','SND@Yahoo.com');" +
                "insert into fornecedor values('NAGEM','32.955.832/0001-58','24723-255','atendimento.loja@nagem.com.br');" +
                "insert into fornecedor values('TechData','83.863.477/0001-28','27197-000','Techdata@gmail.com');" +
                "insert into fornecedor values('Abano','02.665.629/0001-86','68908-405','Abano@hotmail');" +
                "insert into fornecedor values('All Nations','50.774.419/0001-79','40231-120','AllNations@gmail.com');" +
                "insert into fornecedor values('Bell MicroProducts','42.557.061/0001-02','60875-075','BellMciroProducts@gmail.com');", conn);


            SqlCommand Clie = new SqlCommand("Create Table Cliente(" +
                "Id_cliente integer Primary Key identity(1, 1)," +
                "Nome_Cliente Varchar(25) NOT NULL," +
                "CPF varchar(50) NOT NULL," +
                "CEP varchar(10) not null," +
                "Sexo Varchar(10) NOT NULL," +
                "Data_Nascimento Varchar(12) Not null," +
                "email varchar(50)not null," +
                ");" +
                "Insert into cliente values('Daniel', '310.036.957-28', '62051-420', 'masculino', '09/08/1997', 'sla@gmail.com');", conn);

            SqlCommand Funci = new SqlCommand("Create Table Funcionario(" +
                "Id_Funci Integer Primary Key identity(1, 1)," +
                "Nome_Funcionario Varchar(25) NOT NULL," +
                "Cargo Varchar(30) not null," +
                "CPF varchar(15) NOT NULL," +
                "CEP varchar(15) not null," +
                "Sexo Varchar(10) NOT NULL," +
                "email varchar(25) not null," +
                "Data_Nascimento Varchar(15) not null," +
                "Salario money not null," +
                "Condição Varchar(10) default('Ativo')," +
                "senha_login varchar(15) not null);" +
                "insert into Funcionario values('Daniel','Gerente','150.789.177-64','60440-5500','Masculino','daniel@gmail.com','09/07/1997',5000,default,'mito51');" +
                " insert into Funcionario values('João','Vendedor','136.580.717-70','63133-7280','Masculino','joão@gmail.com','03/01/1998',1000,'Desativado','guvia3.0');" +
                "insert into Funcionario values('Alexandre','Estoquista','033.746.017-58','61917-3550','Masculino','alexandre@gmail.com','04/05/1996',1100,default,'potuga13');", conn);

            SqlCommand Produtos = new SqlCommand(
                "Create Table produto(id_p integer primary key not null identity(1, 1)," +
                "Marca varchar(30)not null," +
                "Tipo varchar(15) not null," +
                "modelo varchar(50)," +
                "especificação1 varchar(50)," +
                " especificação2 varchar(50)," +
                "especificação3 varchar(50)," +
                "Qtd integer not null," +
                "valor money not null," +
                "Data_Cadastro varchar(12) not null," +
                "id_F integer not null," +
                "foreign key(id_F) references Fornecedor(Id_for));" +
                "insert into produto values('AsRock','Placa-Mãe','A320M','AMD AM4','ATX','DDR4',10,350,'05/08/2019',1);" +
                "insert into produto values('AsRock','Placa-Mãe','H310M-HG4','Intel LGA 1151','mATX','DDR4',10,350,'05/08/2019',2);" +
                "insert into produto values('AsRock','Placa-Mãe','B450 Steel Legend','AMD AM4','ATX','DDR4',10,700,'05/08/2019',3);" +
                "insert into produto values('Gigabyte','Placa-Mãe','GA-B250-FinTech Mining','Intel LGA 1151','mATX','DDR4',10,350,'05/08/2019',4);" +
                "insert into produto values('Gigabyte','Placa-Mãe','B360 Aorus Gaming 3','Intel LGA 1151','ATX','DDR4',10,450,'05/08/2019',5);" +
                "insert into produto values('Asus','Placa-Mãe','TUF H310M-Plus Gaming/BR','Intel LGA 1151','mATX','DDR4',10,400,'05/08/2019',6);" +
                "insert into produto values('Asus','Placa-Mãe','Prime A320M-K','AMD AM4','mATX','DDR4',10,300,'05/08/2019',7);" +
                "insert into produto values('Asus','Placa-Mãe','ROG Strix B450-F Gaming','AMD AM4','ATX','DDR4',10,750,'05/08/2019',8);" +
                "insert into produto values('MSI','Placa-Mãe','B350M Pro-VH Plus','AMD AM4','mATX','DDR4',10,400,'05/08/2019',9);" +
                "insert into produto values('MSI','Placa-Mãe','Z390-A Pro','Intel LGA 1151','ATX','DDR4',10,700,'05/08/2019',10);" +
                "insert into produto values('Intel','Processador','Core i9-9900K','LGA 1151','Octa-Core','3.60 GHz (5.00 GHz Turbo Boost)',10,1500,'05/08/2019',7);" +
                "insert into produto values('Intel','Processador','Core i5 7400','LGA 1151','Quad-Core','3.0 GHZ (3.5 GHz Turbo Boost)',10,550,'05/08/2019',4);" +
                "insert into produto values('Intel','Processador','Core i3-8100','LGA 1151','Quad-Core','3.6GHz',10,900,'05/08/2019',3);" +
                "insert into produto values('Intel','Processador','Core i7-9700K','LGA1151','Octa-Core','3.60 GHz (4.90 Ghz Turbo Boost)',10,2000,'05/08/2019',1);" +
                "insert into produto values('Amd','Processador','AMD Ryzen 3 2200G','AM4','Quad Core','3.5GHz (3.7GHz Max Turbo)',10,350,'05/08/2019',2);" +
                "insert into produto values('Amd','Processador','AMD Ryzen 5 2400G','AM4','Six Core','3.6GHz (3.9GHz Max Turbo)',10,500,'05/08/2019',8);" +
                "insert into produto values('Amd','Processador','AMD Ryzen 5 1600','AM4','Six Core','3.2GHz (3.6GHz Max Turbo)',10,500,'05/08/2019',4);" +
                "insert into produto values('Amd','Processador','AMD Ryzen 7 2700X','AM4','Octa Core','3.7GHz (4.35GHz Max Turbo)',10,1000,'05/08/2019',6);" +
                "insert into produto values('HyperX','Memoria-Ram','Fury','16GB','DDR4','2400MHz',20,500,'05/08/2019',4);" +
                "insert into produto values('HyperX','Memoria-Ram','Fury','8GB','DDR4','2666MHz',20,200,'05/08/2019',4);" +
                "insert into produto values('HyperX','Memoria-Ram','Fury','4GB','DDR4','2400MHz',20,120,'05/08/2019',9);" +
                "insert into produto values('HyperX','Memoria-Ram','Fury RGB','8GB','DDR4','2400MHz',20,300,'05/08/2019',10);" +
                "insert into produto values('Adata','Memoria-Ram','XPG Spectrix','8GB','DDR4','3600MHz',20,400,'05/08/2019',6);" +
                "insert into produto values('Adata','Memoria-Ram','XPG Gammix D10','16GB','DDR4','2666MHz',20,450,'05/08/2019',4);" +
                "insert into produto values('Adata','Memoria-Ram','XPG Flame','4GB','DDR4','2666MHz',20,150,'05/08/2019',6);" +
                "insert into produto values('Corsair','Memoria-Ram','Vengeance LPX','8GB','DDR4','2400Mhz',20,200,'05/08/2019',2);" +
                "insert into produto values('Corsair','Memoria-Ram','Vengeance RGB Pro','16GB','DDR4','2666MHz',20,700,'05/08/2019',2);" +
                "insert into produto values('Corsair','Memoria-Ram','Dominator Platinum','16GB','DDR4','2666MHz',20,600,'05/08/2019',6);" +
                "insert into produto values('Corsair','Memoria-Ram','Vengeance LPX','4GB','DDR4','2400Mhz',20,150,'05/08/2019',4);" +
                "insert into produto values('Team-Group','Memoria-Ram','T-Force Vulcan Z','16GB','DDR4','2666MHz',20,450,'05/08/2019',2);" +
                "insert into produto values('Team-Group','Memoria-Ram','T-Force Night Hawk','8GB','DDR4','2666MHz',20,250,'05/08/2019',7);" +
                "insert into produto values('Cooler-Master','Fonte','MWE Gold','ATX','80 Plus Gold','550W',15,200,'05/08/2019',6);" +
                "insert into produto values('Cooler-Master','Fonte','Master MWE','ATX','80 Plus Gold','650W',15,250,'05/08/2019',3);" +
                "insert into produto values('Corsair','Fonte','CX','ATX','80 Plus Bronze','650W',15,250,'05/08/2019',3);" +
                "insert into produto values('Corsair','Fonte','CX','ATX','80 Plus Bronze','750W',15,350,'05/08/2019',9);" +
                "insert into produto values('Cougar','Fonte','VTE','ATX','80 Plus Bronze','400W',15,200,'05/08/2019',8);" +
                "insert into produto values('Cougar','Fonte','CMX V3','ATX','80 Plus Bronze','1000W',15,550,'05/08/2019',5);" +
                "insert into produto values('Evga','Fonte','100-W1-0600-K','ATX','80 Plus White','600W',15,200,'05/08/2019',4);" +
                "insert into produto values('Evga','Fonte','110-BQ-0750-V','ATX','80 Plus Bronze','750W',15,350,'05/08/2019',9);" +
                "insert into produto values('Toshiba','Hd','P300','1TB','3.5','SATA III',30,200,'05/08/2019',10);" +
                "insert into produto values('Seagate','Hd','BarraCuda','1TB','3.5','SATA III',30,200,'05/08/2019',1);" +
                "insert into produto values('Seagate','Hd','BarraCuda','2TB','3.5','SATA III',30,250,'05/08/2019',1);" +
                "insert into produto values('Western-Digital','Hd','Blue','1TB','3.5','SATA III',30,150,'05/08/2019',1);" +
                "insert into produto values('Western-Digital','Hd','WD Purple Surveillance','1TB','3.5','SATA III',30,200,'05/08/2019',5);" +
                "insert into produto values('Western-Digital','SSD','Green','240GB','SATA III','Leitura 545MB/s e Gravação 465MB/s',25,120,'05/08/2019',5);" +
                "insert into produto values('Western-Digital','SSD','Green','120GB','SATA III','Leitura 545MB/s e Gravação 430MB/s',25,100,'05/08/2019',5);" +
                "insert into produto values('Western-Digital','SSD','Green','480GB','SATA III','Leitura 545MB/s e Gravação 430MB/s',25,300,'05/08/2019',2);" +
                "insert into produto values('Corsair','SSD','Force LE 200','120GB','SATA III','Leitura 550MB/s e Gravação 500MB/s',25,150,'05/08/2019',7);" +
                "insert into produto values('Kingston','SSD','A400','120GB','SATA III','Leitura 500MB/s/s e Gravação 320MB/s',25,120,'05/08/2019',8);" +
                "insert into produto values('Kingston','SSD','A400','240GB','SATA III','Leitura 500MB/s e Gravação 350MB/s',25,300,'05/08/2019',8);" +
                "insert into produto values('Crucial','SSD','BX 500','120GB','SATA III','Leitura 540MB/s e Gravação 500MB/s',25,100,'05/08/2019',4);" +
                "insert into produto values('Adata','SSD-NVME','XPG Gammix S11 Pro','512GB','M.2 NVMe','Leitura 3500MB/s e Gravação 2300MB/s',20,450,'05/08/2019',2);" +
                "insert into produto values('Samsung','SSD-NVME','970 EVO Plus','500GB','M.2 NVMe','Leitura 3500MB/s e Gravação 3200MB/s',20,500,'05/08/2019',1);" +
                "insert into produto values('Crucial','SSD-NVME','P1','1TB','M.2 NVMe','Leitura 2000MB/s e Gravação 1700MB/s',20,600,'05/08/2019',10);" +
                "insert into produto values('Corsair','Gabinete','Gamer Crystal Series 460X','RGB','Vidro Temperado','ATX',15,600,'05/08/2019',10);" +
                "insert into produto values('Cooler-Master','Gabinete','Master MasterBox Q300P','3 Coolers','RGB','ATX',15,350,'05/08/2019',10);" +
                "insert into produto values('Thermaltake','Gabinete','CORE P3 SE Snow Edition','Lateral de Vidro','ATX','Torre média',15,550,'05/08/2019',10);" +
                "insert into produto values('SilverStone','Gabinete','Silverstone Primera Series','Vidro temperado','ATX','RGB',15,1000,'05/08/2019',5);" +
                "insert into produto values('Cooler-Master','Cooler','Hyper TX3 EVO','Intel e AMD','1 Cooler','120mm',15,100,'05/08/2019',5);" +
                "insert into produto values('PcYes','Cooler','Zero K Z2','Intel e AMD','1 Cooler','92 mm',30,50,'05/08/2019',7);" +
                "insert into produto values('DeepCool','Cooler','Gammaxx 300','Intel e AMD','1 Cooler','120 mm',30,50,'05/08/2019',3);" +
                "insert into produto values('Cooler-Master','WaterCooler','Masterliquid Lite 120','Intel e Amd','1 Coolers','120 mm',30,200,'05/08/2019',5);" +
                "insert into produto values('PCYes','WaterCooler','Nix','Intel e AMD','3 Coolers','360 mm',30,400,'05/08/2019',3);" +
                "insert into produto values('Galax','Placa-de-Video','NVIDIA GeForce','GTX 1660','6GB','GDDR5',20,1100,'05/08/2019',3);" +
                "insert into produto values('Galax','Placa-de-Video','NVIDIA GeForce','RTX 2060','6GB','GDDR6',20,1600,'05/08/2019',5);" +
                "insert into produto values('Gigabyte','Placa-de-Video','AMD Radeon','RX 580','8GB','GDDR5',20,1100,'05/08/2019',8);" +
                "insert into produto values('Gigabyte','Placa-de-Video','NVIDIA GeForce','RTX 2080','8GB','GDDR6',20,2400,'05/08/2019',7);" +
                "insert into produto values('Gigabyte','Placa-de-Video','AMD Radeon','RX 570 Gaming','8GB','GDDR5',20,800,'05/08/2019',2);" +
                "insert into produto values('MSI','Placa-de-Video','AMD Radeon','RX 580 Armor MK2','8GB','GDDR5',20,900,'05/08/2019',4);", conn);

            SqlCommand Venda = new SqlCommand("Create Table Venda (" +
                "Cod_Venda integer Primary Key identity(1, 1)," +
                "peça_venda integer not null," +
                "foreign key(peça_venda) references produto(id_p)," +
                "qtd integer not null," +
                "Data_Venda varchar(12) not null," +
                "id_cliente integer not null," +
                "foreign key(id_cliente) references Cliente(id_cliente)," +
                "id_funcionario integer not null," +
                "foreign key(id_funcionario) references Funcionario(Id_funci)," +
                "forma_de_pagamento varchar(12)" +
                ");" +
                "insert into venda values('1','1','02/02/2019','1','1','Débito');", conn);

            try
            {
                Forne.ExecuteNonQuery();
                Produtos.ExecuteNonQuery();
                Funci.ExecuteNonQuery();
                Clie.ExecuteNonQuery();
                Venda.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            conn.Close();
        }
    }
}
