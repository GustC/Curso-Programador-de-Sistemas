Create DATABASE Locadora;


Create TABLE funcionario(
	cpf varchar(11) not null comment 'Chave primaria' ,
	nome varchar(100) not null comment 'Nome completo do funcionario',
	endereco varchar(200) not null comment 'Endereço completo do funcionario' ,
	sexo varchar(1) not null comment 'Sexo do funcionario M - masculi & F - Feminino' ,
	telefone varchar(20) not null comment 'telefone do funcionario',
	email varchar(50) null comment 'Email do funcionario',
	salario double not null comment 'Salario do funcionario',
	data_de_nascimento date not null comment 'Data de nascimento do funcionario',
	Primary KEY (cpf)
);

Create TABLE Filme(
	id int not null auto_increment comment 'Chave primaria' , 
	categoria varchar(50) not null comment 'categoria do filme' ,
	titulo varchar(100) not null comment 'Titulo do filme',
	duracao time not null comment 'Duração do filme',
	cpf varchar(11) not null comment 'Chave extrangeira' ,
	Primary Key (id),
	Foreign Key (cpf) REFERENCES funcionario(cpf)
);

Create TABLE Ator(
	id int not null auto_increment comment 'Código de indetificação do ator.',
	nome Varchar(100) Not null comment 'Nome completo do funcionário.',
	Sexo Varchar(1) not null comment 'Sexo do funcionário (M – masculino | F - Feminino).',
	Data_de_nascimento date not null comment 'Data de nascimento do ator.',
	Primary Key (id)
);

Create TABLE Func_fil(
	Id_ator int not null comment 'Codigo de indetificação do ator',
	codigo int not null auto_increment comment 'Chave primaria' ,
	Id_filme Int not null comment 'Id do filme'	,
	Primary Key (codigo),
	Foreign key (Id_ator)REFERENCES Ator(id),
	Foreign key (Id_filme)REFERENCES Filme(id)
);
/* --  */
Create Table Reserva(
	Id	int	not null auto_increment comment 'Codigo indentificador  da reserva.',
	Data_efetuada	Date not null comment 'Data do inicio da reserva.',
	Data_reserva	date not null comment 'Data do termino da reserva.', 
	Primary Key (id)
);

Create Table Cliente(
	numero	int not null comment 'Número de identificação do cliente.',
	Endereço	Varchar(80) not null comment 'Endereço do cliente.',
	Telefone	Varchar(23) not null comment 'Telefone do cliente.',
	Nome	Varchar(100) not null comment 'Nome completo do cliente.',
	dependente	Varchar(100) not null comment 'Nome do dependente, se possuir.',
	Id_reserva	Int not null comment 'Numero identificador da reserva.',
	cpf varchar(11) not null comment 'Cpf do funcionario responsavel pelo cadastro' , 
	Primary key (numero),
	FOREIGN key (cpf) REFERENCES funcionario(cpf),
	FOREIGN key (Id_reserva) REFERENCES Reserva(Id)
);

Create Table Locacao(
	Id	int not null auto_increment comment 'Codigo indentificador  da locação.',
	quantidade	Int not null comment 'Quantidade de filmes alocados pelo cliente.',
	numero Int not null comment 'Número de identificação do cliente.',
	Primary Key (id),
	Foreign Key (numero) REFERENCES Cliente(numero)
);

Create Table func_alocar(
	Id_loca	Int Not null comment 'Id da locação',
	codigo	int	Not null auto_increment comment 'chave primaria',
	Id_filme  Int Not null comment 'id do filme',
	Primary Key (codigo),
	Foreign key (Id_loca)REFERENCES Locacao(Id),
	Foreign key (Id_filme)REFERENCES Filme(Id)
);

insert into funcionario(cpf,nome,endereco,sexo,telefone,salario)
values('01791995530','Jão','joao de barros','M','98800-3500',3500);

insert into filme(categoria,titulo,duracao,cpf)
values('Comedia','Hora do Rush','2:30','01791995530');

/* -- Consultas -- */

/* -- Todas os dados de Reservas -- */
Select *
from Reserva
/* -- Dados Ator LIKE -- */
Select nome
from ator
where nome like '%Nascimento%'
/* -- Dados reserva BETWEEN -- */ 
select id
from Reserva
where data_efetuada between '2017-01-01' and '2017-03-01'

/* -- mais de uma tabela -- */
select Filme.titulo,Ator.nome 
from Funcionario,filme,ator,func_fil
where Funcionario.cpf = Filme.cpf and
Filme.id = func_fil.id_filme and
Func_fil.id_ator = Ator.id

/* -- Todas as tabelas -- */

Select Cliente.nome,Filme.titulo,Reserva.data_efetuada, Reserva.data_reserva,Locacao.numero
from Funcionario,filme,ator,func_fil,Reserva,func_alocar,Locacao,Cliente
where Funcionario.cpf = Filme.cpf and
Filme.id = func_fil.id_filme and
Func_fil.id_ator = Ator.id and
filme.id = func_alocar.id_filme and
func_alocar.id_loca = Locacao.id and
Funcionario.cpf = Cliente.cpf and
Cliente.id_reserva = Reserva.id and
Locacao.numero = Cliente.numero



