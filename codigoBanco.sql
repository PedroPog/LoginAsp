create database bancologin;

use bancologin;

create table cliente(
	id int auto_increment primary key,
    nome  varchar(50) not null,
    nascimento datetime not null,
    sexo char(1),
    cpf varchar(11) not null,
    telefone varchar(14) not null,
    email varchar(50) not null,
    senha varchar(6) not null,
    situacao char(1) not null
);

create table colaborador(
	id int auto_increment primary key,
    nome varchar(50) not null,
    email varchar(50) not null,
    senha varchar(8) not null,
    tipo varchar(8) not null
);