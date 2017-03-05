create database Banking;

use Banking;

create table USUARIO(

	Cedula_usuario varchar(11) primary key not null,
	Nombre_Completo varchar(100) not null,
	FechaNacimiento_usuario date not null,
	Clave varchar(20) not null,
	Usuario varchar(20) not null
);

insert into USUARIO values('40124442208', 'Abel Abraham Feliz Soto', '1996-06-28', 'hola115', 'afeliz')

create table DIRECCION(

	Cedula_usuario varchar(11) primary key,
	NombreCalle_direccion varchar(100) not null,
	Numero_direccion varchar(8) not null,
	Sector_direccion varchar(100) not null,

	foreign key (Cedula_usuario) references USUARIO(Cedula_usuario)
);

create table CONCURRENCIA(

	ID_concurrencia varchar(8) primary key not null,
	Descripcion varchar(50) not null
);

insert into CONCURRENCIA values('RD$', 'Pesos Dominicanos');
insert into CONCURRENCIA values('US$', 'Dólares Americanos');
insert into CONCURRENCIA values('€', 'Euros');

insert into TARJETA_CREDITO values('4540980513159717', 'RD$', '2018-03-06', '365', '1466');

create table TARJETA_CREDITO(

	ID_tarjeta varchar(16) primary key not null,
	ID_concurrencia varchar(8) not null,
	FechaVencimiento_tarjeta date not null,
	CVV_tajeta varchar(8) not null,
	PIN_tarjeta varchar(50) not null

	FOREIGN KEY (ID_concurrencia) REFERENCES CONCURRENCIA(ID_concurrencia)
);

create table USUARIO_TARJETA_CREDITO(
	Cedula_usuario varchar(11) not null,
	ID_tarjeta varchar(16) not null,

	primary key(Cedula_Usuario, ID_tarjeta),
	foreign key (Cedula_usuario) references USUARIO(Cedula_usuario),
	foreign key (ID_tarjeta) references TARJETA_CREDITO(ID_tarjeta)
);

insert into USUARIO_TARJETA_CREDITO values ('40124442208', '4540980513159717')

select * from USUARIO_TARJETA_CREDITO

/**/


create table CUENTA(

Numero_cuenta numeric(9) primary key not null,
Cedula_usuario varchar(11) not null,
balanceActual_cuenta int not null,
balanceDisponible_cuenta int not null,
consumoTotal_cuenta int not null,
consumoCorte_cuenta int not null,
ingresos_cuenta numeric(30,2) not null,

FOREIGN KEY (Cedula_usuario) REFERENCES USUARIO(Cedula_usuario)
);


create table TARJETA_DEBITO(

ID_tarjetaDebito varchar(16) primary key not null,
Numero_cuenta numeric(9) not null,
CVV_tarjetaDebito varchar(8) not null,
PIN_tarjetaDebito varchar(50) not null,
fechaVencimiento_tarjetaDebito date not null,

FOREIGN KEY (Numero_cuenta) REFERENCES CUENTA(Numero_cuenta)
);

create table TRANSACCIONES(

ID_transacciones int primary key identity(1,1) not null,
ID_tarjeta varchar(16) not null,
ID_concurrencia varchar(8) not null,
nombreComercio_transacciones varchar(50) not null,
tipoComercio_transacciones varchar(50) not null,
fecha_transacciones date not null,
monto_transacciones numeric(10, 2) not null,

foreign key (ID_tarjeta) references TARJETA_CREDITO(ID_tarjeta),
foreign key (ID_tarjeta) references TARJETA_DEBITO(ID_tarjetaDebito)
);