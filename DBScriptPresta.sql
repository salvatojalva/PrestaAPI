create database PrestaSistema
go
use PrestaSistema
go


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Categoria]

CREATE TABLE [Categoria]
(
 [IdCategoria] int identity(1,1) NOT NULL ,
 [Nombre]      nvarchar(50) NOT NULL ,
 [Created]     datetime NULL ,
 [Updated]     datetime NULL ,
 [Deleted]     datetime NULL ,
 [Activo]      bit NOT NULL ,


 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);
GO


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Producto]

CREATE TABLE [Producto]
(
 [IdProducto]  int identity(1,1) NOT NULL ,
 [Nombre]      nvarchar(50) NOT NULL ,
 [Created]     datetime NULL ,
 [Updated]     datetime NULL ,
 [Deleted]     datetime NULL ,
 [Activo]      bit NOT NULL ,
 [Precio]      money NOT NULL ,
 [IdCategoria] int NOT NULL ,


 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([IdProducto] ASC),
 CONSTRAINT [FK_87] FOREIGN KEY ([IdCategoria])  REFERENCES [Categoria]([IdCategoria])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_87] ON [Producto] 
 (
  [IdCategoria] ASC
 )

GO


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [ProductoInventario]

CREATE TABLE [ProductoInventario]
(
 [IdProductoInventario] int identity(1,1) NOT NULL ,
 [Nombre]               nvarchar(50) NOT NULL ,
 [Created]              datetime NULL ,
 [Updated]              datetime NULL ,
 [Deleted]              datetime NULL ,
 [CantidadTotal]        int NULL ,
 [CantidadActual]       int NULL ,
 [CantidadReservado]    int NULL ,
 [CantidadPrestado]     int NULL ,
 [IdProducto]           int NOT NULL ,


 CONSTRAINT [PK_ProductoInventario] PRIMARY KEY CLUSTERED ([IdProductoInventario] ASC),
 CONSTRAINT [FK_90] FOREIGN KEY ([IdProducto])  REFERENCES [Producto]([IdProducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_90] ON [ProductoInventario] 
 (
  [IdProducto] ASC
 )

GO


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Usuario]

CREATE TABLE [Usuario]
(
 [IdUsuario] int identity(1,1) NOT NULL ,
 [Usuario]   nvarchar(50) NOT NULL ,
 [Password]  nvarchar(50) NOT NULL ,


 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);
GO

-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Cliente]

CREATE TABLE [Cliente]
(
 [IdCliente] int identity(1,1) NOT NULL ,
 [Nombre]    nvarchar(50) NOT NULL ,
 [Apellido]  nvarchar(50) NOT NULL ,
 [Created]   datetime NOT NULL ,
 [Updated]   datetime NOT NULL ,
 [Deleted]   datetime NOT NULL ,
 [IdUsuario] int NOT NULL ,


 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([IdCliente] ASC),
 CONSTRAINT [FK_16] FOREIGN KEY ([IdUsuario])  REFERENCES [Usuario]([IdUsuario])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_16] ON [Cliente] 
 (
  [IdUsuario] ASC
 )

GO


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Encargado]

CREATE TABLE [Encargado]
(
 [IdEncargado] int identity(1,1) NOT NULL ,
 [Nombre]      nvarchar(50) NOT NULL ,
 [Apellido]    nvarchar(50) NOT NULL ,
 [Created]     datetime NOT NULL ,
 [Updated]     datetime NOT NULL ,
 [Deleted]     datetime NOT NULL ,
 [IdUsuario]   int NOT NULL ,


 CONSTRAINT [PK_Encargado] PRIMARY KEY CLUSTERED ([IdEncargado] ASC),
 CONSTRAINT [FK_99] FOREIGN KEY ([IdUsuario])  REFERENCES [Usuario]([IdUsuario])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_98] ON [Encargado] 
 (
  [IdUsuario] ASC
 )

GO

-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Reserva]

CREATE TABLE [Reserva]
(
 [IdReserva]            int identity(1,1) NOT NULL ,
 [Cantidad]             int NULL ,
 [Adelanto]             money NULL ,
 [Created]              datetime NULL ,
 [Updated]              datetime NULL ,
 [Deleted]              datetime NULL ,
 [IdCliente]            int NOT NULL ,
 [IdEncargado]          int NOT NULL ,
 [IdProductoInventario] int NOT NULL ,


 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED ([IdReserva] ASC),
 CONSTRAINT [FK_29] FOREIGN KEY ([IdCliente])  REFERENCES [Cliente]([IdCliente]),
 CONSTRAINT [FK_32] FOREIGN KEY ([IdEncargado])  REFERENCES [Encargado]([IdEncargado]),
 CONSTRAINT [FK_49] FOREIGN KEY ([IdProductoInventario])  REFERENCES [ProductoInventario]([IdProductoInventario])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_29] ON [Reserva] 
 (
  [IdCliente] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_32] ON [Reserva] 
 (
  [IdEncargado] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_49] ON [Reserva] 
 (
  [IdProductoInventario] ASC
 )

GO


-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Prestamo]

CREATE TABLE [Prestamo]
(
 [IdPrestamo]         int identity(1,1) NOT NULL ,
 [Cantidad]           int NULL ,
 [Created]            datetime NULL ,
 [Updated]            datetime NULL ,
 [Deleted]            datetime NULL ,
 [FechaPrestamo]      datetime NOT NULL ,
 [CantidadDias]       int NOT NULL ,
 [CantidadDiasReales] int NOT NULL ,
 [TotalPagado]        money NULL ,
 [IdEncargado]        int NOT NULL ,
 [IdReserva]          int NOT NULL ,


 CONSTRAINT [PK_Prestamo] PRIMARY KEY CLUSTERED ([IdPrestamo] ASC),
 CONSTRAINT [FK_69] FOREIGN KEY ([IdEncargado])  REFERENCES [Encargado]([IdEncargado]),
 CONSTRAINT [FK_72] FOREIGN KEY ([IdReserva])  REFERENCES [Reserva]([IdReserva])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_69] ON [Prestamo] 
 (
  [IdEncargado] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_72] ON [Prestamo] 
 (
  [IdReserva] ASC
 )

GO



-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ************************************** [Retorno]

CREATE TABLE [Retorno]
(
 [IdRetorno]    int identity(1,1) NOT NULL ,
 [Cantidad]     int NULL ,
 [Created]      datetime NULL ,
 [Updated]      datetime NULL ,
 [Deleted]      datetime NULL ,
 [FechaRetorno] datetime NOT NULL ,
 [Perdidas]     int NULL ,
 [Pagado]       money NULL ,
 [IdEncargado]  int NOT NULL ,
 [IdPrestamo]   int NOT NULL ,


 CONSTRAINT [PK_Retorno] PRIMARY KEY CLUSTERED ([IdRetorno] ASC),
 CONSTRAINT [FK_101] FOREIGN KEY ([IdEncargado])  REFERENCES [Encargado]([IdEncargado]),
 CONSTRAINT [FK_102] FOREIGN KEY ([IdPrestamo])  REFERENCES [Prestamo]([IdPrestamo])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_101] ON [Retorno] 
 (
  [IdEncargado] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_102] ON [Retorno] 
 (
  [IdPrestamo] ASC
 )

GO


insert into Usuario values ('salva', CONVERT(VARCHAR(32), HashBytes('MD5', 'salva'), 2));

