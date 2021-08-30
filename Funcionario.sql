Create Table Funcionario(
Id_Funci Integer Primary Key identity(1,1),
Nome_Funcionario Varchar(25) NOT NULL,
Cargo Varchar (30) not null,
CPF varchar(15) NOT NULL,
CEP varchar(15) not null,
Sexo Varchar(10) NOT NULL,
email varchar(25) not null,
Data_Nascimento Varchar(15) not null,
Salario money not null,
Condição Varchar(10) default ('Ativo'),
senha_login varchar(15) not null);

insert into Funcionario values('Daniel','Gerente','150.789.177-64','60440-5500','Masculino','daniel@gmail.com','09/07/1997',5000,default,'mito51');
insert into Funcionario values('João','Vendedor','136.580.717-70','63133-7280','Masculino','joão@gmail.com','03/01/1998',1000,'Desativado','guvia3.0');
insert into Funcionario values('Alexandre','Estoquista','033.746.017-58','61917-3550','Masculino','alexandre@gmail.com','04/05/1996',1100,default,'potuga13');

Select * from Funcionario where Nome_Funcionario = 'Daniel' and CPF = '150.789.177-64' and CEP = '60440-5500' and Sexo = 'Masculino' and email = 'daniel@gmail.com' and Data_Nascimento = '09/07/1997'

