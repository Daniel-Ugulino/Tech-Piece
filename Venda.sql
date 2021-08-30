Create Table Venda (
Cod_Venda integer Primary Key identity (1,1),
peça_venda integer not null,
foreign key (peça_venda) references produto(id_p),
qtd integer not null,
Data_Venda varchar (12) not null,
id_cliente integer not null,
foreign key (id_cliente) references Cliente (id_cliente),
id_funcionario integer not null,
foreign key (id_funcionario) references Funcionario (Id_funci),
forma_de_pagamento varchar (12)
);

insert into venda values('1','1','02/02/2019','1','1','Débito');

select Cod_Venda,peça_venda,venda.qtd,Data_Venda,cliente.nome_cliente,funcionario.nome_funcionario,forma_de_pagamento,(venda.qtd * produto.valor) as Valor_Total from venda inner join produto on venda.peça_venda = produto.id_p inner join cliente on venda.id_cliente = cliente.id_cliente inner join funcionario on venda.id_funcionario = funcionario.Id_funci;






