create database M_Cleveland

Use M_Cleveland

CREATE TABLE Medicos (
	IdMedico int identity primary key,
    Nome varchar(200),
    DataNascimento datetime unique,
    Crm int unique,
	AreaAtuacao varchar(200),
	Ativo Bit not null Default (1)
);

insert into Medicos(Nome, DataNascimento, Crm, AreaAtuacao, Ativo)
	values			 ('Murilo Brabissimo','2002-11-13T08:30:00',1323,'Ginecologista',1)
					,('Fabones Flavin','2003-05-26T10:00:00',1548,'Clínico',1)					
					,('Matheus Matheuzin','2002-07-24T14:32:53',9548,'Cardiologista',1)					
					,('Dr. Drauzio VrauNelas','1990-03-04T12:23:43',0001,'Deus Médico Supremo',1);