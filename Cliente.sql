Create Table Cliente(
Id_cliente integer Primary Key identity(1,1),
Nome_Cliente Varchar(25) NOT NULL,
CPF varchar(50) NOT NULL,
CEP varchar(10) not null,
Sexo Varchar(10) NOT NULL,
Data_Nascimento Varchar(12) Not null,
email varchar (50)not null,
)

Insert into cliente values ('Daniel','310.036.957-28','62051-420','masculino','09/08/1997','sla@gmail.com');

Select * From Cliente Select * from Fornecedor;
