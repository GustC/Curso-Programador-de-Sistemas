create DATABASE imobiliaria;

create TABLE Predio(
	id	int Not null auto_increment comment 'Código de identificação do prédio.',
	numero	Int Not null comment 'Numero do prédio.',
	nome	Varchar(50) Not null comment 'Nome do edifício.',
	complemento	Text not null comment 'Texto com complemento para a localização do edifício. ',
	Primary key(id)
);

create TABLE Apartamento(
	numero	int Not null auto_increment comment 'Número de identificação do apartamento',
	andar	int Not null comment 'Número do andar onde se encontra o apartamento.',
	custo	double Not null comment 'Custo do apartamento.',
	Id_predio	Int Not null  comment 'Código de identificação do prédio.',
	Primary Key(numero),
	FOREIGN Key(Id_predio) REFERENCES Predio(id)

);

create TABLE Pessoa(
	cpf	Varchar(11) Not null comment 'Cpf do Residente',
	nome	Varchar(80) Not null comment 'Nome completo da pessoa.',
	Sexo	varchar(1) Not null comment 'Sexo da pessoa (M – masculino | F - Feminino).',
	Data_de_nascimento	date Not null comment 'Data de nascimento da pessoa (mm/dd/aaaa).',
	Telefone	Varchar(23) Not null comment 'Telefone para contato com a pessoa.',
	Email	Varchar(50) null comment 'Email comercial da pessoa.',
	id_predio	Int Not null comment 'Código de identificação do prédio.',
	Numero	Int Not null comment 'Numero do apartamento.',
	Primary key(cpf),
	Foreign Key(id_predio) REFERENCES Predio(id),
	Foreign Key(Numero) REFERENCES Apartamento(numero)	
	
);

create Table Proprietario(
	cpf	Varchar(11) Not null comment 'Cpf do proprietário',
	nome	Varchar(80) Not null comment 'Nome completo do proprietario.',
	Sexo   Char Not null comment 'Sexo do proprietario(M – masculino | F - Feminino).',
	Data_de_nascimento	date Not null comment 'Data de nascimento do proprietário (mm/dd/aaaa).',
	Telefone	Varchar(23) Not null comment 'Telefone para contato com o proprietário.',
	Email	Varchar(50) null comment 'Email comercial do proprietário.',
	Primary Key (cpf)
);

create Table Func_apar(
	Id	Int Not null auto_increment comment 'Codigo de identificação da função entre proprietário e apartamento.',
	numero	varchar Not null comment 'Número de identificação do apartamento',
	cpf_propi	Varchar(11) Not null comment 'Cpf do proprietário.',
	Primary Key(Id)
	Foreign Key(numero) REFERENCES Apartamento(numero),
	Foreign Key(cpf_propi) REFERENCES Proprietario(cpf)
);

/* -- Consultas -- */

/* -- Todas os dados de Predio -- */
Select *
from Predio

/* -- Dados proprietario LIKE -- */
Select nome,cpf
from Proprietario
where nome like 'Carla%'

/* -- Dados proprietario BETWEEN -- */ 
Select nome,sexo,cpf
from Proprietario
where Data_de_nascimento BETWEEN '1985-01-01' and '1987-01-01'

/* -- mais de uma tabela -- */
Select Proprietario.nome, Apartamento.numero , Predio.id
from Proprietario,Apartamento,Predio,Func_apar
where Apartamento.id_predio = Predio.id And
Apartamento.numero = Func_apar.numero And
Func_apar.cpf_propi = Proprietario.cpf

/* -- Todas as tabelas -- */
Select Pessoa.nome,Predio.id,Apartamento.numero,Proprietario.nome
from Proprietario,Apartamento,Predio,Func_apar,Pessoa
where Apartamento.id_predio = Predio.id And
Apartamento.numero = Func_apar.numero And
Func_apar.cpf_propi = Proprietario.cpf And
Predio.id = Pessoa.id_predio And
Pessoa.numero = Apartamento.numero