create database crud_csharp_pet;

create table animal(
codigo int(20) not null primary key,
nome varchar(50) not null,
idade int(5) not null,
cor varchar(50) not null,
sexo varchar(50) not null,
especie varchar(50) not null
);