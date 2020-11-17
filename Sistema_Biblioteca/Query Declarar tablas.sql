create database DB_SistemaBiblioteca
go

use DB_SistemaBiblioteca
go

------------------tablas-------------------
create table Tbl_Estudiantes(
id_Matricula int primary key,
nombre varchar(30) not null,
apellido varchar(30) not null,
telefono int,
direccion varchar(50),
tipo_Identificacion varchar (20) not null,
num_Identificacion int not null,
)
go

create table Tbl_Libros(
id_Signatura varchar(7) primary key,	--La signatura topográfica consta de el # de estante, 3 primeras letras apellido del autor  
titulo varchar(50) not null,			--y posicionen el librero basada en 3 caracteres    ej: 3MAR028
subtitulo varchar (50),
autor varchar (50) not null,
editorial varchar(50) not null,
genero varchar(50) not null,
año_Publicacion int not null
)
go

create table Tbl_Prestamos(
id_P int identity (1,1) primary key,
id_Estudiante int not null,
id_Libro varchar(7) not null,
f_Prestamo datetime not null
constraint FK_Estudiantes foreign key (id_Estudiante) references Tbl_Estudiantes(id_Matricula),
constraint FK_Libros foreign key (id_Libro) references Tbl_Libros(id_Signatura)
)
go