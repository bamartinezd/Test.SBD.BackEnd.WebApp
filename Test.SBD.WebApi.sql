create database Prueba_AlejandroMartinezDelgado
go

use Prueba_AlejandroMartinezDelgado
go

create table Clientes(
	Id bigint primary key, 
	Nombre varchar(50), 
	Direccion varchar(50), 
	FechaCreacion datetime, 
	Estado bit
)
go

create table Facturas(
	Id int identity primary key,
	ClienteId bigint,
	FechaVenta datetime,
	ValorTotal money,
	Estado bit,
	FOREIGN KEY (ClienteId) REFERENCES Clientes(Id) 
)
go

insert into Clientes (Id,Nombre,Direccion,FechaCreacion,Estado) values
(1023931285,'Alejandro Martinez','Crr 69 # 37 d 14 sur',GETDATE(),1),
(1023931286,'Brayan Delgado','Crr 69 # 37 d 14 sur',GETDATE(),1)
go

select * from Clientes

insert into Facturas(ClienteId,FechaVenta,ValorTotal,Estado)values
(1023931285,GETDATE(),250000,1)
,(1023931285,GETDATE(),25000,1)
,(1023931286,GETDATE(),2500,1)
go

select * from Facturas