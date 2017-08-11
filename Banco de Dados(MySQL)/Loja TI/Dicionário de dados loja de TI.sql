Create Database LojaTI;

Create Table Funcionario(
	Cpf	Varchar(11) Not null comment 'Cpf do funcionário.',
	Data_nascimento	Date Not null comment 'Data de nascimento do funcionário.',
	Sexo	Varchar(1) Not null comment 'Sexo do funcionário (M – masculino | F - Feminino)',
	Nome	Varchar(100) Not null comment 'Nome completo do funcionário.',
	salario	Double Not null comment 'Salario do funcionario',
	Primary Key(Cpf)
);

Create table Cliente(
	Cpf	Varchar(11) not null comment 'Cpf do cliente',
	Cpf_funcionario	Varchar(11) not null comment 'Cpf do funcionário responsável pelo atendimento do suporte.',
	Nome	Varchar(100) not null comment 'Nome completo do cliente.',
	Telefone	Varchar(25) not null comment 'Telefone para contato do cliente.',
	email	Varchar(80) not null comment 'Email para contato do cliente.',
	Primary Key(cpf),
	Foreign Key(Cpf_funcionario) references Funcionario(cpf)
);

Create table Pedido(
	id	int Not null auto_increment comment 'Numero de identificação do Pedido.',
	Cpf_cliente	Varchar(11) Not null comment 'Cpf do cliente que efetuou o pedido.',
	Cpf_funcionario	Varchar(11) Not null comment 'Cpf do funcionário que registrou o pedido.',	
	Status	Int Not null comment 'Status do pedido(1 – Ativo | 0 - Cancelado)',
	Primary key (id),
	Foreign Key(Cpf_funcionario) references Funcionario(cpf),
	Foreign Key(Cpf_cliente) references Cliente(cpf)
);

Create table Produto(
	Id	Int Not null auto_increment comment 'Numero de identificação do Produto.',
	Pedido_id	Int  Not null comment 'Numero de identificação do pedido',
	Cpf	Varchar(11)  Not null comment 'Cpf do funcionário responsável pelo cadastro.',
	Preco	Double Not null comment 'Preço do produto.',
	garantia	Date Not null comment 'Prazo de garantia do produto.',
	Nome 	Varchar(70) Not null comment 'Nome completo do produto.',
	fabricante	Varchar(50) Not null comment 'Nome da fabricante do produto.',
	Primary key(id),
	Foreign Key(Pedido_id) references Pedido(id),
	Foreign Key(cpf) references Funcionario(cpf)
);

/*  ----==== Insert's ====----- */

insert into Funcionario(cpf,Data_nascimento,Sexo,Nome,Salario)
values(	"00000000011","1990-02-01","M","Victor",1350),
("00000000012","1990-03-01","F","Lua",1350),
("00000000013","1990-04-01","F","Elma",2350)

insert into Cliente(Cpf,Cpf_funcionario,Nome,Telefone,email)
values("10000000000","00000000011","Tobias","54568789","asdasf@ww.br"),
("20000000000","00000000011","Tio","54268789","asdf@ww.com.br"),
("30000000000","00000000012","Laura","49462545","adisjd@sapodkl")

insert into Pedido(Cpf_cliente,Cpf_funcionario,status)
values("10000000000","00000000013",1),
("30000000000","00000000013",1),
("30000000000","00000000013",1),
("30000000000","00000000013",0),
("20000000000","00000000011",0)

insert into produto(Pedido_id,cpf,preco,garantia,nome,fabricante)
values(1,"00000000012",1500,"2017-11-01","Teclado","Multilaser"),
(2,"00000000012",50,"2017-09-01","Mouse","Multilaser"),
(2,"00000000012",20,"2017-07-05","Mousepad","DeN"),
(3,"00000000011",2500,"2017-11-20","Notebook","Aveel"),
(4,"00000000012",3500,"2017-11-01","Gabinete","Multilaser")

/*  ----==== Select ====----- */
select *
from produto

/*  ----==== Update ====----- */
Update produto set
	preco = 100
where preco < 100
/*  ----==== Delete ====----- */
Delete from Produto
where fabricante = "Multilaser"
and nome = "Gabinete"
Delete from pedido
where status = 0

	
