CREATE DATABASE ClientesDB;
GO
USE ClientesDB;
GO

CREATE TABLE CLIENTES_GYM(DNI VARCHAR (8) PRIMARY KEY, NOMBRE VARCHAR(30) NOT NULL,APELLIDO VARCHAR (30) NOT NULL,
FECHA_NAC DATE NOT NULL, DIRECCION VARCHAR (30) NOT NULL, FECHA_PAGO DATE NOT NULL);