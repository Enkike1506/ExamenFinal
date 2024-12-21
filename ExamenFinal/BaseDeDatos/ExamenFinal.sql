create database GestionProyectos
go

use GestionProyectos
go

--Creación de la tabla de las categorías
create table Categorias
(
Categoria varchar(20) primary key
)

--Creación de las categorías de los empleados
insert into Categorias (Categoria) values ('Administrador'), ('Operario'), ('Peón')

--Creación de la tabla de los empleados
create table Empleados
(
Id int primary key identity,
Carne int unique not null,
Nombre varchar(50) not null,
Edad int check (Edad >= 18) not null,
FechaNacimiento date not null,
Categoria varchar(20) foreign key references Categorias(Categoria) not null,
Salario int check (Salario >= 250000 and Salario <= 500000) default 250000,
Direccion varchar(30) default 'San José',
Telefono varchar(15) not null,
Correo varchar(50) unique not null
)

--Creación de la tabla de los proyectos
create table Proyectos
(
Id int primary key identity,
Codigo int unique not null,
Nombre varchar(100) unique not null,
FechaInicio date,
FechaFin date
)

--Creación de la tabla de las asignaciones
create table Asignaciones
(
Id int primary key identity,
EmpleadoId int foreign key references Empleados(Id) not null,
ProyectoId int foreign key references Proyectos(Id) not null,
FechaAsignacion date not null
)

--Creación del procedimiento almacenado para agregar empleados
create procedure AgregarEmpleados
@carne int,
@nombre varchar(50),
@edad int,
@fechaNacimiento date,
@categoria varchar(20),
@salario int,
@direccion varchar(30),
@telefono varchar(15),
@correo varchar(50)
as
	begin
		insert into Empleados (Carne, Nombre, Edad, FechaNacimiento, Categoria, Salario, Direccion, Telefono, Correo) values (@carne, @nombre, @edad, @fechaNacimiento, @categoria, @salario, @direccion, @telefono, @correo)
	end

--Creación del procedimiento almacenado para eliminar empleados
create procedure BorrarEmpleados
@id int
as
	begin
		delete Empleados where Id = @id
	end

--Creación del procedimiento almacenado para consultar la tabla empleados
create procedure ConsultarEmpleados
as
	begin
		select Id, Carne, Nombre, Edad, FechaNacimiento, Categoria, Salario, Direccion, Telefono, Correo from Empleados
	end

--Creación del procedimiento almacenado para consultar la tabla empleados con filtros
create procedure ConsultarEmpleadosFiltro
@id int
as
	begin
		select Id, Carne, Nombre, Edad, FechaNacimiento, Categoria, Salario, Direccion, Telefono, Correo from Empleados where Id = @id
	end

--Creación del procedimiento almacenado para agregar proyectos
create procedure AgregarProyectos
@codigo int,
@nombre varchar(100),
@fechaInicio date,
@fechaFin date
as
	begin
		insert into Proyectos (Codigo, Nombre, FechaInicio, FechaFin) values (@codigo, @nombre, @fechaInicio, @fechaFin)
	end

--Creación del procedimiento almacenado para eliminar proyectos
create procedure BorrarProyectos
@id int
as
	begin
		delete Proyectos where Id = @id
	end

--Creación del procedimiento almacenado para consultar la tabla proyectos
create procedure ConsultarProyectos
as
	begin
		select Id, Codigo, Nombre, FechaInicio, FechaFin from Proyectos
	end

--Creación del procedimiento almacenado para agregar asignaciones
create procedure AgregarAsignaciones
@empleadoId int,
@proyectoId int,
@fechaAsignacion date
as
	begin
		insert into Asignaciones (EmpleadoId, ProyectoId, FechaAsignacion) values (@empleadoId, @proyectoId, @fechaAsignacion)
	end

--Creación del procedimiento almacenado para eliminar asignaciones
create procedure BorrarAsignaciones
@id int
as
	begin
		delete Asignaciones where Id = @id
	end

--Creación del procedimiento almacenado para consultar la tabla asignaciones
create procedure ConsultarAsignaciones
as
	begin
		select Id, EmpleadoId, ProyectoId, FechaAsignacion from Asignaciones
	end