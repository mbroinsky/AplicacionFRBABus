SET NOCOUNT ON

BEGIN TRAN

-- Para poder correr el Script limpio de principio a Fin, deberíamos agregar todos los drops de tablas antes.
IF OBJECT_ID('NOT_NULL.Usuario') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Usuario
END

IF OBJECT_ID(N'NOT_NULL.FuncionalidadXRol') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.FuncionalidadXRol
END

IF OBJECT_ID(N'NOT_NULL.Funcionalidad') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Funcionalidad
END

IF OBJECT_ID(N'NOT_NULL.Rol') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Rol
END

IF OBJECT_ID(N'NOT_NULL.DevXpas') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.DevXPas
END

IF OBJECT_ID(N'NOT_NULL.DevXEnc') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.DevXEnc
END

IF OBJECT_ID(N'NOT_NULL.DevolucionVenta') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.DevolucionVenta
END

IF OBJECT_ID(N'NOT_NULL.Pasaje') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Pasaje
END

IF OBJECT_ID(N'NOT_NULL.Puntos') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Puntos
END

IF OBJECT_ID(N'NOT_NULL.Encomienda') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Encomienda
END

IF OBJECT_ID(N'NOT_NULL.Venta') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Venta
END

IF OBJECT_ID(N'NOT_NULL.Butaca') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Butaca
END

IF OBJECT_ID(N'NOT_NULL.Viaje') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Viaje
END

IF OBJECT_ID(N'NOT_NULL.Micro') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Micro
END

IF OBJECT_ID(N'NOT_NULL.Recorrido') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Recorrido
END

IF OBJECT_ID(N'NOT_NULL.Ciudad') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Ciudad
END

IF OBJECT_ID(N'NOT_NULL.Modelo') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Modelo
END

IF OBJECT_ID(N'NOT_NULL.Marca') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Marca
END

IF OBJECT_ID(N'NOT_NULL.TipoServicio') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.TipoServicio
END

IF OBJECT_ID(N'NOT_NULL.Canje') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Canje
END

IF OBJECT_ID(N'NOT_NULL.Producto') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Producto
END

IF OBJECT_ID(N'NOT_NULL.Cliente') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Cliente
END	

IF OBJECT_ID(N'NOT_NULL.Tarjeta') IS NOT NULL
BEGIN
    DROP TABLE NOT_NULL.Tarjeta
END

IF OBJECT_ID(N'NOT_NULL.ListarRoles') IS NOT NULL
BEGIN
    DROP PROCEDURE NOT_NULL.ListarRoles
END

IF OBJECT_ID(N'NOT_NULL.ListarRecorridos') IS NOT NULL
BEGIN
    DROP PROCEDURE NOT_NULL.ListarRecorridos
END

IF OBJECT_ID(N'NOT_NULL.CargarTablasSecundarias') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarTablasSecundarias;
END

IF OBJECT_ID(N'NOT_NULL.CargarMicros') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarMicros;
END

IF OBJECT_ID(N'NOT_NULL.CargarButacas') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarButacas;
END

IF OBJECT_ID(N'NOT_NULL.CargarRecorridos') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarRecorridos;
END

IF OBJECT_ID(N'NOT_NULL.CargarViajes') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarViajes;
END

IF OBJECT_ID(N'NOT_NULL.CargarVentasPasajes') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarVentasPasajes;
END

IF OBJECT_ID(N'NOT_NULL.CargarVentasEncomiendas') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.CargarVentasEncomiendas;
END

IF OBJECT_ID(N'NOT_NULL.RegistrarLlegadas') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.RegistrarLlegadas;
END

IF OBJECT_ID(N'NOT_NULL.RankingDestinos') IS NOT NULL
BEGIN
	DROP PROCEDURE NOT_NULL.RankingDestinos;
END

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'NOT_NULL')
BEGIN
	DROP SCHEMA NOT_NULL;
END
GO

CREATE SCHEMA NOT_NULL;
GO

-- Create Table: Encomienda
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Encomienda
(
	ENC_numEnc INT NOT NULL IDENTITY(1, 1)
        ,ENC_idVenta INT NOT NULL
	,ENC_codigo INT NOT NULL
	,ENC_idViaje INT NOT NULL
	,ENC_idCliente INT NOT NULL 
	,ENC_kilos DECIMAL(10, 2) NOT NULL 
	,ENC_precio DECIMAL(10, 2) NOT NULL
	,ENC_cancelada BIT NOT NULL DEFAULT 0
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Encomienda ADD CONSTRAINT PK_Encomienda PRIMARY KEY (ENC_numEnc)

-- Create Table: Butaca
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Butaca
(
	BUT_numeroAsiento INT NOT NULL
	,BUT_numMicro INT NOT NULL
	,BUT_tipo NVARCHAR(255) NOT NULL 
	,BUT_piso NUMERIC(18,0) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Butaca ADD CONSTRAINT PK_Butaca PRIMARY KEY (BUT_numeroAsiento, BUT_numMicro)

-- Create Table: Micro
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Micro
(
	MIC_numMicro INT NOT NULL IDENTITY(1, 1)
	,MIC_patente VARCHAR(7) NOT NULL 
	,MIC_idTipoServicio INT NOT NULL 
	,MIC_kilosEncomiendas DECIMAL(10, 2) NOT NULL 
	,MIC_habilitado BIT NOT NULL 
	,MIC_idMarca INT NOT NULL 
        ,MIC_idModelo INT NOT NULL 
	,MIC_fechaAlta DATETIME NOT NULL 
	,MIC_fueraDeServicio BIT NOT NULL 
	,MIC_fecFueraServ DATETIME  NULL 
	,MIC_fecReinicioServ DATETIME  NULL 
	,MIC_fecBaja DATETIME  NULL
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Micro ADD CONSTRAINT PK_Micro PRIMARY KEY (MIC_numMicro)
ALTER TABLE NOT_NULL.Micro ADD CONSTRAINT UQ_Patente UNIQUE (MIC_patente)


CREATE INDEX IDX_MICRO_PATENTE
on NOT_NULL.Micro(MIC_patente)
-- Create Table: Ciudad
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Ciudad
(
	CIU_idCiudad INT NOT NULL IDENTITY(1, 1)
	,CIU_nombre VARCHAR(250) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Ciudad ADD CONSTRAINT PK_Ciudad PRIMARY KEY (CIU_idCiudad)


-- Create Table: Viaje
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Viaje
(
	VIA_numViaje INT NOT NULL IDENTITY(1, 1)
	,VIA_numMicro INT NOT NULL
	,VIA_codRecorrido INT NOT NULL
	,VIA_fecSalida DATETIME NOT NULL 
	,VIA_fecLlegada DATETIME  NULL 
	,VIA_fecLlegadaEstimada DATETIME NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Viaje ADD CONSTRAINT PK_Viaje PRIMARY KEY CLUSTERED (VIA_numViaje)

--CREATE INDEX IDX_VIAJE_RECORRIDO
--on NOT_NULL.Viaje(VIA_codRecorrido)

CREATE INDEX IDX_VIAJE_RECORRIDO
on NOT_NULL.Viaje(VIA_codRecorrido, VIA_numMicro, VIA_fecSalida)
-- Create Table: Usuario
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Usuario
(
	USR_idUsuario INT NOT NULL IDENTITY(1, 1)
	,USR_idRol INT NOT NULL
	,USR_nick VARCHAR(20) NOT NULL 
	,USR_password VARCHAR(100) NOT NULL 
	,USR_nombre VARCHAR(30) NOT NULL 
	,USR_apellido VARCHAR(30) NOT NULL 
	,USR_intentos SMALLINT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED (USR_idUsuario)
ALTER TABLE NOT_NULL.Usuario ADD CONSTRAINT UQ_Nick UNIQUE (USR_nick)

-- Create Table: FuncionalidadXRol
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.FuncionalidadXRol
(
	FXR_idRol INT NOT NULL 
	,FXR_idFuncionalidad INT NOT NULL
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.FuncionalidadXRol ADD CONSTRAINT PK_FuncionalidadXRol PRIMARY KEY (FXR_idRol, FXR_idFuncionalidad)

-- Create Table: Funcionalidad
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Funcionalidad
(
	FNC_idFuncionalidad INT NOT NULL IDENTITY(1, 1)
	,FNC_nombre VARCHAR(50) NOT NULL 
	,FNC_formAsoc VARCHAR(50) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Funcionalidad ADD CONSTRAINT PK_Funcionalidad PRIMARY KEY (FNC_idFuncionalidad)

-- Create Table: Pasaje
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Pasaje
(
	PAS_numPasaje INT NOT NULL IDENTITY(1, 1)
	,PAS_idVenta INT NOT NULL
	,PAS_codigo INT NOT NULL
	,PAS_idViaje INT NOT NULL 
	,PAS_idCliente INT NOT NULL 
	,PAS_numButaca INT NOT NULL 
	,PAS_numMicro INT NOT NULL
	,PAS_precio DECIMAL(10,2) NOT NULL
	,PAS_cancelado BIT NOT NULL DEFAULT 0
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Pasaje ADD CONSTRAINT PK_Pasaje PRIMARY KEY CLUSTERED (PAS_numPasaje)

-- Create Table: Rol
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Rol
(
	ROL_idRol INT NOT NULL IDENTITY(1, 1)
	,ROL_nombre VARCHAR(20) NOT NULL
	,ROL_habilitado BIT NOT NULL DEFAULT 1
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Rol ADD CONSTRAINT PK_Rol PRIMARY KEY (ROL_idRol)

-- Create Table: Marca
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Marca
(
	MAR_idMarca INT NOT NULL IDENTITY(1, 1)
	,MAR_nombreMarca VARCHAR(20) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Marca ADD CONSTRAINT PK_Marca PRIMARY KEY (MAR_idMarca);

CREATE INDEX IDX_MAR_nombreMarca
on NOT_NULL.Marca(MAR_nombreMarca)

-- Create Table: Marca
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Modelo
(
	MOD_idModelo INT NOT NULL IDENTITY(1, 1),
	MOD_idMarca INT NOT NULL,
	MOD_nombreModelo VARCHAR(20) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Modelo ADD CONSTRAINT PK_Modelo PRIMARY KEY (MOD_idModelo)

-- Create Foreign Key: Modelo.MOD_idMarca -> Marca.MAR_idMarca
ALTER TABLE NOT_NULL.[Modelo] ADD CONSTRAINT
[FK_Modelo_MOD_idModelo_Marca_MAR_idMarca]
FOREIGN KEY (MOD_idMarca)
REFERENCES NOT_NULL.[Marca] ([MAR_idMarca])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Table: Cliente
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Cliente
(
	CLI_idCliente INT NOT NULL IDENTITY(1, 1)
	,CLI_nombre VARCHAR(30) NOT NULL 
	,CLI_apellido VARCHAR(30) NOT NULL 
	,CLI_dni DECIMAL(10, 0) NOT NULL 
	,CLI_direccion VARCHAR(50) NOT NULL 
	,CLI_telefono VARCHAR(15) NOT NULL 
	,CLI_mail VARCHAR(50)  NULL 
	,CLI_fecNacimiento DATETIME NOT NULL 
	,CLI_sexo CHAR NULL
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Cliente ADD CONSTRAINT PK_Cliente PRIMARY KEY CLUSTERED (CLI_idCliente)
ALTER TABLE NOT_NULL.Cliente ADD CONSTRAINT UQ_dni UNIQUE (CLI_dni)

CREATE INDEX IDX_DNI_CLIENTE
on NOT_NULL.Cliente(CLI_dni)
-- Create Table: Venta
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Venta
(
	VEN_idVenta INT NOT NULL IDENTITY(1, 1)
	,VEN_fecVenta DATETIME NOT NULL 
	,VEN_total DECIMAL(10, 2) NOT NULL 
	,VEN_idTarjeta INT  NULL 
	,VEN_discapacitado BIT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Venta ADD CONSTRAINT PK_Venta PRIMARY KEY CLUSTERED (VEN_idVenta)

-- Create Table: DevXPas
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.DevXPas
(
	DXP_idDevolucion INT NOT NULL 
	,DXP_idPasaje INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.DevXPas ADD CONSTRAINT PK_DevXPas PRIMARY KEY (DXP_idDevolucion, DXP_idPasaje)

-- Create Table: DevXEnc
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.DevXEnc
(
	DXE_idDevolucion INT NOT NULL 
	,DXE_idEncomienda INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.DevXEnc ADD CONSTRAINT PK_DevXEnc PRIMARY KEY (DXE_idDevolucion, DXE_idEncomienda)

-- Create Table: Tarjeta
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Tarjeta
(
	TAR_idTarjeta INT NOT NULL IDENTITY(1, 1)
	,TAR_nroTarjeta VARCHAR(20) NOT NULL 
	,TAR_fecVencimiento DATETIME NOT NULL 
	,TAR_tipo INT NOT NULL 
	,TAR_codSeg SMALLINT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Tarjeta ADD CONSTRAINT PK_Tarjeta PRIMARY KEY (TAR_idTarjeta)

-- Create Table: DevolucionVenta
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.DevolucionVenta
(
	DEV_idDevolucion INT NOT NULL IDENTITY(1, 1)
	,DEV_idVenta INT NOT NULL 
	,DEV_fecha DATETIME NOT NULL 
	,DEV_motivo VARCHAR(250) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.DevolucionVenta ADD CONSTRAINT PK_DevolucionVenta PRIMARY KEY (DEV_idDevolucion)

-- Create Table: Puntos
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Puntos
(	
	PTS_idPunto INT NOT NULL IDENTITY(1,1)
	,PTS_idCliente INT NOT NULL 
	,PTS_fecVencimiento DATETIME NOT NULL 
	,PTS_puntos INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Puntos ADD CONSTRAINT PK_Puntos PRIMARY KEY (PTS_idPunto)

-- Create Table: Producto
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Producto
(
	PRO_idProd INT NOT NULL IDENTITY(1, 1)
	,PRO_descripcion VARCHAR(60) NOT NULL 
	,PRO_stock INT NOT NULL 
	,PRO_puntos INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Producto ADD CONSTRAINT PK_Producto PRIMARY KEY (PRO_idProd)

-- Create Table: TipoServicio
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.TipoServicio
(
	SRV_idTipoServicio INT NOT NULL IDENTITY(1, 1) 
	,SRV_nombreServicio VARCHAR(50) NOT NULL 
	,SRV_porcentajeAdic DECIMAL(5, 2) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.TipoServicio ADD CONSTRAINT PK_TipoServicio PRIMARY KEY (SRV_idTipoServicio)

-- Create Table: Canje
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Canje
(
	CNJ_idCanje INT NOT NULL IDENTITY(1, 1)
	,CNJ_idCliente INT NOT NULL
	,CNJ_idProducto INT NOT NULL 
	,CNJ_fecCanje DATETIME NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Canje ADD CONSTRAINT PK_Canje PRIMARY KEY (CNJ_idCanje)

-- Create Table: Recorrido
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Recorrido
(
	REC_id INT NOT NULL IDENTITY(1, 1)
    ,REC_codigo NUMERIC(18,0) NOT NULL
    ,REC_idTipoServicio INT NOT NULL 
	,REC_idCiudadOrigen INT NOT NULL 
	,REC_idCiudadDestino INT NOT NULL 
 	,REC_precioBase DECIMAL(10, 2) NOT NULL 
	,REC_precioKilo DECIMAL(10, 2) NOT NULL 
	,REC_habilitado BIT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Recorrido ADD CONSTRAINT PK_Recorrido PRIMARY KEY (REC_id)
ALTER TABLE NOT_NULL.Recorrido ADD CONSTRAINT UQ_CodRec UNIQUE (REC_codigo)

-- Create Foreign Key: Recorrido.REC_idCiudadOrigen -> Ciudad.CIU_idCiudad
ALTER TABLE NOT_NULL.[Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idCiudadOrigen_Ciudad_CIU_idCiudad]
FOREIGN KEY ([REC_idCiudadOrigen])
REFERENCES NOT_NULL.[Ciudad] ([CIU_idCiudad])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Usuario.USR_idRol -> Rol.ROL_idRol
ALTER TABLE NOT_NULL.[Usuario] ADD CONSTRAINT
[FK_Usuario_USR_idRol_Rol_ROL_idRol]
FOREIGN KEY ([USR_idRol])
REFERENCES NOT_NULL.[Rol] ([ROL_idRol])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Micro.MIC_idMarca -> Marca.MAR_idMarca
ALTER TABLE NOT_NULL.[Micro] ADD CONSTRAINT
[FK_Micro_MIC_idMarca_Marca_MAR_idMarca]
FOREIGN KEY ([MIC_idMarca])
REFERENCES NOT_NULL.[Marca] ([MAR_idMarca])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Viaje.VIA_numMicro -> Micro.MIC_numMicro
ALTER TABLE NOT_NULL.[Viaje] ADD CONSTRAINT
[FK_Viaje_VIA_numMicro_Micro_MIC_numMicro]
FOREIGN KEY ([VIA_numMicro])
REFERENCES NOT_NULL.[Micro] ([MIC_numMicro])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Viaje.VIA_codRecorrido -> Recorrido.REC_codigo
ALTER TABLE NOT_NULL.[Viaje] ADD CONSTRAINT
[FK_Viaje_VIA_codRecorrido_Recorrido_REC_id]
FOREIGN KEY ([VIA_codRecorrido])
REFERENCES NOT_NULL.[Recorrido] ([REC_id])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Encomienda.ENC_idViaje -> Viaje.VIA_numViaje
ALTER TABLE NOT_NULL.[Encomienda] ADD CONSTRAINT
[FK_Encomienda_ENC_idViaje_Viaje_VIA_numViaje]
FOREIGN KEY ([ENC_idViaje])
REFERENCES NOT_NULL.[Viaje] ([VIA_numViaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Encomienda.ENC_idCliente -> Cliente.CLI_idCliente
ALTER TABLE NOT_NULL.[Encomienda] ADD CONSTRAINT
[FK_Encomienda_ENC_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([ENC_idCliente])
REFERENCES NOT_NULL.[Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Pasaje.PAS_idViaje -> Viaje.VIA_numViaje
ALTER TABLE NOT_NULL.[Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_idViaje_Viaje_VIA_numViaje]
FOREIGN KEY ([PAS_idViaje])
REFERENCES NOT_NULL.[Viaje] ([VIA_numViaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Pasaje.PAS_idCliente -> Cliente.CLI_idCliente
ALTER TABLE NOT_NULL.[Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([PAS_idCliente])
REFERENCES NOT_NULL.[Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Pasaje.PAS_numButaca -> Butaca.BUT_numeroAsiento
ALTER TABLE NOT_NULL.Pasaje ADD CONSTRAINT FK_Pasaje_PAS_numButaca_PAS_numMicro_Butaca_BUT_numeroAsiento_Butaca_BUT_numMicro
FOREIGN KEY (PAS_numButaca, PAS_numMicro)
REFERENCES NOT_NULL.Butaca(BUT_numeroAsiento, BUT_numMicro)
ON UPDATE NO ACTION
ON DELETE NO ACTION


-- Create Foreign Key: Pasaje.PAS_idVenta -> Venta.VEN_idVenta
ALTER TABLE NOT_NULL.[Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([PAS_idVenta])
REFERENCES NOT_NULL.[Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION


-- Create Foreign Key: Encomienda.ENC_idVenta -> Venta.VEN_idVenta
ALTER TABLE NOT_NULL.[Encomienda] ADD CONSTRAINT
[FK_Encomienda_ENC_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([ENC_idVenta])
REFERENCES NOT_NULL.[Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION


-- Create Foreign Key: Venta.VEN_idTarjeta -> Tarjeta.TAR_idTarjeta
ALTER TABLE NOT_NULL.[Venta] ADD CONSTRAINT
[FK_Venta_VEN_idTarjeta_Tarjeta_TAR_idTarjeta]
FOREIGN KEY ([VEN_idTarjeta])
REFERENCES NOT_NULL.[Tarjeta] ([TAR_idTarjeta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXPas.DXP_idDevolucion -> DevolucionVenta.DEV_idDevolucion
ALTER TABLE NOT_NULL.[DevXPas] ADD CONSTRAINT
[FK_DevXPas_DXP_idDevolucion_DevolucionVenta_DEV_idDevolucion]
FOREIGN KEY ([DXP_idDevolucion])
REFERENCES NOT_NULL.[DevolucionVenta] ([DEV_idDevolucion])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevolucionVenta.DEV_idVenta -> Venta.VEN_idVenta
ALTER TABLE NOT_NULL.[DevolucionVenta] ADD CONSTRAINT
[FK_DevolucionVenta_DEV_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([DEV_idVenta])
REFERENCES NOT_NULL.[Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXPas.DXP_idPasaje -> Pasaje.PAS_numPasaje
ALTER TABLE NOT_NULL.[DevXPas] ADD CONSTRAINT
[FK_DevXPas_DXP_idPasaje_Pasaje_PAS_numPasaje]
FOREIGN KEY ([DXP_idPasaje])
REFERENCES NOT_NULL.[Pasaje] ([PAS_numPasaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXEnc.DXE_idDevolucion -> DevolucionVenta.DEV_idDevolucion
ALTER TABLE NOT_NULL.[DevXEnc] ADD CONSTRAINT
[FK_DevXEnc_DXE_idDevolucion_DevolucionVenta_DEV_idDevolucion]
FOREIGN KEY ([DXE_idDevolucion])
REFERENCES NOT_NULL.[DevolucionVenta] ([DEV_idDevolucion])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXEnc.DXE_idEncomienda -> Encomienda.ENC_numEnc
ALTER TABLE NOT_NULL.[DevXEnc] ADD CONSTRAINT
[FK_DevXEnc_DXE_idEncomienda_Encomienda_ENC_numEnc]
FOREIGN KEY ([DXE_idEncomienda])
REFERENCES NOT_NULL.[Encomienda] ([ENC_numEnc])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Puntos.PTS_idCliente -> Cliente.CLI_idCliente
ALTER TABLE NOT_NULL.[Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([PTS_idCliente])
REFERENCES NOT_NULL.[Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Recorrido.REC_idCiudadDestino -> Ciudad.CIU_idCiudad
ALTER TABLE NOT_NULL.[Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idCiudadDestino_Ciudad_CIU_idCiudad]
FOREIGN KEY ([REC_idCiudadDestino])
REFERENCES NOT_NULL.[Ciudad] ([CIU_idCiudad])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Butaca.BUT_numMicro -> Micro.MIC_numMicro
ALTER TABLE NOT_NULL.[Butaca] ADD CONSTRAINT
[FK_Butaca_BUT_numMicro_Micro_MIC_numMicro]
FOREIGN KEY ([BUT_numMicro])
REFERENCES NOT_NULL.[Micro] ([MIC_numMicro])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Micro.MIC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE NOT_NULL.[Micro] ADD CONSTRAINT
[FK_Micro_MIC_idTipoServicio_TipoServicio_SRV_idTipoServicio]
FOREIGN KEY ([MIC_idTipoServicio])
REFERENCES NOT_NULL.[TipoServicio] ([SRV_idTipoServicio])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Micro.MIC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE NOT_NULL.[Micro] ADD CONSTRAINT
[FK_Micro_MIC_idModelo_Modelo_MOD_idModelo]
FOREIGN KEY ([MIC_idModelo])
REFERENCES NOT_NULL.[Modelo] ([MOD_idModelo])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: FuncionalidadXRol.FXR_idRol -> Rol.ROL_idRol
ALTER TABLE NOT_NULL.[FuncionalidadXRol] ADD CONSTRAINT
[FK_FuncionalidadXRol_FXR_idRol_Rol_ROL_idRol]
FOREIGN KEY ([FXR_idRol])
REFERENCES NOT_NULL.[Rol] ([ROL_idRol])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: FuncionalidadXRol.FXR_idFuncionalidad -> Funcionalidad.FNC_idFuncionalidad
ALTER TABLE NOT_NULL.[FuncionalidadXRol] ADD CONSTRAINT
[FK_FuncionalidadXRol_FXR_idFuncionalidad_Funcionalidad_FNC_idFuncionalidad]
FOREIGN KEY ([FXR_idFuncionalidad])
REFERENCES NOT_NULL.[Funcionalidad] ([FNC_idFuncionalidad])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Canje.CNJ_idProducto -> Producto.PRO_idProd
ALTER TABLE NOT_NULL.[Canje] ADD CONSTRAINT
[FK_Canje_CNJ_idProducto_Producto_PRO_idProd]
FOREIGN KEY ([CNJ_idProducto])
REFERENCES NOT_NULL.[Producto] ([PRO_idProd])
ON UPDATE NO ACTION
ON DELETE NO ACTION

-- Create Foreign Key: Canje.CNJ_idProducto -> Producto.PRO_idProd
ALTER TABLE NOT_NULL.[Canje] ADD CONSTRAINT
[FK_Canje_CNJ_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([CNJ_idCliente])
REFERENCES NOT_NULL.[Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION


-- Create Foreign Key: Recorrido.REC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE NOT_NULL.[Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idTipoServicio_TipoServicio_SRV_idTipoServicio]
FOREIGN KEY ([REC_idTipoServicio])
REFERENCES NOT_NULL.[TipoServicio] ([SRV_idTipoServicio])
ON UPDATE NO ACTION
ON DELETE NO ACTION

GO

--Acá se deberían agregar los SP

CREATE PROCEDURE NOT_NULL.CargarTablasSecundarias 
AS 
BEGIN
	DECLARE @idRol INT;

    	INSERT INTO Ciudad (CIU_nombre)  
		SELECT Distinct Recorrido_Ciudad_Destino as nombreCiudad
		FROM gd_esquema.Maestra
		union
		Select Recorrido_Ciudad_Origen as nombreCiudad
		from gd_esquema.Maestra
		order by nombreCiudad;
		
	INSERT INTO Marca (MAR_nombreMarca)
		SELECT DISTINCT Micro_Marca FROM gd_esquema.Maestra ORDER BY MICRO_MARCA;
		
		
	
	INSERT INTO NOT_NULL.Modelo (MOD_idMarca, MOD_nombreModelo)
		SELECT DISTINCT MAR_idMarca, Micro_Modelo FROM gd_esquema.Maestra, NOT_NULL.Marca
		WHERE Micro_Marca = MAR_nombreMarca
		ORDER BY MAR_idMarca;
		
	INSERT INTO TipoServicio (SRV_nombreServicio, SRV_porcentajeAdic)
		SELECT tipo_servicio, AVG((Pasaje_Precio - Recorrido_Precio_BasePasaje) / Recorrido_Precio_BasePasaje)
		FROM gd_esquema.Maestra WHERE Recorrido_Precio_BasePasaje <> 0
		GROUP BY tipo_servicio
		ORDER BY Tipo_Servicio;

    	INSERT INTO Cliente (CLI_nombre, CLI_apellido, CLI_dni, CLI_direccion,
	                 CLI_telefono, CLI_mail, CLI_fecNacimiento)
		SELECT DISTINCT	Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
		FROM gd_Esquema.Maestra;

	INSERT INTO Rol (ROL_nombre) Values ('Administrador');

	SELECT @idRol = ROL_idRol FROM Rol WHERE ROL_nombre = 'Administrador';

	INSERT INTO Usuario (USR_idRol, USR_nick, USR_password, USR_nombre,
			     USR_apellido, USR_intentos) VALUES
                (@idRol, 'admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 'Administrador', 'General', 0),
			    (@idRol, 'mireya', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 'Mireya', 'Mamani', 0),
			    (@idRol, 'jesús', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 'Jesús', 'Herrera', 0),
                (@idRol, 'maxi', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 'Maximiliano', 'Broinsky', 0);

	INSERT INTO Funcionalidad(FNC_nombre, FNC_formAsoc) VALUES
				('ABM de Rol', 'ABMRol'),
				('Listado de Roles', 'SeleccionRol'),
				('ABM Micro', 'ABMMicro'),
				('Generar Viaje', 'GenerarViaje'),
				('Registrar Llegadas', 'RegistrarLlegada'),
				('Listado de Recorridos', 'SeleccionRecorrido'),
				('ABM de Recorrido', 'ABMRecorrido'),
				('Listados Estadísticos', 'SeleccionListado');

        
	INSERT INTO FuncionalidadXRol (FXR_idRol, FXR_idFuncionalidad)
		SELECT @idRol, FNC_idFuncionalidad FROM Funcionalidad;
END
GO

CREATE PROCEDURE NOT_NULL.CargarMicros
AS
BEGIN
	INSERT INTO Micro (MIC_patente, MIC_idTipoServicio, MIC_kilosEncomiendas, MIC_habilitado 
			, MIC_idMarca, MIC_idModelo, MIC_fechaAlta,MIC_fueraDeServicio)
		SELECT DISTINCT left(Micro_Patente, 7), SRV_idTipoServicio, Micro_KG_Disponibles,
                       1, MAR_idMarca, MOD_idMarca, CURRENT_TIMESTAMP, 0
		FROM gd_Esquema.Maestra, Marca, Modelo, TipoServicio
		WHERE	Tipo_Servicio = SRV_nombreServicio and Micro_Marca = MAR_nombreMarca
		AND		MAR_idMarca = MOD_idMarca
		AND		MOD_nombreModelo = Micro_Modelo;
END
GO

CREATE PROCEDURE NOT_NULL.CargarButacas 
AS 
BEGIN
    INSERT INTO Butaca (BUT_numeroAsiento, BUT_numMicro, BUT_tipo, BUT_piso)
		SELECT DISTINCT Butaca_Nro, MIC_numMicro, Butaca_Tipo, Butaca_Piso
		FROM gd_Esquema.Maestra, Micro
		WHERE Micro_Patente = Micro.MIC_patente AND Butaca_Piso <> 0;
END
GO

CREATE PROCEDURE NOT_NULL.CargarRecorridos 
AS 
BEGIN
    INSERT INTO Recorrido (REC_idTipoServicio, REC_idCiudadOrigen,
			REC_idCiudadDestino,REC_codigo,REC_precioBase,REC_precioKilo
                        ,REC_habilitado)
		SELECT SRV_idTipoServicio, a.CIU_idCiudad, b.CIU_idCiudad, Recorrido_Codigo, 
			max(Recorrido_Precio_BasePasaje), max(Recorrido_Precio_BaseKG), 1
		FROM gd_Esquema.Maestra, Ciudad as a, Ciudad as b, TipoServicio
		WHERE Recorrido_Ciudad_Origen = a.CIU_nombre and
  		      Recorrido_Ciudad_Destino = b.CIU_nombre and
                      SRV_nombreServicio = Tipo_Servicio
        Group by Recorrido_Codigo, a.CIU_idCiudad, b.CIU_idCiudad, SRV_idTipoServicio;
END
GO


CREATE PROCEDURE NOT_NULL.CargarViajes 
AS 
BEGIN
    INSERT INTO Viaje (	VIA_numMicro, VIA_codRecorrido, VIA_fecSalida, VIA_fecLlegada,VIA_fecLlegadaEstimada)
		SELECT DISTINCT	MIC_numMicro, REC_id, FechaSalida, FechaLLegada, Fecha_LLegada_Estimada
		FROM gd_Esquema.Maestra, Micro, Recorrido
		WHERE Micro_Patente = MIC_patente AND Recorrido_Codigo = REC_Codigo;
END
GO

CREATE PROCEDURE NOT_NULL.CargarVentasPasajes
AS
BEGIN
DECLARE
	@idVenta int,
	@puntosObtenidos int,	
	@pasajeCodigo int,
	@pasajePrecio decimal(10,2),
	@pasajeFechaCompra datetime,
	@clienteDNI int,
	@clienteId int,
	@recorridoCodigo int,
	@viajeId int,
	@microPatente varchar (7),
	@microId int,
	@numeroButaca int,
	@fechaLlegada datetime,
	@fechaSalida datetime

DECLARE VENTAPASAJESCUR CURSOR 
FOR
SELECT DISTINCT 
	Pasaje_Codigo,
	Pasaje_Precio,
	Pasaje_FechaCompra,
	Cli_Dni,
	REC_id,
	Micro_patente,
	Butaca_Nro,
	FechaSalida,
	FechaLlegada
FROM
	gd_esquema.Maestra,
	NOT_NULL.recorrido
WHERE Pasaje_Codigo <> 0 AND
	REC_Codigo = Recorrido_codigo

OPEN VENTAPASAJESCUR

FETCH VENTAPASAJESCUR INTO	
	@pasajeCodigo, 
	@pasajePrecio,
	@pasajeFechaCompra,
	@clienteDNI,
	@recorridoCodigo,
	@microPatente,
	@numeroButaca,
	@fechaSalida,
	@fechaLlegada
	
	WHILE (@@FETCH_STATUS = 0 )

	BEGIN

		SELECT @clienteId = CLI_idCliente 
		FROM  NOT_NULL.Cliente
		WHERE @clienteDNI = CLI_dni;
		
		SELECT DISTINCT @microId = MIC_numMicro
		FROM  NOT_NULL.Micro
		WHERE @microPatente = MIC_patente;

		SELECT DISTINCT @viajeId = VIA_numViaje
		FROM  NOT_NULL.Viaje
		WHERE @recorridoCodigo = VIA_codRecorrido AND 
		      VIA_numMicro = @microId AND 
		      VIA_fecSalida = @fechaSalida;
		      		

		INSERT INTO NOT_NULL.Venta(VEN_fecVenta, VEN_total, VEN_idTarjeta, VEN_discapacitado)
		VALUES (@pasajeFechaCompra, @pasajePrecio, null, 0)
		
		SET @idVenta = @@IDENTITY
		
		INSERT INTO NOT_NULL.Pasaje(PAS_idVenta, PAS_codigo, PAS_idViaje, PAS_idCliente, PAS_numButaca, PAS_numMicro, PAS_precio)
		VALUES(@idVenta, @pasajeCodigo,@viajeId ,@clienteId, @numeroButaca, @microId, @pasajePrecio)
		
		SET @puntosObtenidos = FLOOR(@pasajePrecio/5)
		
		INSERT INTO NOT_NULL.Puntos (PTS_idCliente, PTS_puntos, PTS_fecVencimiento)
		VALUES (@clienteId, @puntosObtenidos, DATEADD(YEAR, 1, @fechaLlegada))
		
		FETCH VENTAPASAJESCUR INTO	
			@pasajeCodigo, 
			@pasajePrecio,
			@pasajeFechaCompra,
			@clienteDNI,
			@recorridoCodigo,
			@microPatente,
			@numeroButaca,
			@fechaSalida,
			@fechaLlegada
	END
	
CLOSE VENTAPASAJESCUR
DEALLOCATE VENTAPASAJESCUR;
END
GO

CREATE PROCEDURE NOT_NULL.CargarVentasEncomiendas
AS
BEGIN
DECLARE
	@idVenta int,
	@puntosObtenidos int,
	@paqueteCodigo int,
	@paquetePrecio decimal(10,2),
	@paqueteFechaCompra datetime,
	@clienteDNI int,
	@clienteId int,
	@recorridoCodigo int,
	@viajeId int,
	@paqueteKG int,
	@idEncomienda int,
	@fechaLlegada datetime,
	@fechaSalida datetime,
	@microPatente varchar(7),
	@microId int

DECLARE VENTAENCOMIENDACUR CURSOR 
FOR
SELECT DISTINCT 
	Paquete_Codigo,
	Paquete_Precio,
	Paquete_FechaCompra,
	Cli_Dni,
	REC_id,
	Paquete_KG,
	Micro_Patente,
	FechaLlegada,
	FechaSalida
FROM
	gd_esquema.Maestra,
	NOT_NULL.Recorrido
WHERE Paquete_Codigo <> 0 AND
	REC_Codigo = Recorrido_Codigo

OPEN VENTAENCOMIENDACUR

FETCH VENTAENCOMIENDACUR INTO	
	@paqueteCodigo, 
	@paquetePrecio,
	@paqueteFechaCompra,
	@clienteDNI,
	@recorridoCodigo,
	@paqueteKG,
	@microPatente,
	@fechaLlegada,
	@fechaSalida
	
	WHILE (@@FETCH_STATUS = 0 )

	BEGIN

		SELECT @clienteId = CLI_idCliente 
		FROM  NOT_NULL.Cliente
		WHERE @clienteDNI = CLI_dni
		
		SELECT DISTINCT @microId = MIC_numMicro
		FROM  NOT_NULL.Micro
		WHERE @microPatente = MIC_patente;

		SELECT DISTINCT @viajeId = VIA_numViaje
		FROM  NOT_NULL.Viaje
		WHERE @recorridoCodigo = VIA_codRecorrido AND 
		      VIA_numMicro = @microId AND 
		      VIA_fecSalida = @fechaSalida;
	
		INSERT INTO NOT_NULL.Venta(VEN_fecVenta, VEN_total, VEN_idTarjeta, VEN_discapacitado)
		VALUES (@paqueteFechaCompra, @paquetePrecio, null, 0)
		
		SET @idVenta = @@IDENTITY
		
		INSERT INTO NOT_NULL.Encomienda(ENC_idVenta, ENC_codigo, ENC_idViaje, ENC_idCliente, ENC_kilos, ENC_precio)
		VALUES(@@IDENTITY, @paqueteCodigo, @viajeId ,@clienteId, @paqueteKG, @paquetePrecio)
		
		SET @puntosObtenidos = FLOOR(@paquetePrecio/5)
		
		INSERT INTO NOT_NULL.Puntos (PTS_idCliente, PTS_puntos, PTS_fecVencimiento)
		VALUES (@clienteId, @puntosObtenidos, DATEADD(YEAR, 1, @fechaLlegada))
		
		FETCH VENTAENCOMIENDACUR INTO	
			@paqueteCodigo, 
			@paquetePrecio,
			@paqueteFechaCompra,
			@clienteDNI,
			@recorridoCodigo,
			@paqueteKG,
			@microPatente,
			@fechaLlegada,
			@fechaSalida
	END
		
CLOSE VENTAENCOMIENDACUR
DEALLOCATE VENTAENCOMIENDACUR;
END
GO

--Acá se deben correr los SP de migracion

EXECUTE NOT_NULL.CargarTablasSecundarias;
EXECUTE NOT_NULL.CargarMicros;
EXECUTE NOT_NULL.CargarButacas;
EXECUTE NOT_NULL.CargarRecorridos;
EXECUTE NOT_NULL.CargarViajes;
EXECUTE NOT_NULL.cargarVentasPasajes;
EXECUTE NOT_NULL.cargarVentasEncomiendas;
GO

--Acá se deben borrar los SP de migracion

DROP PROCEDURE NOT_NULL.CargarTablasSecundarias;
DROP PROCEDURE NOT_NULL.CargarMicros;
DROP PROCEDURE NOT_NULL.CargarButacas;
DROP PROCEDURE NOT_NULL.CargarRecorridos;
DROP PROCEDURE NOT_NULL.CargarViajes;
DROP PROCEDURE NOT_NULL.CargarVentasPasajes;
DROP PROCEDURE NOT_NULL.CargarVentasEncomiendas;

GO

--Acá creamos los SP de Aplicacion
CREATE PROCEDURE NOT_NULL.ListarRoles
	@ID int = NULL,
	@NOMBRE nvarchar(20) = NULL 
AS 
BEGIN
    DECLARE @WHERE varchar(500)
    DECLARE @SQL varchar(500)
    
    SET @WHERE = '';
	
	IF (@ID IS NOT NULL)
		SET @WHERE = @WHERE + 'ROL_idRol = ''' + CONVERT(varchar,@ID) + ''' AND ';
	
	IF (@NOMBRE IS NOT NULL)
		SET @WHERE = @WHERE + 'ROL_nombre LIKE ''%' + @NOMBRE + '%'' AND ';
	
	SET @SQL = 'SELECT ROL_idRol AS ID, ROL_nombre AS Nombre, ROL_habilitado AS Habilitado FROM NOT_NULL.ROL WHERE ' + @WHERE + ' 1=1;'
        
	EXEC (@SQL);
END
GO

--Acá creamos los SP de Aplicacion
CREATE PROCEDURE NOT_NULL.ListarRecorridos
	@ID int = NULL,
	@CODIGO nvarchar(20) = NULL,
	@ID_TIPO_SERV int = NULL,
	@ID_CIU_ORIGEN int = NULL,
	@ID_CIU_DESTINO int = NULL,
	@HABILITADO bit = NULL 
AS 
BEGIN
    DECLARE @WHERE varchar(500)
    DECLARE @SQL varchar(1000)
    
    SET @WHERE = '';
	
	IF (@ID IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_id = ''' + CONVERT(varchar,@ID) + ''' AND ';
	
	IF (@CODIGO IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_CODIGO LIKE ''%' + @CODIGO + '%'' AND ';
		
	IF (@ID_TIPO_SERV IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_idTipoServicio = ''' + CONVERT(varchar,@ID_TIPO_SERV) + ''' AND ';
		
	IF (@ID_CIU_ORIGEN IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_idCiudadOrigen = ''' + CONVERT(varchar,@ID_CIU_ORIGEN) + ''' AND ';
		
	IF (@ID_CIU_DESTINO IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_idCiudadDestino = ''' + CONVERT(varchar,@ID_CIU_DESTINO) + ''' AND ';
		
	IF (@HABILITADO IS NOT NULL)
		SET @WHERE = @WHERE + 'REC_habilitado = ''' + CONVERT(varchar,@HABILITADO) + ''' AND ';

	
	SET @SQL = 'SELECT REC_id AS ID, REC_codigo AS Codigo, a.CIU_Nombre as Origen, b.CIU_nombre as Destino, '
	SET @SQL = @SQL + 'SRV_nombreServicio as Servicio, REC_precioBase as ''Precio Base'','
	SET @SQL = @SQL + 'REC_precioKilo as ''Precio Kilo'', REC_habilitado as Habilitado ' 
	SET @SQL = @SQL + 'FROM NOT_NULL.Recorrido, NOT_NULL.Ciudad a, NOT_NULL.Ciudad b, NOT_NULL.TipoServicio '
	SET @SQL = @SQL + 'WHERE  ' + @WHERE + ' REC_idCiudadOrigen = a.CIU_idCiudad AND REC_idCiudadDestino = b.CIU_idCiudad '
	SET @SQL = @SQL + 'AND REC_idTipoServicio = SRV_idTipoServicio ORDER BY ID;'
        
	EXEC (@SQL);
END
GO

CREATE PROCEDURE NOT_NULL.RegistrarLlegadas
    @fecLlegada DATETIME,
    @idMicro INT,
    @idCiuOri INT,
    @idCiuDest INT 
AS 
BEGIN
	DECLARE @idViaje INT,
			@idRecorrido INT,
			@idTipServicio INT

	SELECT @idTipServicio = MIC_idTipoServicio FROM
		NOT_NULL.Micro WHERE @idMicro = MIC_numMicro;
	
	SELECT @idRecorrido = REC_id FROM
		NOT_NULL.Recorrido WHERE 
		REC_idCiudadOrigen = @idCiuOri AND
		REC_idCiudadDestino = @idCiuDest AND
		REC_idTipoServicio = @idTipServicio;
	
	SELECT @idViaje = VIA_numViaje FROM
		NOT_NULL.Viaje WHERE VIA_numMicro = @idMicro AND
		VIA_codRecorrido = @idRecorrido AND
		VIA_fecLlegada IS NULL AND DATEDIFF(day, VIA_fecSalida, @fecLlegada) < 1;
	
	IF @idViaje IS NOT NULL
	BEGIN
		-- Registra llegada
		UPDATE NOT_NULL.Viaje SET VIA_fecLlegada = @fecLlegada WHERE VIA_numViaje = @idViaje;
			
		-- Inserta Puntos
		INSERT INTO NOT_NULL.Puntos (PTS_idCliente, PTS_puntos, PTS_fecVencimiento) 
		SELECT PAS_idCliente, FLOOR(PAS_precio/5), DATEADD(YEAR, 1, @fecLlegada)	 
		FROM NOT_NULL.Pasaje
		WHERE PAS_idViaje = @idViaje AND PAS_cancelado <> 1;
			
		INSERT INTO NOT_NULL.Puntos (PTS_idCliente, PTS_puntos, PTS_fecVencimiento) 
		SELECT ENC_idCliente, FLOOR(ENC_precio / 5), DATEADD(YEAR, 1, @fecLlegada)	 
		FROM NOT_NULL.Encomienda
		WHERE ENC_idViaje = @idViaje AND ENC_cancelada <> 1;
	END 
END
GO

CREATE PROCEDURE NOT_NULL.RankingDestinos
    @fecInicio SMALLDATETIME,
    @fecFin SMALLDATETIME
AS 
BEGIN
	SELECT TOP 5 CIU_nombre as Destino, COUNT(*) as 'Cantidad Pasajes'
	FROM Ciudad, Recorrido, Viaje, Pasaje
	WHERE REC_idCiudadDestino = CIU_idCiudad AND VIA_codRecorrido = REC_id AND VIA_fecSalida BETWEEN @fecInicio AND @fecFin
		AND PAS_idVIaje = VIA_numViaje
	GROUP BY CIU_idCiudad, CIU_nombre
	ORDER BY COUNT(*) DESC;	 
END
GO

CREATE PROCEDURE NOT_NULL.RankingDestinosXPasajesCancelados
    @fecInicio SMALLDATETIME,
    @fecFin SMALLDATETIME
AS 
BEGIN
	SELECT TOP 5 CIU_nombre as Destino, COUNT(*) as 'Pasajes cancelados'
	FROM Viaje, Recorrido, Ciudad, Pasaje 
	WHERE REC_idCiudadDestino = CIU_idCiudad AND VIA_codRecorrido = REC_id AND VIA_fecSalida BETWEEN @fecInicio AND @fecFin
		AND PAS_idViaje = VIA_numViaje AND PAS_cancelado = 1
	GROUP BY CIU_idCiudad, CIU_nombre
	ORDER BY COUNT(*) DESC;	 
END
GO

CREATE PROCEDURE NOT_NULL.RankingClientesXPuntosAcumulados
    @fecInicio SMALLDATETIME,
    @fecFin SMALLDATETIME
AS 
BEGIN
	SELECT TOP 5 CLI_nombre as Nombre, SUM(PTS_puntos) as 'Puntos Acumulados'
	FROM Cliente, Puntos 
	WHERE PTS_idCliente = CLI_idCliente AND 
		dateadd(year, -1, PTS_fecVencimiento) BETWEEN @fecInicio AND @fecFin
	GROUP BY CLI_idCLiente, CLI_nombre
	ORDER BY SUM(PTS_puntos) DESC;	 
END
GO

--FIN
COMMIT;

SET NOCOUNT OFF
