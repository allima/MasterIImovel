create database masterimovel;
use masterimovel;

create table pessoa
(
id int identity not null primary key,
nome varchar(250) not null,
email varchar(250) not null,
endereco  varchar(250) not null,
cpf varchar(25) not null,
rg varchar(25) not null,
telefone varchar(25) not null,
tipo char(1)not null default('P') 
);

create table imovel
(
id int identity not null primary key,
decricao varchar(250) not null,
endereco  varchar(250) not null,
valor_imovel money not null,
valor_aluguel money not null,
idade_imovel_dt date,
tipo_imovel char(1)
);

create table proprietario_imovel
(
id int identity not null primary key,
id_imovel int not null,
id_proprietario int not null,
constraint proimoimovel_fk foreign key(id_imovel) references imovel(id),
constraint proimoproprietario_fk foreign key(id_proprietario) references pessoa(id)
);

create table aluga_vende(
id int,
id_imovel int not null,
id_inquilino int not null,
id_corretor int not null,
valor_aluguel money,
data_inicio date,
data_final date,
data_venda date,
valor_venda money,
constraint locimovel_fk foreign key(id_imovel) references imovel(id),
constraint locinquilino_fk foreign key(id_inquilino) references pessoa(id),
constraint loccorretor_fk foreign key(id_corretor) references pessoa(id)
);


/*
connetio ALEXANDRE-PC\SQLEXPRESS

ALEXANDREDELIMA

*/