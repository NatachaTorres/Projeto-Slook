select *from vendedor

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

select *from funcionario
