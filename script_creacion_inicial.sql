BEGIN TRANSACTION

-- Para poder correr el Script limpio de principio a Fin, deberíamos agregar todos los drops de tablas antes.
IF OBJECT_ID(N'NOT_NULL.Usuario') IS NOT NULL
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
GO

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
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Encomienda ADD CONSTRAINT PK_Encomienda PRIMARY KEY (ENC_numEnc)

-- Create Table: Butaca
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Butaca
(
	BUT_numeroAsiento INT NOT NULL
	,BUT_numMicro INT NOT NULL
	,BUT_tipo VARCHAR(7) NOT NULL 
	,BUT_piso INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Butaca ADD CONSTRAINT PK_Butaca PRIMARY KEY (BUT_numeroAsiento)

-- Create Table: Micro
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Micro
(
	MIC_numMicro INT NOT NULL IDENTITY(1, 1)
	,MIC_patente VARCHAR(6) NOT NULL 
	,MIC_idTipoServicio INT NOT NULL 
	,MIC_kilosEncomiendas DECIMAL(10, 2) NOT NULL 
	,MIC_habilitado BIT NOT NULL 
	,MIC_idMarca INT NOT NULL 
    ,MIC_modelo VARCHAR(20) NULL
	,MIC_fechaAlta DATETIME NOT NULL 
	,MIC_fueraDeServicio BIT NOT NULL 
	,MIC_fecFueraServ DATETIME  NULL 
	,MIC_fecReinicioServ DATETIME  NULL 
	,MIC_fecBaja DATETIME  NULL
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Micro ADD CONSTRAINT PK_Micro PRIMARY KEY (MIC_numMicro)

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
	,VIA_idRecorrido INT NOT NULL
	,VIA_fecSalida DATETIME NOT NULL 
	,VIA_fecLlegada DATETIME  NULL 
	,VIA_fecLlegadaEstimada DATETIME NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Viaje ADD CONSTRAINT PK_Viaje PRIMARY KEY CLUSTERED (VIA_numViaje)

-- Create Table: Usuario
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Usuario
(
	USR_idUsuario INT NOT NULL IDENTITY(1, 1)
	,USR_idRol INT NOT NULL
	,USR_nick VARCHAR(20) NOT NULL 
	,USR_password VARCHAR(50) NOT NULL 
	,USR_nombre VARCHAR(30) NOT NULL 
	,USR_apellido VARCHAR(30) NOT NULL 
	,USR_intentos SMALLINT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED (USR_idUsuario)

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
	,PAS_precio DECIMAL(10,2) NOT NULL
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Pasaje ADD CONSTRAINT PK_Pasaje PRIMARY KEY CLUSTERED (PAS_numPasaje)

-- Create Table: Rol
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Rol
(
	ROL_idRol INT NOT NULL IDENTITY(1, 1)
	,ROL_nombre VARCHAR(250) NOT NULL 
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
ALTER TABLE NOT_NULL.Marca ADD CONSTRAINT PK_Marca PRIMARY KEY (MAR_idMarca)

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
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Cliente ADD CONSTRAINT PK_Cliente PRIMARY KEY CLUSTERED (CLI_idCliente)

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
ALTER TABLE NOT_NULL.DevXPas ADD CONSTRAINT PK_DevXPas PRIMARY KEY CLUSTERED (DXP_idDevolucion, DXP_idPasaje)

-- Create Table: DevXEnc
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.DevXEnc
(
	DXE_idDevolucion INT NOT NULL 
	,DXE_idEncomienda INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.DevXEnc ADD CONSTRAINT PK_DevXEnc PRIMARY KEY CLUSTERED (DXE_idDevolucion, DXE_idEncomienda)

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
	PTS_idCliente INT NOT NULL 
	,PTS_idVenta INT NOT NULL 
	,PTS_puntos INT NOT NULL 
	,PTS_idCanje INT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Puntos ADD CONSTRAINT PK_Puntos PRIMARY KEY CLUSTERED (PTS_idCliente, PTS_idVenta)

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
	,CNJ_idProducto INT NOT NULL 
	,CNJ_fecCanje DATETIME NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Canje ADD CONSTRAINT PK_Canje PRIMARY KEY (CNJ_idCanje)

-- Create Table: Recorrido
--------------------------------------------------------------------------------
CREATE TABLE NOT_NULL.Recorrido
(
	REC_idRecorrido INT NOT NULL IDENTITY(1, 1)
	,REC_idTipoServicio INT NOT NULL 
	,REC_idCiudadOrigen INT NOT NULL 
	,REC_idCiudadDestino INT NOT NULL 
	,REC_codRecorrido VARCHAR(10) NOT NULL 
	,REC_precioBase DECIMAL(10, 2) NOT NULL 
	,REC_precioKilo DECIMAL(10, 2) NOT NULL 
	,REC_habilitado BIT NOT NULL 
)
ON [PRIMARY]
ALTER TABLE NOT_NULL.Recorrido ADD CONSTRAINT PK_Recorrido PRIMARY KEY (REC_idRecorrido)

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



-- Create Foreign Key: Viaje.VIA_idRecorrido -> Recorrido.REC_idRecorrido
ALTER TABLE NOT_NULL.[Viaje] ADD CONSTRAINT
[FK_Viaje_VIA_idRecorrido_Recorrido_REC_idRecorrido]
FOREIGN KEY ([VIA_idRecorrido])
REFERENCES NOT_NULL.[Recorrido] ([REC_idRecorrido])
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
ALTER TABLE NOT_NULL.[Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_numButaca_Butaca_BUT_numeroAsiento]
FOREIGN KEY ([PAS_numButaca])
REFERENCES NOT_NULL.[Butaca] ([BUT_numeroAsiento])
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



-- Create Foreign Key: Puntos.PTS_idVenta -> Venta.VEN_idVenta
ALTER TABLE NOT_NULL.[Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([PTS_idVenta])
REFERENCES NOT_NULL.[Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Puntos.PTS_idCanje -> Canje.CNJ_idCanje
ALTER TABLE NOT_NULL.[Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idCanje_Canje_CNJ_idCanje]
FOREIGN KEY ([PTS_idCanje])
REFERENCES NOT_NULL.[Canje] ([CNJ_idCanje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Micro.MIC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE NOT_NULL.[Micro] ADD CONSTRAINT
[FK_Micro_MIC_idTipoServicio_TipoServicio_SRV_idTipoServicio]
FOREIGN KEY ([MIC_idTipoServicio])
REFERENCES NOT_NULL.[TipoServicio] ([SRV_idTipoServicio])
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
                (@idRol, 'admin', HASHBYTES('SHA1','w23e'), 'Administrador', 'General', 0),
			    (@idRol, 'mireya', HASHBYTES('SHA1','w23e'), 'Mireya', 'Mamani', 0),
			    (@idRol, 'jesús', HASHBYTES('SHA1','w23e'), 'Jesús', 'Herrera', 0),
                (@idRol, 'maxi', HASHBYTES('SHA1','w23e'), 'Maximiliano', 'Broinsky', 0);

	--INSERT INTO Funcionalidad(FUN_nombre, FUN_formAsociado)
        
	INSERT INTO FuncionalidadXRol (FXR_idRol, FXR_idFuncionalidad)
		SELECT @idRol, FNC_idFuncionalidad FROM Funcionalidad;
END
GO

CREATE PROCEDURE NOT_NULL.CargarMicros
AS
BEGIN
	INSERT INTO Micro (MIC_patente, MIC_idTipoServicio, MIC_kilosEncomiendas, MIC_habilitado 
			, MIC_idMarca, MIC_modelo, MIC_fechaAlta,MIC_fueraDeServicio)
		SELECT DISTINCT Micro_Patente, SRV_idTipoServicio, Micro_KG_Disponibles,
                       1, MAR_idMarca, Micro_modelo, CURRENT_TIMESTAMP, 0
		FROM gd_Esquema.Maestra, Marca, TipoServicio
		WHERE Tipo_Servicio = SRV_nombreServicio and Micro_Marca = MAR_nombreMarca;
END
GO

CREATE PROCEDURE NOT_NULL.CargarButacas 
AS 
BEGIN
    INSERT INTO Butaca (BUT_numeroAsiento, BUT_numMicro, BUT_tipo, BUT_piso)
		SELECT DISTINCT Butaca_Nro, MIC_numMicro, Butaca_Tipo, Butaca_Piso
		FROM gd_Esquema.Maestra, Micro
		WHERE Micro_Patente = Micro.MIC_patente;
END
GO

CREATE PROCEDURE NOT_NULL.CargarRecorridos 
AS 
BEGIN
    INSERT INTO Recorrido (REC_idTipoServicio, REC_idCiudadOrigen,
			REC_idCiudadDestino,REC_codRecorrido,REC_precioBase,REC_precioKilo
                        ,REC_habilitado)
		SELECT 	DISTINCT SRV_idTipoServicio, a.CIU_idCiudad, b.CIU_idCiudad, Recorrido_Codigo, 
			Recorrido_Precio_BasePasaje, Recorrido_Precio_BaseKG, 'T'
		FROM gd_Esquema.Maestra, Ciudad as a, Ciudad as b, TipoServicio
		WHERE Recorrido_Ciudad_Origen = a.CIU_nombre and
  		      Recorrido_Ciudad_Destino = b.CIU_nombre and
                      SRV_nombreServicio = Tipo_Servicio;
END
GO

CREATE PROCEDURE NOT_NULL.CargarViajes 
AS 
BEGIN
    INSERT INTO Viaje (	VIA_numMicro, VIA_idRecorrido, VIA_fecSalida, VIA_fecLlegada,VIA_fecLlegadaEstimada)
		SELECT DISTINCT	MIC_numMicro, REC_idRecorrido, FechaSalida, FechaLLegada, Fecha_LLegada_Estimada
		FROM gd_Esquema.Maestra, Micro, Recorrido
		WHERE Recorrido_Codigo = REC_codRecorrido and
  		      Micro_Patente = MIC_patente;
END
GO

--CREATE PROCEDURE CargarVentas 
--AS 
--BEGIN
--    INSERT INTO Ventas (PAS_idVenta, PAS_codigo, PAS_idViaje, PAS_idCliente, PAS_numButaca, PAS_precio)
--		SELECT 	Pasaje_Codigo, VIA_idViaje, CLI_idCliente, Butaca_Numero, Pasaje_Precio
--		FROM gd_Esquema.Maestra, Viaje, Cliente, Recorrido
--		WHERE FechaSalida = VIA_fecSalida and VIA_idRecorrido = REC_idRecorrido and 
--			Recorrido_Codigo = REC_codRecorrido and gd_Esquema.Maestra.Cli_Dni = Cliente.CLI_Dni;
--END
--GO

--CREATE PROCEDURE CargarPasajes 
--AS 
--BEGIN
--   INSERT INTO Pasaje (PAS_idVenta, PAS_codigo, PAS_idViaje, PAS_idCliente, PAS_numButaca, PAS_precio)
--		SELECT 	Pasaje_Codigo, VIA_idViaje, CLI_idCliente, Butaca_Numero, Pasaje_Precio
--		FROM gd_Esquema.Maestra, Viaje, Cliente, Recorrido
--		WHERE FechaSalida = VIA_fecSalida and VIA_idRecorrido = REC_idRecorrido and 
--			Recorrido_Codigo = REC_codRecorrido and gd_Esquema.Maestra.Cli_Dni = Cliente.CLI_Dni;
--END
--GO

--CREATE PROCEDURE CargarEncomiendas 
--AS 
--BEGIN
--    INSERT INTO Encomienda (ENC_idViaje, ENC_idCliente, ENC_kilos)
--		SELECT 	Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
--		FROM gd_Esquema.Maestra;
--END
--GO


--Acá se deberían correr los SP

EXECUTE NOT_NULL.CargarTablasSecundarias;
EXECUTE NOT_NULL.CargarMicros;
EXECUTE NOT_NULL.CargarButacas;
EXECUTE NOT_NULL.CargarRecorridos;
EXECUTE NOT_NULL.CargarViajes;

GO

--Acá se deberían borrar los SP

DROP PROCEDURE NOT_NULL.CargarTablasSecundarias;
DROP PROCEDURE NOT_NULL.CargarMicros;
DROP PROCEDURE NOT_NULL.CargarButacas;
DROP PROCEDURE NOT_NULL.CargarRecorridos;
DROP PROCEDURE NOT_NULL.CargarViajes;

GO
--FIN
COMMIT transaction

