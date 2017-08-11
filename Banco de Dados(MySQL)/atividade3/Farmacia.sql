Create DATABASE Farmacia;

Create Table Medicamento(
	Id	int Not null auto_increment comment 'Codigo identificador do medicamento.',
	Validade	Date Not null comment 'Data de validade do medicamento.',
	nome	Varchar(30) Not null comment 'Nome do medicamento.',
	Primary Key(id)
);

Create Table Medico(
	Id	int Not null auto_increment comment 'Codigo identificador do médico.',
	Telefone	Varchar(23 Not null comment 'Telefone para contato com o médico.',
	Nome	Varchar(80) Not null comment 'Nome completo do medico.',
	PRIMARY Key (Id)
);

Create Table Paciente(
	Cpf	Varchar(11) Not Null comment 'CPF do paciente.',
	Sexo	Char  Not Null comment 'Sexo do paciente(M – masculino | F - Feminino).',
	nome	Varchar(80)  Not Null comment 'Nome completo do paciente.',
	telefone	Varchar(23) Not Null comment 'Telefone para contato com o cliente.',
	Primary Key(Cpf)
);

Create Table Receita(
	Id	int Not Null auto_increment Comment 'Codigo identificador da receita.',
	cpf	Varchar(11) Not Null Comment 'CPF do paciente.',
	Id_medico int Not Null Comment 'Código indentificador do medico.',
	Primary Key(id),
	Foreign key(cpf) REFERENCES paciente(cpf),
	FOREIGN Key(id) References medico(id)
);

Create Table Func_rec(
	Id	int Not null auto_increment Comment 'Codigo identificador da função receita.',  
	Id_receita	int Not null Comment 'Codigo identificador da receita.',
	id_medicamento	int Not null Comment 'Codigo identificador do medicamento.',
	Primary Key (id),
	Foreign key (id_medicamento) references medicamento(id),
	Foreign Key (Id_receita) references receita(id)
);

Create Table Func_medi(
	Id	int Not null auto_increment Comment 'Codigo identificador da função medi.',
	Id_medico	int Not null Comment 'Código indentificador do medico.',
	cpf	Varchar(11) Not null Comment 'CPF do paciente.',
	Primary Key (Id),
	foreign Key (Id_medico) References medico (id),
	Foreign Key (cpf) References paciente(cpf)
);


/* -- Consultas --  */
/* -- todos os dados Paciente -- */
Select *
from Paciente

/* -- dados Paciente LIKE -- */
Select nome 
from Paciente
where nome like '%Silva%'

/* -- dados Medicamento BETWEEN -- */
Select nome,validade
from Medicamento
where validade between '2016-01-01' and '2017-12-31'

/* -- mais de uma tabela -- */
Select Receita.id,Paciente.nome,Medico.id
from Receita,Paciente,Medico
where paciente.cpf = Receita.cpf AND
Receita.id_medico = Medico.id And 

/* -- todas as tabela -- */

Select Receita.id,Paciente.nome,Medicamento.nome,Medico.nome
from Receita,Paciente,Medicamento,Func_medi,func_rec,Medico
where paciente.cpf = Receita.cpf AND
Receita.id_medico = Medico.id And 
Medico.id = Func_medi.id_medico And 
func_medi.cpf = Paciente.cpf And
Receita.id = func_rec.id_receita AND
Func_rec.id_medicamento = medicamento.id

