Create Database VSKY;

Create Table Departamento(
	Id	int Not null auto_increment comment 'Código de identificação do departamento',
	nome	Varchar(50) Not null comment 'Nome do departamento',
	Cpf	Varchar(11)  Not null comment 'Cpf do funcionário do departamento.',
	Primary key (id)
);

Create Table Projeto(
	Codigo	int Not null auto_increment comment 'Codigo de identificação do projeto.',
	Custo	double  Not null comment 'Custo total do projeto.',
	Prazo	date  Not null comment 'Data do termino do projeto.',
	Descri	Text  Not null comment 'Texto descritivo sobre o projeto.',
	titulo	Varchar(40) Not null comment 'Nome do projeto.',
	Primary Key (Codigo)	
);
Create Table Funcionario(
	cpf	Varchar(11)  Not null comment 'Cpf do funcionário',
	Nome	Varchar(80)  Not null comment 'Nome do funcionário.',
	Área	Varchar(30)  Not null comment 'Area de atuação do funcionário.',
	Salario	double  Not null comment 'Salario atual do funcionário.',
	Endereço	Varchar(60)  Not null comment 'endereço do funcionario',
	Carteira	Varchar(20)  Not null comment 'Carteira de motorista.',
	Id_contrato	int  Not null auto_increment comment 'Código do contrato do funcionário',
	Cargo	Varchar(25)  Not null comment 'Cargo profissional do funcionário',
	Especialidade	Varchar(20)  Not null comment 'Especialidade do funcionario',
	Fone	Varchar(23)  Not null comment 'Telefone do funcionário.',
	Contratação	Date  Not null comment 'Data de contratação do funcionario',
	Validade_contrato	Date  Not null comment 'Data do termino da contratação do funcionario',
	Primary Key (cpf)
	
);

Create Table Cliente(
	cpf	Varchar(11) not null comment 'Cpf do cliente.',
	Telefone	Varchar(23) not null comment 'Telefone do cliente',
	Nome	Varchar(80) not null comment 'Nome completo do cliente',
	cpf_funcionario Varchar(11) not null comment 'cpf do funcionario',
	Primary Key(cpf),
	Foreign Key(cpf_funcionario) references funcionario(cpf)
);

Create Table Veiculo(
	Placa	Varchar(18) not null comment 'Placa do veiculo',
	Cor	Varchar(22) not null comment 'Cor respectiva do automóvel.',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário que utiliza o veiculo.',
	Ano	date  not null comment 'Ano de fabricação do veiculo.',
	Primary key (Placa),
	Foreign Key(Cpf) References Funcionario(cpf)
);


Create Table Func_pro(
	Id	int Not Null auto_increment comment 'Codigo de identificação da função do projeto.',
	Cpf	Varchar(11) Not Null comment 'Cpf do funcionário.',
	Id_pro	int Not Null comment 'Codigo de identificação do projeto.',
	Primary Key (id),
	Foreign Key(Cpf) References Funcionario(cpf),
	Foreign Key(Id_pro) References Projeto(codigo)
);





/* -- Consultas --  */
/* -- todos os dados funcionario -- */
Select *
from Funcionario

/* -- dados funcionario LIKE -- */
Select nome,salario
from Funcionario
where nome like 'João%'

/* -- dados funcionario BETWEEN -- */
Select nome,salario
from Funcionario
where salario BETWEEN 800 and 1500

/* -- mais de uma tabela -- */
Select Funcionario.Nome,Projeto.titulo
from Funcionario,func_pro,Projeto
where Funcionario.cpf = func_pro.cpf And
func_pro.id_pro = Projeto.Codigo

/* -- todas as tabela -- */
Select Funcionario.nome,Departamento.nome,Projeto.titulo,Veiculo.placa,Cliente.nome
from Funcionario,Departamento,Projeto,Veiculo,Func_pro,Cliente
where Departamento.cpf = Funcionario.cpf And
Funcionario.cpf = Cliente.cpf_funcionario AND
Funcionario.cpf = func_pro.cpf And
Funcionario.cpf = Veiculo.cpf AND
func_pro.id_pro = Projeto.codigo
