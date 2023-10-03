DROP DATABASE Informatica; /BORRA LA BASE DE DATOS DEL SERVIDOR/

CREATE DATABASE Informatica;
USE Informatica;

--tabla usuarios--
CREATE TABLE Usuarios(
	id_usuario INT PRIMARY KEY,
	dni_Empleados integer,
	contraseña varchar (25),
	id_tipoUsuario integer ,
	Estado_usuario bit,
	FOREIGN KEY (id_tipoUsuario)REFERENCES tipoUsuario (id_tipoUsuario),
	FOREIGN KEY (dni_Empleados)REFERENCES Empleados (dni_Empleados)
);
Go
--eliminar tabla--
Drop table Usuarios
go
--insertar datos
INSERT INTO Usuarios(id_usuario,dni_Empleados,contraseña,id_tipoUsuario,Estado_usuario) VALUES
                    (1, 34825398,1234,1,0);
					 --(2, 40808, 234,1,1);
Select * from Usuarios
Go

------------------


--tabla tipo usuario--
Create Table tipoUsuario(
	   id_tipoUsuario Integer primary key,
	   descripcion varchar(25),
);
GO
Drop table tipoUsuario
go
--insertar datos
INSERT INTO tipoUsuario(id_tipoUsuario,descripcion) VALUES
                       (1, 'administador')
				
GO
Select * FROM tipoUsuario
GO
--tabla de provincia--
CREATE TABLE Provincia(
	Id_provincia integer PRIMARY KEY,
	Descripcion VARCHAR(10)
);
GO
Drop table Provincia
go
INSERT INTO Provincia(Id_provincia,Descripcion) VALUES
                       (1, 'Santa fe');
GO
Select * FROM Provincia
GO

--tabla de clientes--
CREATE TABLE Clientes(
	Dni_clientes Integer PRIMARY KEY,
	Apellido varchar (20),
	Nombre varchar (25),
	Direccion varchar (30),
	Telefono varchar,
	Email varchar (30),
	fecha_alta DATETIME,
	Estado_cliente bit,
	id_provincia integer,
	Sexo varchar,
	FOREIGN KEY (id_provincia)REFERENCES Provincia (Id_provincia)
);
GO
Drop table Clientes
go
--TABLA FACTURAS--
CREATE TABLE Facturas(
	id_factura INT PRIMARY KEY not null,
	id_usuario integer,
	Dni_cliente integer,
	fecha_factura datetime,
	Total_factura DECIMAL(8,2) NOT NULL,
	estado_factura bit,
	FOREIGN KEY (Dni_cliente)REFERENCES Clientes (Dni_clientes),
	FOREIGN KEY (id_usuario)REFERENCES Usuarios (id_usuario)
);
Go
Drop table Facturas


--TABLA DETALLE FACTURA--
Create table DetalleFacturas(
    id_detalle INT primary key,
	id_factura integer, 
	id_producto integer,
	cantidad integer,
	precio DECIMAL(8,2) NOT NULL,
	subtotal DECIMAL(8,2) NOT NULL,	
	FOREIGN KEY (id_factura)REFERENCES  Facturas(id_factura),
	FOREIGN KEY (id_producto)REFERENCES Productos (id_producto)
	);
GO
	Drop table DetalleFacturas


CREATE TABLE Empleados(
	Dni_empleados Integer PRIMARY KEY,
	apellido varchar (20),
	nombre varchar (25),
	direccion varchar (30),
	telefono varchar (25),
	fecha_ingreso DATETIME,
	id_provincia integer,
	estado_emplead bit,
	Email varchar (30),
	fecha_Nacimiento DATE,
	Sexo varchar (15),
	turno varchar(30),
	FOREIGN KEY (id_provincia)REFERENCES Provincia (Id_provincia)
)
GO
Drop table Empleados
go
INSERT INTO Empleados(Dni_empleados,apellido, nombre, direccion,telefono,fecha_ingreso,id_provincia,estado_emplead,Email,fecha_Nacimiento,Sexo,turno ) VALUES
                       (34825398, 'Ramos', 'Celia','catamarca 2260', '32944027', '2000-05-10',1,0, 'ramos@hotmail', '30-09-1989','femenino','tarde');
GO
Select * FROM Empleados
GO




		

Create table Proveedores(
     id_proveedor integer primary key,
	 razon_social varchar (20),
	 direccion varchar (25),
	 telefono varchar (15),
	 email varchar (25),
	 id_provincia integer,
	 FOREIGN KEY (id_provincia)REFERENCES Provincia (Id_provincia)
	 )
	 Go
Create Table Productos(
     id_producto INT primary Key,
	 descripcion varchar (25),
	 id_categoria INT ,
	 id_marca INT ,
	 stock INT,
	 precio DECIMAL(8,2) NOT NULL,
	 estado bit,
	 precio_costo DECIMAL(8,2) NOT NULL,
	 id_origen integer,
	 id_proveedores integer,
	 FOREIGN KEY (id_origen)REFERENCES Origen_Producto (id_origen),
	 FOREIGN KEY (id_categoria)REFERENCES Categorias (id_categoria),
	 FOREIGN KEY (id_marca)REFERENCES Marcas (id_marca),
	 FOREIGN KEY (id_proveedores)REFERENCES Proveedores (id_proveedor)
	 );
	 Go

Create Table Categorias(
       id_categoria integer primary key,
	   descripcion varchar (30),
	)
	Go
Create Table Marcas(
       id_marca integer primary key,
	   descripcion varchar(30),
)
Go
Create Table Origen_Producto(
       id_origen integer primary key,
	   descripcion varchar(30),
	)
	GO



	    



