-- CRIANDO BANCO DE DADOS --
create database DBPIZZA;
-- USANDO O BANCO DE DADOS

use DBPIZZA;
--  CRIANDO AS TABELAS DO BANCO DE DADOS --
create table tbPedido(
codPedido int primary key auto_increment,
TipoPizza varchar(50),
valorPizza varchar(50),
valorOpçao varchar(50),
valorTotal varchar(50)
);


-- 	CONSULTA AS TABE,AS  DO BANCO DE DADOS 
	SELECT * from tbPedido;
    