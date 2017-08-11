Create Database Estacionamento;


Create Table Polimento(
	Id	int Not null auto_increment comment 'Codigo de indentificação do polimento',
	descri	Text Not Null  comment 'Texto explicando sobre o polimento.',
	primary key (id)
);
Create Table Lavagem(
	Id	int Not null auto_increment comment 'Codigo de indentificação da Lavagem',
	tipo	text Not Null  comment 'Texto explicando sobre a Lavagem.',
	primary key (id)
);
Create Table TrocaOleo(
	Id	int Not Null auto_increment comment 'Código da troca de oleo.' ,
	Tipo  text Not Null  comment 'Texto explicando sobre a Troca de oleo.',
	primary key (id)
);
Create Table Alinhamento(
	Id	int Not null auto_increment comment 'Código do alinhamento.'
	Descri	text Not Null  comment 'Texto explicando sobre o alinhamento.',
	primary key (id)
);

Create Table Balanceamento(
	Id	int Not null auto_increment comment 'Código do balanceamento.'
	Descri	text Not Null  comment 'Texto explicando sobre o balanceamento.',
	primary key (id)
);

Create Table Funcionario(
	Numero_funcionario	int not null auto_increment comment 'Numeração do funcionario',
	Sexo	varChar(1) not null comment comment 'Sexo do Funcionario (M - Masculino | F - Feminino).'
	cpf varchar(11) not null comment 'Cpf do funcionario.',
	Nome	Varchar(80) not null comment 'Nome completo do funcionario',
	Salario	double not null comment 'Salario do funcionario',
	Cod_lava	int not null comment 'Código da lavagem.',
	Cod_alinha	int not null comment 'Código do alinhamento.',
	Cod_troca	int not null comment 'Código da troca de oleo.',
	Cod_balan	int not null comment 'Código do balanceamento.',
	Cod_poli	int not null comment 'Código do polimento.',
	Primary Key (cpf),
	foreign key (Cod_lava) references lavagem(id),
	foreign key (Cod_poli) references polimento(id),	
	foreign key (Cod_troca) references TrocaOleo(id),
	foreign key (Cod_balan) references balanceamento(id),
	foreign key (Cod_alinha) references alinhamento(id)
);

Create Table Cliente(
	Nome	Varchar(80) not null comment 'Nome do cliente',
	Cpf	Varchar(11) not null comment 'cpf do cliente ',
	telefone	Varchar(23) not null comment 'telefone do cliente',
	numero int not null comment 'Numero de indentificação do funcionario.',
	primary key (cpf),
	foreign key (numero) references Funcionario(numero)
);

Create Table Carro(
	placa	Varchar(10) not null comment 'Placa do carro.',
	marca	Varchar(30) not null comment 'Nome da marca do carro.',
	nome	Varchar(50) not null comment 'Nome do modelo do carro.',
	Cod_lava	int not null comment 'Código da lavagem.',
	Cod_alinha	int not null comment 'Código do alinhamento.',
	Cod_troca	int not null comment 'Código da troca de oleo.',
	Cod_balan	int not null comment 'Código do balanceamento.',
	Cod_poli	int not null comment 'Código do polimento.',
	Primary Key (placa),
	foreign key (Cod_lava) references lavagem(id),
	foreign key (Cod_poli) references polimento(id),	
	foreign key (Cod_troca) references TrocaOleo(id),
	foreign key (Cod_balan) references balanceamento(id),
	foreign key (Cod_alinha) references alinhamento(id)
);

Create Table Fun_carro(
	Codigo	int not null auto_increment comment 'Codigo de indentificação do funcionario-carro',
	Numero	int not null comment 'Numeração do funcionario',
	placa	Varchar(10) not null comment 'Placa do carro.',
	primary key (codigo),
	foreign key (numero) references funcionario(numero),
	foreign key (placa) references carro(placa)
);

/* -- Consultas --  */
/* -- todos os dados Carro -- */
Select *
from carro

/* -- dados Carro LIKE -- */
Select nome
from carro
where marca like 'BMW'

/* -- dados Funcionario BETWEEN -- */
Select nome,sexo
from funcionario
where salario between 1000 and 2000

/* -- mais de uma tabela -- */

Select Cliente.nome,Carro.placa
from Cliente,carro
where Cliente.placa = Carro.Placa

/* -- todas as tabela -- */

Select Cliente.nome,Cliente.cpf,Carro.placa,TrocaOleo.id,lavagem.id,Polimento.id,Balanceamento.id,Alinhamento.id
from cliente,carro,TrocaOleo,Levagem,Polimento,Balanceamento,Alinhamento,fun_carro
where Cliente.numero = Funcionario.numero And
Funcionario.numero = Fun_carro.numero And
Fun_carro.placa = Carro.placa And 
funcionario.cod_lava = Lavagem.id and
Funcionario.cod_alinha = Alinhamento.id And
Funcionario.cod_balan = balanceamento.id And
Funcionario.cod_poli = Polimento.id And
funcionario.cod_troca = TrocaOleo.id And
Carro.cod_lava = Lavagem.id and
Carro.cod_alinha = Alinhamento.id And
Carro.cod_balan = balanceamento.id And
Carro.cod_poli = Polimento.id And
Carro.cod_troca = TrocaOleo.id And
Carro.placa = Cliente.placa
