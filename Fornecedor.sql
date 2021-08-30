
Create Table Fornecedor(
Id_For integer primary key identity (1,1),
Nome_Fornecedor varchar(30),
CNPJ varchar(18) NOT NULL,
CEP varchar(10) not null,
email varchar (40)not null,
)

insert into fornecedor values('Asus','83.795.683/0001-48','63020-340','asus_oficial@gmail.com');
insert into fornecedor values('Officer','18.505.836/0001-03','83203-480','officeer@hotmail.com');
insert into fornecedor values('Districomp','66.896.647/0001-51','90240-020','districomp@gmail.com');
insert into fornecedor values('Mazer','52.071.025/0001-80','69307-715','Mazer@linkedin.com');
insert into fornecedor values('SND','02.101.894/0001-31','06472-001','SND@Yahoo.com');
insert into fornecedor values('NAGEM','32.955.832/0001-58','24723-255','atendimento.loja@nagem.com.br');
insert into fornecedor values('TechData','83.863.477/0001-28','27197-000','Techdata@gmail.com');
insert into fornecedor values('Abano','02.665.629/0001-86','68908-405','Abano@hotmail');
insert into fornecedor values('All Nations','50.774.419/0001-79','40231-120','AllNations@gmail.com');
insert into fornecedor values('Bell MicroProducts','42.557.061/0001-02','60875-075','BellMciroProducts@gmail.com');
select * from Fornecedor;