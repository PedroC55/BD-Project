CREATE SCHEMA PF;

CREATE TABLE PF.EMPRESA (
	Nome					varchar(10)	  PRIMARY KEY,
	Endereço				varchar(30),
	Condições_de_pagamento	varchar(50));


CREATE TABLE PF.MATERIA_PRIMA (
	Qualidade	varchar(10)		PRIMARY KEY,
	Tipo		varchar(10));

CREATE TABLE PF.FORNECEDOR (
	Nome		varchar(20)		PRIMARY KEY,
	Nº_FAX		int,
	Endereço	varchar(30),
	Nº_Inf_fiscal int,
	Qualidade_mat	varchar(10) REFERENCES PF.MATERIA_PRIMA(Qualidade));

CREATE TABLE PF.CATEGORIA (
	Tipo	varchar(20)		PRIMARY KEY);

CREATE TABLE PF.PRODUTO (
	Código			char(9)		PRIMARY KEY,
	Nome			varchar(20),
	Preço			float,
	Taxa_de_IVA		float,
	Nº_em_stock		int,
	Nome_Empresa	varchar(10) REFERENCES PF.EMPRESA(Nome),
	Tipo_Categoria	varchar(20) REFERENCES PF.CATEGORIA(Tipo));


CREATE TABLE PF.CLIENTE (
	Nome		varchar(20)		PRIMARY KEY,
	Endereço	varchar(30),
	Nº_CC		char(8),
	Género		char,
	Email		varchar(30),
	Nome_Empresa	varchar(10) REFERENCES PF.EMPRESA(Nome));

CREATE TABLE PF.TRANSPORTADORA (
	Nome					varchar(10)		PRIMARY KEY,
	Veiculo					varchar(30),
	Nº_de_entregas			int);

CREATE TABLE PF.ENVIO (
	Hora				time		PRIMARY KEY,
	Destino				varchar(30),
	Nº_de_encomendas	int,
	Nome_transportadora varchar(10) REFERENCES PF.TRANSPORTADORA(Nome));

CREATE TABLE PF.ENCOMENDA (
	Número		int		PRIMARY KEY,
	Data		date,
	Endereço	varchar(30),
	Hora_Envio	time	REFERENCES PF.ENVIO(Hora),
	Nome_empresa varchar(10) REFERENCES PF.EMPRESA(Nome),
	Nome_Cliente varchar(20) REFERENCES PF.CLIENTE(Nome));


CREATE TABLE PF.fornece (
	Nome_Fornecedor		varchar(20)		REFERENCES PF.FORNECEDOR(Nome),
	Nome_Empresa		varchar(10)		REFERENCES PF.EMPRESA(Nome));

CREATE TABLE PF.faz_parte (
	Codigo_Produto				char(9)			REFERENCES PF.PRODUTO(Código),
	Qualidade_Materia_Prima		varchar(10)		REFERENCES PF.MATERIA_PRIMA(Qualidade));

CREATE TABLE PF.possui (
	Codigo_Produto		char(9)			REFERENCES PF.PRODUTO(Código),
	Número_Encomenda	int				REFERENCES PF.ENCOMENDA(Número));

CREATE TABLE PF.faz (
	Nome_Cliente		varchar(20)		REFERENCES PF.CLIENTE(Nome),
	Número_encomenda	int				REFERENCES PF.ENCOMENDA(Número));




