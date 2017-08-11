create Database PetShop;

create Table Fornecedor(
	Codigo	Int not null auto_increment comment 'Codigo de identificação do fornecedor',
	Nome	Varchar(50) not null comment 'Nome do fornecedor',
	Telefone	Varchar(23) not null comment 'Telefone do fornecedor',
	Primary Key(codigo)

);

create Table Usuario(
	Nome	Varchar(100) not null comment 'Nome completo do usuário.',
	Cpf	Varchar(11) not null comment 'Cpf do usuário.',
	Primary Key(cpf)
);

create Table Omissao(
	Codigo	Int not null auto_increment comment 'Codigo de identificação da Omissao',
	Causa	text not null comment 'Texto informando a causa.',
	descricao text not null comment 'Texto relatando a omissão.',
	Primary Key(Codigo)	
);

create Table Contra_Cheque(
	Codigo	Int not null auto_increment comment 'Codigo de identificação do contra cheque',
	Valor	Double not null comment 'Valor do pagamento do cheque',
	Primary Key(Codigo)	
);

create Table Site_app(
	Nome	Varchar(150) not null comment 'Nome do site',
	id	int not null auto_increment comment 'Indentificador do site.',
	Primary key(id)
);

create Table LogSiteApp(
	Código	Int not null auto_increment comment 'Codigo de identificação do Log feito no Site.',
	Id_site	int not null comment 'Codigo Indetificador do site.',
	Primary Key(Codigo)
)

create Table Funcionario(
	Cpf	Varchar(11) not null auto_increment comment 'Cpf do funcionário',
	Sexo	Varchar(1) not null comment 'Sexo do funcionário(M - Masculino | F - Feminino)',
	Salario	Double not null comment 'Salario do funcionário',
	nome	Varchar(100) not null comment 'Nome completo do funcionário',
	Primary Key(cpf)
);

create Table Gerente(
	Código	Int not null auto_increment comment 'Codigo de identificação do gerente',
	relatorio	text not null comment 'Relatório geral do gerente',
	cpf varchar(11) Not null comment 'Cpf do funcionario'
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table Veterinario(
	Codigo	Int  not null auto_increment comment 'Codigo de identificação do veterinário',
	Agenda_data	Date not null comment 'Data do agendamento.',
	Agenda_hora	time not null comment 'Horario do Agendamento.',
	diag	Text not null comment 'Texto com diagnostico do Animal.',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table Tosador(
	Codigo	Int  not null auto_increment comment 'Codigo de identificação do tosador',
	Agenda_dia	Date not null comment 'Data do agendamento.',
	Agenda_hora	Time not null comment 'Horario do Agendamento.',
	falta	Text not null comment 'Texto relatando a falta de produtos.',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table Banhista(
	Codigo	Int not null auto_increment comment 'Codigo de identificação do banhista',
	Agenda_dia	Date not null comment 'Data do agendamento.',
	Agenda_hora	Time not null comment 'Data do agendamento.',
	falta	Text not null comment 'Texto relatando a falta de produtos.',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)	
);

create Table Cuidador(
	Codigo	Int not null auto_increment comment 'Codigo de identificação do cuidador',
	descri	Text not null comment 'Texto falando sobre o estado do animal',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)	
);

Create Table Entregador(
	Código	Int not null auto_increment comment 'Codigo de identificação do Entregador',
	EntregaStatus	int not null comment 'Status da entrega (1 – entregue | 0 – não entregue)',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table Limpeza(
	Codigo	Int not null auto_increment comment 'Codigo de identificação da limpeza',
	Relatório	Text not null comment 'Texto descritivo sobre a limpeza',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table Administrativo(
	Código	Int not null auto_increment comment 'Codigo de identificação do cargo Administrativo.',
	Gastos	double not null comment 'Gastos da Pet Shop.',
	Cpf	Varchar(11) not null comment 'Cpf do funcionário.',
	Primary Key(Codigo),
	Foreign Key(cpf) References Funcionario(cpf)
);

create Table AnimalCliente(
	Codigo	Int not null auto_increment comment '',
	Raca	Varchar(50) not null comment '',
	porte	Varchar(30) not null comment '',
	Codigo_veterinario	Int not null comment '',
	Codigo_Tosador	Int not null comment '',
	Codigo_banhista	Int not null comment '',
	Codigo_cuidador	Int	 not null comment '',
	Primary Key(codigo),
	Foreign Key(Codigo_veterinario) references Veterinario(codigo),
	Foreign Key(Codigo_Tosador) references Tosador(codigo),
	Foreign Key(Codigo_banhista) references Banhista(codigo),
	Foreign Key(Codigo_cuidador) references Cuidador(codigo)
);

create Table AnimalLoja(
	Codigo	Int not null auto_increment comment '',
	Raca	Varchar(50) not null comment '',
	porte	Varchar(30) not null comment '',
	valor double not null comment '',
	Codigo_veterinario	Int not null comment '',
	Codigo_Tosador	Int not null comment '',
	Codigo_banhista	Int not null comment '',
	Codigo_cuidador	Int	 not null comment '',
	Primary Key(codigo),
	Foreign Key(Codigo_veterinario) references Veterinario(codigo),
	Foreign Key(Codigo_Tosador) references Tosador(codigo),
	Foreign Key(Codigo_banhista) references Banhista(codigo),
	Foreign Key(Codigo_cuidador) references Cuidador(codigo)
);

create Table cliente(
	Cpf	Varchar(11) Not null comment '',
	telefone	Varchar(23) Not null comment '',
	Nome	Varchar(100) Not null comment '',
	endereco	Varchar(200) Not null comment '',
	Avaliação	Double Not null comment '',
	Denuncia	Text Not null comment '',
	Sugestão	Text Not null comment '',
	Codigo_animal	Int Not null comment '',
	Cpf_funcionario	Varchar(11) Not null comment '',
	Primary Key(Cpf),
	Foreign Key(Codigo_animal) references AnimalCliente(codigo),
	Foreign Key(Cpf_funcionario) references AtendenteBalcao(cpf) /*  --- Parei aqui ! ---*/
);

create Table Gerente_LogApp(
	Código	int not null auto_increment comment '',
	Código_gerente	int not null comment '',
	Código_log	int not null comment '',
	Primary Key(Codigo)
);



