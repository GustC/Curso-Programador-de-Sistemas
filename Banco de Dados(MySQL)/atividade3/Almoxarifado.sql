Create Database Almoxarifido;


Create Table Solicitante(
	Cpf	Varchar(11) not null comment 'Cpf do solicitante',
	Nome	Varchar(80) not null comment 'Nome do  solicitante',
	Telefone	Varchar(23) not null comment 'Telefone do  solicitante',
	Setor	Varchar(30) not null comment 'Setor do  solicitante',
	Primary key(cpf)
);

Create Table Lista(
	Numero_itens	int Not null comment 'Quantidade de itens.',
	codig	int Not null auto_increment comment 'Código de identificação da lista',
	Cpf	Varchar(11) not null comment 'Cpf do solicitante',
	Primary key (codig) ,
	Foreign Key (cpf) references Solicitante(cpf)
);

Create table Grupo(
	Codigo	int Not null auto_increment comment 'Código indentificador da função do grupo',
	tipo	Varchar(30) not null comment 'Código indentificador da função do grupo',
	Primary Key (Codigo)
);

Create Table Material(
	id	int Not null auto_increment comment 'Código indentificador da função da lista',
	Id_grupo	Int Not null comment 'Código de identificação do grupo.',
	Nome	Varchar(80) Not null comment 'Nome do  material.',
	Validade	date Not null comment 'Data de validade do material.',
	Primary Key (id),
	Foreign Key (Id_grupo) references grupo(Codigo)
);

Create table Func_lista(
	id	int Not Null auto_increment comment 'Código indentificador da função da lista',
	Id_material	int Not Null comment 'Código de identificação do material.',
	codig	int Not Null comment 'Código de identificação da lista.',
	Primary Key (id),
	Foreign Key (codig) references lista(codig),
	Foreign key (id_material) references material(id)
);

/* -- Consultas --  */
/* -- todos os dados Solicitante -- */
Select *
From Solicitante

/* -- dados Grupo LIKE -- */
Select codigo
from Grupo
where grupo like 'engenharia'

/* -- dados Material BETWEEN -- */
Select nome,id_material
from Material
where validade between '2016-01-01' and '2018-01-01'

/* -- mais de uma tabela -- */
Select Material.nome,Grupo.tipo
from material,grupo
where Material.id_grupo = Grupo.codigo

/* -- todas as tabela -- */

Select Solicitante.nome,Material.nome,Lista.numero_itens,grupo.tipo
from Solicitante,Lista,func_lista,material,Grupo
where Solicitante.cpf = Lista.cpf and
lista.codig = func_lista.codig and
func_lista.id_material = Material.id and
material.id_grupo = Grupo.codigo
