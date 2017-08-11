Create DATABASE Imoveis;

create Table Funcionario(
	Cpf	Varchar(11) Not null comment 'Cpf do funcionario.',
	Nome	Varchar(80) Not null comment 'Nome completo do funcionário.',
	Sexo	varchar(1) Not null comment 'Sexo do funcionario, M - masculino | F - Feminino',
	Email	Varchar(50) null comment 'Email do funcionário.',
	telefone	Varchar(23) Not null comment 'Telefone do funcionário.',
	primary key (cpf);
);

create table Locatorio(
	Cpf	Varchar(11) Not null comment 'Cpf do locatorio.',
	Nome	Varchar(80) Not null comment 'Nome completo do locatorio.',
	Email	Varchar(50) null comment 'Email do locatorio.',
	Telefone	Varchar(23)  Not null comment 'Telefone do locatorio.',
	primary key (cpf)	
);

create table Fiador(
	Cpf	Varchar(11) Not null comment 'Cpf do Fiador.',
	Nome	Varchar(80) Not null comment 'Nome completo do Fiador.',
	Email	Varchar(50) null comment 'Email do Fiador.',
	Telefone	Varchar(23)  Not null comment 'Telefone do Fiador.',
	Primary key(cpf)
);

create table Locador(
	Cpf	Varchar(11)  Not null comment 'Cpf do Locador',
	Nome	Varchar(80)  Not null comment 'Nome completo do Locador.',
	Telefone	Varchar(23) Not null comment 'Telefone do Locador.',
	Primary Key (cpf)
);

create table Imovel(
	codigo int Not null auto_increment comment 'Codigo de indentificação do imovel.',
	Valor	Double not null comment 'Valor do imovel.',
	Primary key (codigo)
);

create table Clausulas_do_contrato(
	Id	int not null auto_increment	 comment 'Codigo de indentificação da clausula.',
	Pagina	Int not null comment 'Numeração de onde se encontra a clausula.',
	paragrafo	Int not null comment 'Número do parágrafo da clausula.',
	primary key(Id)
);

create table Contrato{
	Codigo	Varchar(15) Not null comment 'Codigo do contrato.',
	Responsável	Varchar(80) Not null comment 'Nome do completo do responsável.',
	nome	Varchar(50) Not null comment 'Nome do contrato.',
	Cpf_loca	Varchar(11) Not null comment 'Cpf do locatorio.',
	Cpf_fiador	Varchar(11) Not null comment 'Cpf do fiador.',
	Cpf_fun	Varchar(11) Not null comment 'Cpf do funcionario.',
	Cpf_locador	Varchar(11) Not null comment 'Cpf do locador.',
	Id_imovel	Varchar(15) Not null comment 'Código de identificação do imóvel.',
	Primary Key(codigo),
	Foreign Key(Cpf_loca) REFERENCES locatorio(cpf),
	FOREIGN Key(Cpf_fiador) REFERENCES fiador(cpf),
	Foreign Key(Cpf_locador) References locador(cpf),
	Foreign Key(Id_imovel) REFERENCES imovel(codigo)	
};