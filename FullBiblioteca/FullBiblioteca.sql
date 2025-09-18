-- Script SQL generado: FullBiblioteca
IF DB_ID('FullBiblioteca') IS NOT NULL DROP DATABASE FullBiblioteca;
CREATE DATABASE FullBiblioteca;
GO
USE FullBiblioteca;
GO

IF OBJECT_ID('Autors', 'U') IS NOT NULL DROP TABLE [Autors];
CREATE TABLE [Autors] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Autors] (Nombre) VALUES (N'Autor 1');
INSERT INTO [Autors] (Nombre) VALUES (N'Autor 2');
INSERT INTO [Autors] (Nombre) VALUES (N'Autor 3');
INSERT INTO [Autors] (Nombre) VALUES (N'Autor 4');
INSERT INTO [Autors] (Nombre) VALUES (N'Autor 5');

IF OBJECT_ID('Cargos', 'U') IS NOT NULL DROP TABLE [Cargos];
CREATE TABLE [Cargos] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Cargos] (Nombre) VALUES (N'Cargo 1');
INSERT INTO [Cargos] (Nombre) VALUES (N'Cargo 2');
INSERT INTO [Cargos] (Nombre) VALUES (N'Cargo 3');
INSERT INTO [Cargos] (Nombre) VALUES (N'Cargo 4');
INSERT INTO [Cargos] (Nombre) VALUES (N'Cargo 5');

IF OBJECT_ID('Categorias', 'U') IS NOT NULL DROP TABLE [Categorias];
CREATE TABLE [Categorias] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Categorias] (Nombre) VALUES (N'Categoria 1');
INSERT INTO [Categorias] (Nombre) VALUES (N'Categoria 2');
INSERT INTO [Categorias] (Nombre) VALUES (N'Categoria 3');
INSERT INTO [Categorias] (Nombre) VALUES (N'Categoria 4');
INSERT INTO [Categorias] (Nombre) VALUES (N'Categoria 5');

IF OBJECT_ID('Ciudads', 'U') IS NOT NULL DROP TABLE [Ciudads];
CREATE TABLE [Ciudads] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Ciudads] (Nombre) VALUES (N'Ciudad 1');
INSERT INTO [Ciudads] (Nombre) VALUES (N'Ciudad 2');
INSERT INTO [Ciudads] (Nombre) VALUES (N'Ciudad 3');
INSERT INTO [Ciudads] (Nombre) VALUES (N'Ciudad 4');
INSERT INTO [Ciudads] (Nombre) VALUES (N'Ciudad 5');

IF OBJECT_ID('Editorials', 'U') IS NOT NULL DROP TABLE [Editorials];
CREATE TABLE [Editorials] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Editorials] (Nombre) VALUES (N'Editorial 1');
INSERT INTO [Editorials] (Nombre) VALUES (N'Editorial 2');
INSERT INTO [Editorials] (Nombre) VALUES (N'Editorial 3');
INSERT INTO [Editorials] (Nombre) VALUES (N'Editorial 4');
INSERT INTO [Editorials] (Nombre) VALUES (N'Editorial 5');

IF OBJECT_ID('Empleados', 'U') IS NOT NULL DROP TABLE [Empleados];
CREATE TABLE [Empleados] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Empleados] (Nombre) VALUES (N'Empleado 1');
INSERT INTO [Empleados] (Nombre) VALUES (N'Empleado 2');
INSERT INTO [Empleados] (Nombre) VALUES (N'Empleado 3');
INSERT INTO [Empleados] (Nombre) VALUES (N'Empleado 4');
INSERT INTO [Empleados] (Nombre) VALUES (N'Empleado 5');

IF OBJECT_ID('Idiomas', 'U') IS NOT NULL DROP TABLE [Idiomas];
CREATE TABLE [Idiomas] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Idiomas] (Nombre) VALUES (N'Idioma 1');
INSERT INTO [Idiomas] (Nombre) VALUES (N'Idioma 2');
INSERT INTO [Idiomas] (Nombre) VALUES (N'Idioma 3');
INSERT INTO [Idiomas] (Nombre) VALUES (N'Idioma 4');
INSERT INTO [Idiomas] (Nombre) VALUES (N'Idioma 5');

IF OBJECT_ID('Libros', 'U') IS NOT NULL DROP TABLE [Libros];
CREATE TABLE [Libros] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Libros] (Nombre) VALUES (N'Libro 1');
INSERT INTO [Libros] (Nombre) VALUES (N'Libro 2');
INSERT INTO [Libros] (Nombre) VALUES (N'Libro 3');
INSERT INTO [Libros] (Nombre) VALUES (N'Libro 4');
INSERT INTO [Libros] (Nombre) VALUES (N'Libro 5');

IF OBJECT_ID('Miembros', 'U') IS NOT NULL DROP TABLE [Miembros];
CREATE TABLE [Miembros] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Miembros] (Nombre) VALUES (N'Miembro 1');
INSERT INTO [Miembros] (Nombre) VALUES (N'Miembro 2');
INSERT INTO [Miembros] (Nombre) VALUES (N'Miembro 3');
INSERT INTO [Miembros] (Nombre) VALUES (N'Miembro 4');
INSERT INTO [Miembros] (Nombre) VALUES (N'Miembro 5');

IF OBJECT_ID('Multas', 'U') IS NOT NULL DROP TABLE [Multas];
CREATE TABLE [Multas] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Multas] (Nombre) VALUES (N'Multa 1');
INSERT INTO [Multas] (Nombre) VALUES (N'Multa 2');
INSERT INTO [Multas] (Nombre) VALUES (N'Multa 3');
INSERT INTO [Multas] (Nombre) VALUES (N'Multa 4');
INSERT INTO [Multas] (Nombre) VALUES (N'Multa 5');

IF OBJECT_ID('Pagos', 'U') IS NOT NULL DROP TABLE [Pagos];
CREATE TABLE [Pagos] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Pagos] (Nombre) VALUES (N'Pago 1');
INSERT INTO [Pagos] (Nombre) VALUES (N'Pago 2');
INSERT INTO [Pagos] (Nombre) VALUES (N'Pago 3');
INSERT INTO [Pagos] (Nombre) VALUES (N'Pago 4');
INSERT INTO [Pagos] (Nombre) VALUES (N'Pago 5');

IF OBJECT_ID('Paiss', 'U') IS NOT NULL DROP TABLE [Paiss];
CREATE TABLE [Paiss] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Paiss] (Nombre) VALUES (N'Pais 1');
INSERT INTO [Paiss] (Nombre) VALUES (N'Pais 2');
INSERT INTO [Paiss] (Nombre) VALUES (N'Pais 3');
INSERT INTO [Paiss] (Nombre) VALUES (N'Pais 4');
INSERT INTO [Paiss] (Nombre) VALUES (N'Pais 5');

IF OBJECT_ID('Prestamos', 'U') IS NOT NULL DROP TABLE [Prestamos];
CREATE TABLE [Prestamos] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Prestamos] (Nombre) VALUES (N'Prestamo 1');
INSERT INTO [Prestamos] (Nombre) VALUES (N'Prestamo 2');
INSERT INTO [Prestamos] (Nombre) VALUES (N'Prestamo 3');
INSERT INTO [Prestamos] (Nombre) VALUES (N'Prestamo 4');
INSERT INTO [Prestamos] (Nombre) VALUES (N'Prestamo 5');

IF OBJECT_ID('Reservas', 'U') IS NOT NULL DROP TABLE [Reservas];
CREATE TABLE [Reservas] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Reservas] (Nombre) VALUES (N'Reserva 1');
INSERT INTO [Reservas] (Nombre) VALUES (N'Reserva 2');
INSERT INTO [Reservas] (Nombre) VALUES (N'Reserva 3');
INSERT INTO [Reservas] (Nombre) VALUES (N'Reserva 4');
INSERT INTO [Reservas] (Nombre) VALUES (N'Reserva 5');

IF OBJECT_ID('Sucursals', 'U') IS NOT NULL DROP TABLE [Sucursals];
CREATE TABLE [Sucursals] (Id INT IDENTITY(1,1) PRIMARY KEY, Nombre NVARCHAR(200) NOT NULL, FechaRegistro DATETIME2 NOT NULL DEFAULT(GETUTCDATE()));
INSERT INTO [Sucursals] (Nombre) VALUES (N'Sucursal 1');
INSERT INTO [Sucursals] (Nombre) VALUES (N'Sucursal 2');
INSERT INTO [Sucursals] (Nombre) VALUES (N'Sucursal 3');
INSERT INTO [Sucursals] (Nombre) VALUES (N'Sucursal 4');
INSERT INTO [Sucursals] (Nombre) VALUES (N'Sucursal 5');
