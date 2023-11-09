create database t14_projeto_slook

drop database t14_projeto_slook

Use t14_projeto_slook



create table venda
(
	id_venda int not null identity primary key,
	id_cliente_venda int not null ,
	id_produto_venda int not null ,
	data_venda smalldatetime not null default getdate(),
	qtd_venda int not null ,
	vvenda_venda decimal(10,2) not null ,
	obs_venda varchar(200) null ,
	status_venda varchar(20) not null default 'ATIVO',

	constraint fk_id_cliente_venda foreign key (id_cliente_venda) references cliente (id_cliente),
	constraint fk_id_produto_venda foreign key (id_produto_venda) references produto (id_produto)

)


create table cliente
(
	id_cliente  int  not null  identity primary key ,
	nome_cliente  varchar(50)  not null    ,
	nasc_cliente  date  not null    ,
	data_cliente  smalldatetime  not null  default getdate()  ,
	cpf_cliente  char(14)  not null    ,
	numero_cliente  int  not null    ,
	logadouro_cliente  varchar(50)  not null    ,
	cep_cliente  char(9)  not null    ,
	bairro_cliente  varchar(50)  not null    ,
	cidade_cliente  varchar(50)  not null    ,
	comp_cliente  varchar(50)  null    ,
	uf_cliente  char(2)  not null    ,
	telefone1_cliente  char(16)  not null    ,
	telefone2_cliente  char(16)  null    ,
	email_cliente  varchar(100)  not null    ,
	obs_cliente  varchar(200)  null    ,
	status_cliente  varchar(20)  not null  default 'ATIVO'
)



create table vendedor
(
	id_vendedor int not null identity primary key ,
	nome_vendedor varchar(25) not null  ,
	data_vendedor smalldatetime not null default getdate() ,
	nasc_vendedor date not null  ,
	cpf_vendedor char(14) not null  ,
	logradouro_vendedor varchar(50) not null  ,
	numero_vendedor int not null  ,
	comp_vendedor varchar(20) null  ,
	cep_vendedor char(9) not null  ,
	bairro_vendedor varchar(50) not null  ,
	cidade_vendedor varchar(50) not null  ,
	uf_vendedor char(2) not null  ,
	telefone1_vendedor char(16) not null  ,
	telefone2_vendedor char(16) null  ,
	email_vendedor varchar(20) not null  ,
	nomeloja_vendedor varchar(25) not null  ,
	cnpjloja_vendedor char(18) not null  ,
	logadouroloja_vendedor varchar(50) not null  ,
	numeroloja_vendedor int not null  ,
	comploja_vendedor varchar(20) not null  ,
	ceploja_vendedor char(9) not null  ,
	bairroloja_vendedor varchar(50) not null  ,
	cidadeloja_vendedor varchar(50) not null  ,
	ufloja_vendedor char(2) not null  ,
	telefone1loja_vendedor char(16) not null  ,
	telefone2loja_vendedor char(16) null  ,
	obsloja_vendedor varchar(200) null  ,
	statusloja_vendedor varchar(20) not null default 'ATIVO' 
	)



create table produto
(
	id_produto int not null identity primary key,
	id_vendedor_produto int not null  ,
	nome_produto varchar(50) not null  ,
	data_produto smalldatetime not null default getdate () ,
	qtde_produto int not null  ,
	vvenda_produto decimal (10,2) not null  ,
	obs_produto varchar(200) null  ,
	status_produto varchar(20) not null default 'ATIVO' ,

	constraint fk_id_vendedor_produto foreign key (id_vendedor_produto) references vendedor (id_vendedor)
)




create table contrato

(
	id_contrato int not null identity primary key ,
	id_vendedor_contrato int not null  ,
	id_funcionario_contrato int not null  ,
	data_contrato smalldatetime not null default getdate () ,
	datafinal_contrato smalldatetime not null  ,
	vcontrato_contrato decimal (10,2) not null  ,
	totaldeparcelas_contrato int not null  ,
	tipo_contrato varchar(50) not null  ,
	obs_contrato varchar(200) null  ,
	status_contrato varchar(20) not null default 'ATIVO' ,

	constraint fk_id_vendedor_contrato foreign key (id_vendedor_contrato) references vendedor (id_vendedor),
	constraint fk_id_funcionario_contrato foreign key (id_funcionario_contrato) references funcionario (id_funcionario)
)



create table contasareceber

(
	id_contasareceber int not null identity primary key,
	data_contasareceber smalldatetime not null default getdate () ,
	qtde_parcelas_contasareceber int not null  ,
	valor_contasareceber decimal (10,2) not null  ,
	tipos_contasareceber varchar(75) not null  ,
	obs_contasareceber varchar(200) null  ,
	status_contasareceber varchar(20) not null default 'ATIVO' 
) 

	


create table funcionario

(
	id_funcionario int not null identity primary key,
	nome_funcionario varchar(50) not null  ,
	setor_funcionario varchar(20) not null,
	cargo_funcionario varchar(20) not null,
	nasc_funcionario date not null  ,
	data_funcionario smalldatetime not null default getdate() ,
	cpf_funcionario char(14) not null  ,
	logadouro_funcionario varchar(50) not null  ,
	numero_funcionario int not null  ,
	comp_funcionario varchar(20) null  ,
	cep_funcionario char(9) not null  ,
	bairro_funcionario varchar(50) not null  ,
	cidade_funcionario varchar(50) not null  ,
	uf_funcionario char(2) not null  ,
	telefone1_funcionario varchar(16) not null  ,
	telefone2_funcionario varchar(16) null  ,
	email_funcionario varchar(100) not null  ,
	obs_funcionario varchar(200) null  ,
	status_funcionario varchar(20) not null default 'ATIVO' 

)



create table contasapagar

(
	id_contasapagar int not null identity primary key,
	id_funcionario_contasapagar int not null  ,
	data_contasapagar smalldatetime not null default getdate () ,
	qtde_parcelas_contasapagar int not null  ,
	valor_contasapagar decimal(10,2) not null  ,
	obs_contasapagar varchar(200) null  ,
	status_contasapagar varchar(20) not null default 'ATIVO',

	constraint fk_id_funcionario_contasapagar foreign key (id_funcionario_contasapagar) references funcionario (id_funcionario)

)

select * from contasapagar



create table parceria

(
	id_parceria int not null identity primary key,
	id_funcionario_parceria int not null  ,
	nome_parceria varchar(50) not null  ,
	data_parceria smalldatetime not null default getdate(),
	cnpj_parceria char(18) not null  ,
	numero_parceria int not null  ,
	logadouro_parceria varchar(50) not null  ,
	comp_parceria varchar(50) null  ,
	cep_parceria char(9) not null  ,
	bairro_parceria varchar(50) not null  ,
	cidade_parceria varchar(50) not null  ,
	uf_parceria char(2) not null  ,
	telefone1_parceria char(16) not null  ,
	telefone2_parceria char(16) null  ,
	contato_parceria char(16) not null  ,
	email_parceria varchar(100) not null  ,
	obs_parceria varchar(200) null  ,
	status_parceria varchar(20) not null default 'ATIVO' ,

	constraint fk_id_funcionario_parceria foreign key (id_funcionario_parceria) references funcionario (id_funcionario)
)

	select * from cliente
	select * from funcionario
	select * from parceria
	select * from vendedor
	select * from contasapagar
	select * from contasareceber
	select * from contrato
	select * from venda
	select * from produto

	 drop table cliente
	 drop table funcionario
	 drop table parceria
	 drop table vendedor
	 drop table contasapagar            
	 drop table contasareceber
	 drop table contrato 
	 drop table venda
	 drop table produto
