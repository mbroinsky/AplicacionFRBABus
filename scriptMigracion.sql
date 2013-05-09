BEGIN

-- Create Table: Encomienda
--------------------------------------------------------------------------------
CREATE TABLE dbo.Encomienda
(
	ENC_numEnc INT NOT NULL IDENTITY(1, 1)
	,ENC_idViaje INT NOT NULL
	,ENC_idCliente INT NOT NULL 
	,ENC_kilos DECIMAL(10, 2) NOT NULL 
)
ON [PRIMARY]
ALTER TABLE dbo.Encomienda ADD CONSTRAINT
PK_Encomienda PRIMARY KEY CLUSTERED (ENC_numEnc)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Butaca
--------------------------------------------------------------------------------
CREATE TABLE dbo.Butaca
(
	BUT_numeroAsiento INT NOT NULL IDENTITY(1, 1)
	,BUT_numMicro INT NOT NULL
	,BUT_tipo VARCHAR(1) NOT NULL 
	,BUT_piso INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Butaca ADD CONSTRAINT
PK_Butaca PRIMARY KEY CLUSTERED (BUT_numeroAsiento)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Micro
--------------------------------------------------------------------------------
CREATE TABLE dbo.Micro
(
	MIC_numMicro INT NOT NULL IDENTITY(1, 1)
	,MIC_patente VARCHAR(6) NOT NULL 
	,MIC_idTipoServicio INT NOT NULL 
	,MIC_kilosEncomiendas DECIMAL(10, 2) NOT NULL 
	,MIC_habilitado BIT NOT NULL 
	,MIC_idEmpresa INT NOT NULL 
	,MIC_fechaAlta DATETIME NOT NULL 
	,MIC_fueraDeServicio BIT NOT NULL 
	,MIC_fecFueraServ DATETIME  NULL 
	,MIC_fecReinicioServ DATETIME  NULL 
	,MIC_fecBaja DATETIME  NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Micro ADD CONSTRAINT
PK_Micro PRIMARY KEY CLUSTERED (MIC_numMicro)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Ciudad
--------------------------------------------------------------------------------
CREATE TABLE dbo.Ciudad
(
	CIU_idCiudad INT NOT NULL IDENTITY(1, 1)
	,CIU_nombre VARCHAR(250) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Ciudad ADD CONSTRAINT
PK_Ciudad PRIMARY KEY CLUSTERED (CIU_idCiudad)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Viaje
--------------------------------------------------------------------------------
CREATE TABLE dbo.Viaje
(
	VIA_numViaje INT NOT NULL IDENTITY(1, 1)
	,VIA_numMicro INT NOT NULL
	,VIA_idRecorrido INT NOT NULL
	,VIA_fecSalida DATETIME NOT NULL 
	,VIA_fecLlegada DATETIME  NULL 
	,VIA_fecLlegadaEstimada DATETIME NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Viaje ADD CONSTRAINT
PK_Viaje PRIMARY KEY CLUSTERED (VIA_numViaje)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Usuario
--------------------------------------------------------------------------------
CREATE TABLE dbo.Usuario
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

ALTER TABLE dbo.Usuario ADD CONSTRAINT
PK_Usuario PRIMARY KEY CLUSTERED (USR_idUsuario)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: FuncionalidadXRol
--------------------------------------------------------------------------------
CREATE TABLE dbo.FuncionalidadXRol
(
	FXR_idRol INT NOT NULL 
	,FXR_idFuncionalidad INT NOT NULL
)
ON [PRIMARY]

ALTER TABLE dbo.FuncionalidadXRol ADD CONSTRAINT
PK_FuncionalidadXRol PRIMARY KEY CLUSTERED (FXR_idRol)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Funcionalidad
--------------------------------------------------------------------------------
CREATE TABLE dbo.Funcionalidad
(
	FNC_idFuncionalidad INT NOT NULL IDENTITY(1, 1)
	,FNC_nombre VARCHAR(50) NOT NULL 
	,FNC_formAsoc VARCHAR(50) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Funcionalidad ADD CONSTRAINT
PK_Funcionalidad PRIMARY KEY CLUSTERED (FNC_idFuncionalidad)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Pasaje
--------------------------------------------------------------------------------
CREATE TABLE dbo.Pasaje
(
	PAS_numPasaje INT NOT NULL IDENTITY(1, 1)
	,PAS_idViaje INT NOT NULL 
	,PAS_idCliente INT NOT NULL 
	,PAS_numButaca INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Pasaje ADD CONSTRAINT
PK_Pasaje PRIMARY KEY CLUSTERED (PAS_numPasaje)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Rol
--------------------------------------------------------------------------------
CREATE TABLE dbo.Rol
(
	ROL_idRol INT NOT NULL IDENTITY(1, 1)
	,ROL_nombre VARCHAR(250) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Rol ADD CONSTRAINT
PK_Rol PRIMARY KEY CLUSTERED (ROL_idRol)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Empresa
--------------------------------------------------------------------------------
CREATE TABLE dbo.Empresa
(
	EMP_idEmpresa INT NOT NULL IDENTITY(1, 1)
	,EMP_nombreEmpresa VARCHAR(50) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Empresa ADD CONSTRAINT
PK_Empresa PRIMARY KEY CLUSTERED (EMP_idEmpresa)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Cliente
--------------------------------------------------------------------------------
CREATE TABLE dbo.Cliente
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

ALTER TABLE dbo.Cliente ADD CONSTRAINT
PK_Cliente PRIMARY KEY CLUSTERED (CLI_idCliente)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: EncXVen
--------------------------------------------------------------------------------
CREATE TABLE dbo.EncXVen
(
	EXC_idVenta INT NOT NULL 
	,EXC_numEnc INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.EncXVen ADD CONSTRAINT
PK_EncXVen PRIMARY KEY CLUSTERED (EXC_idVenta)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Venta
--------------------------------------------------------------------------------
CREATE TABLE dbo.Venta
(
	VEN_idVenta INT NOT NULL IDENTITY(1, 1)
	,VEN_fecVenta DATETIME NOT NULL 
	,VEN_total DECIMAL(10, 2) NOT NULL 
	,VEN_idTarjeta INT  NULL 
	,VEN_discapacitado BIT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Venta ADD CONSTRAINT
PK_Venta PRIMARY KEY CLUSTERED (VEN_idVenta)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: PasXVen
--------------------------------------------------------------------------------
CREATE TABLE dbo.PasXVen
(
	PXV_idVenta INT NOT NULL 
	,PXV_idPasaje INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.PasXVen ADD CONSTRAINT
PK_PasXVen PRIMARY KEY CLUSTERED (PXV_idVenta)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: DevXPas
--------------------------------------------------------------------------------
CREATE TABLE dbo.DevXPas
(
	DXP_idDevolucion INT NOT NULL 
	,DXP_idPasaje INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.DevXPas ADD CONSTRAINT
PK_DevXPas PRIMARY KEY CLUSTERED (DXP_idDevolucion)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: DevXEnc
--------------------------------------------------------------------------------
CREATE TABLE dbo.DevXEnc
(
	DXE_idDevolucion INT NOT NULL 
	,DXE_idEncomienda INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.DevXEnc ADD CONSTRAINT
PK_DevXEnc PRIMARY KEY CLUSTERED (DXE_idDevolucion)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Tarjeta
--------------------------------------------------------------------------------
CREATE TABLE dbo.Tarjeta
(
	TAR_idTarjeta INT NOT NULL IDENTITY(1, 1)
	,TAR_nroTarjeta VARCHAR(20) NOT NULL 
	,TAR_fecVencimiento DATETIME NOT NULL 
	,TAR_tipo INT NOT NULL 
	,TAR_codSeg SMALLINT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Tarjeta ADD CONSTRAINT
PK_Tarjeta PRIMARY KEY CLUSTERED (TAR_idTarjeta)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: DevolucionVenta
--------------------------------------------------------------------------------
CREATE TABLE dbo.DevolucionVenta
(
	DEV_idDevolucion INT NOT NULL IDENTITY(1, 1)
	,DEV_idVenta INT NOT NULL 
	,DEV_fecha DATETIME NOT NULL 
	,DEV_motivo VARCHAR(250) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.DevolucionVenta ADD CONSTRAINT
PK_DevolucionVenta PRIMARY KEY CLUSTERED (DEV_idDevolucion)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Puntos
--------------------------------------------------------------------------------
CREATE TABLE dbo.Puntos
(
	PTS_idCliente INT NOT NULL 
	,PTS_idVenta INT NOT NULL 
	,PTS_puntos INT NOT NULL 
	,PTS_idCanje INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Puntos ADD CONSTRAINT
PK_Puntos PRIMARY KEY CLUSTERED (PTS_idCliente, PTS_idVenta)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Producto
--------------------------------------------------------------------------------
CREATE TABLE dbo.Producto
(
	PRO_idProd INT NOT NULL IDENTITY(1, 1)
	,PRO_descripcion VARCHAR(60) NOT NULL 
	,PRO_stock INT NOT NULL 
	,PRO_puntos INT NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Producto ADD CONSTRAINT
PK_Producto PRIMARY KEY CLUSTERED (PRO_idProd)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: TipoServicio
--------------------------------------------------------------------------------
CREATE TABLE dbo.TipoServicio
(
	SRV_idTipoServicio INT NOT NULL IDENTITY(1, 1) 
	,SRV_nombreServicio VARCHAR(50) NOT NULL 
	,SRV_porcentajeAdic DECIMAL(5, 2) NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.TipoServicio ADD CONSTRAINT
PK_Canje PRIMARY KEY CLUSTERED (SRV_idTipoServicio)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


-- Create Table: Canje
--------------------------------------------------------------------------------
CREATE TABLE dbo.Canje
(
	CNJ_idCanje INT NOT NULL IDENTITY(1, 1)
	,CNJ_idProducto INT NOT NULL 
	,CNJ_fecCanje DATETIME NOT NULL 
)
ON [PRIMARY]

ALTER TABLE dbo.Canje ADD CONSTRAINT
PK_Canje PRIMARY KEY CLUSTERED (CNJ_idCanje)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Table: Recorrido
--------------------------------------------------------------------------------
CREATE TABLE dbo.Recorrido
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

ALTER TABLE dbo.Recorrido ADD CONSTRAINT
PK_Recorrido PRIMARY KEY CLUSTERED (REC_idRecorrido)
WITH(STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]



-- Create Foreign Key: Recorrido.REC_idCiudadOrigen -> Ciudad.CIU_idCiudad
ALTER TABLE [Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idCiudadOrigen_Ciudad_CIU_idCiudad]
FOREIGN KEY ([REC_idCiudadOrigen])
REFERENCES [Ciudad] ([CIU_idCiudad])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Usuario.USR_idRol -> Rol.ROL_idRol
ALTER TABLE [Usuario] ADD CONSTRAINT
[FK_Usuario_USR_idRol_Rol_ROL_idRol]
FOREIGN KEY ([USR_idRol])
REFERENCES [Rol] ([ROL_idRol])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Micro.MIC_idEmpresa -> Empresa.EMP_idEmpresa
ALTER TABLE [Micro] ADD CONSTRAINT
[FK_Micro_MIC_idEmpresa_Empresa_EMP_idEmpresa]
FOREIGN KEY ([MIC_idEmpresa])
REFERENCES [Empresa] ([EMP_idEmpresa])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Viaje.VIA_numMicro -> Micro.MIC_numMicro
ALTER TABLE [Viaje] ADD CONSTRAINT
[FK_Viaje_VIA_numMicro_Micro_MIC_numMicro]
FOREIGN KEY ([VIA_numMicro])
REFERENCES [Micro] ([MIC_numMicro])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Viaje.VIA_idRecorrido -> Recorrido.REC_idRecorrido
ALTER TABLE [Viaje] ADD CONSTRAINT
[FK_Viaje_VIA_idRecorrido_Recorrido_REC_idRecorrido]
FOREIGN KEY ([VIA_idRecorrido])
REFERENCES [Recorrido] ([REC_idRecorrido])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Encomienda.ENC_idViaje -> Viaje.VIA_numViaje
ALTER TABLE [Encomienda] ADD CONSTRAINT
[FK_Encomienda_ENC_idViaje_Viaje_VIA_numViaje]
FOREIGN KEY ([ENC_idViaje])
REFERENCES [Viaje] ([VIA_numViaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Encomienda.ENC_idCliente -> Cliente.CLI_idCliente
ALTER TABLE [Encomienda] ADD CONSTRAINT
[FK_Encomienda_ENC_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([ENC_idCliente])
REFERENCES [Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Pasaje.PAS_idViaje -> Viaje.VIA_numViaje
ALTER TABLE [Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_idViaje_Viaje_VIA_numViaje]
FOREIGN KEY ([PAS_idViaje])
REFERENCES [Viaje] ([VIA_numViaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Pasaje.PAS_idCliente -> Cliente.CLI_idCliente
ALTER TABLE [Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([PAS_idCliente])
REFERENCES [Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Pasaje.PAS_numButaca -> Butaca.BUT_numeroAsiento
ALTER TABLE [Pasaje] ADD CONSTRAINT
[FK_Pasaje_PAS_numButaca_Butaca_BUT_numeroAsiento]
FOREIGN KEY ([PAS_numButaca])
REFERENCES [Butaca] ([BUT_numeroAsiento])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: PasXVen.PXV_idVenta -> Venta.VEN_idVenta
ALTER TABLE [PasXVen] ADD CONSTRAINT
[FK_PasXVen_PXV_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([PXV_idVenta])
REFERENCES [Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: PasXVen.PXV_idPasaje -> Pasaje.PAS_numPasaje
ALTER TABLE [PasXVen] ADD CONSTRAINT
[FK_PasXVen_PXV_idPasaje_Pasaje_PAS_numPasaje]
FOREIGN KEY ([PXV_idPasaje])
REFERENCES [Pasaje] ([PAS_numPasaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: EncXVen.EXC_idVenta -> Venta.VEN_idVenta
ALTER TABLE [EncXVen] ADD CONSTRAINT
[FK_EncXVen_EXC_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([EXC_idVenta])
REFERENCES [Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: EncXVen.EXC_numEnc -> Encomienda.ENC_numEnc
ALTER TABLE [EncXVen] ADD CONSTRAINT
[FK_EncXVen_EXC_numEnc_Encomienda_ENC_numEnc]
FOREIGN KEY ([EXC_numEnc])
REFERENCES [Encomienda] ([ENC_numEnc])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Venta.VEN_idTarjeta -> Tarjeta.TAR_idTarjeta
ALTER TABLE [Venta] ADD CONSTRAINT
[FK_Venta_VEN_idTarjeta_Tarjeta_TAR_idTarjeta]
FOREIGN KEY ([VEN_idTarjeta])
REFERENCES [Tarjeta] ([TAR_idTarjeta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXPas.DXP_idDevolucion -> DevolucionVenta.DEV_idDevolucion
ALTER TABLE [DevXPas] ADD CONSTRAINT
[FK_DevXPas_DXP_idDevolucion_DevolucionVenta_DEV_idDevolucion]
FOREIGN KEY ([DXP_idDevolucion])
REFERENCES [DevolucionVenta] ([DEV_idDevolucion])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevolucionVenta.DEV_idVenta -> Venta.VEN_idVenta
ALTER TABLE [DevolucionVenta] ADD CONSTRAINT
[FK_DevolucionVenta_DEV_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([DEV_idVenta])
REFERENCES [Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXPas.DXP_idPasaje -> Pasaje.PAS_numPasaje
ALTER TABLE [DevXPas] ADD CONSTRAINT
[FK_DevXPas_DXP_idPasaje_Pasaje_PAS_numPasaje]
FOREIGN KEY ([DXP_idPasaje])
REFERENCES [Pasaje] ([PAS_numPasaje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXEnc.DXE_idDevolucion -> DevolucionVenta.DEV_idDevolucion
ALTER TABLE [DevXEnc] ADD CONSTRAINT
[FK_DevXEnc_DXE_idDevolucion_DevolucionVenta_DEV_idDevolucion]
FOREIGN KEY ([DXE_idDevolucion])
REFERENCES [DevolucionVenta] ([DEV_idDevolucion])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: DevXEnc.DXE_idEncomienda -> Encomienda.ENC_numEnc
ALTER TABLE [DevXEnc] ADD CONSTRAINT
[FK_DevXEnc_DXE_idEncomienda_Encomienda_ENC_numEnc]
FOREIGN KEY ([DXE_idEncomienda])
REFERENCES [Encomienda] ([ENC_numEnc])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Puntos.PTS_idCliente -> Cliente.CLI_idCliente
ALTER TABLE [Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idCliente_Cliente_CLI_idCliente]
FOREIGN KEY ([PTS_idCliente])
REFERENCES [Cliente] ([CLI_idCliente])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Recorrido.REC_idCiudadDestino -> Ciudad.CIU_idCiudad
ALTER TABLE [Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idCiudadDestino_Ciudad_CIU_idCiudad]
FOREIGN KEY ([REC_idCiudadDestino])
REFERENCES [Ciudad] ([CIU_idCiudad])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Butaca.BUT_numMicro -> Micro.MIC_numMicro
ALTER TABLE [Butaca] ADD CONSTRAINT
[FK_Butaca_BUT_numMicro_Micro_MIC_numMicro]
FOREIGN KEY ([BUT_numMicro])
REFERENCES [Micro] ([MIC_numMicro])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Puntos.PTS_idVenta -> Venta.VEN_idVenta
ALTER TABLE [Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idVenta_Venta_VEN_idVenta]
FOREIGN KEY ([PTS_idVenta])
REFERENCES [Venta] ([VEN_idVenta])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Puntos.PTS_idCanje -> Canje.CNJ_idCanje
ALTER TABLE [Puntos] ADD CONSTRAINT
[FK_Puntos_PTS_idCanje_Canje_CNJ_idCanje]
FOREIGN KEY ([PTS_idCanje])
REFERENCES [Canje] ([CNJ_idCanje])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Micro.MIC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE [Micro] ADD CONSTRAINT
[FK_Micro_MIC_idTipoServicio_TipoServicio_SRV_idTipoServicio]
FOREIGN KEY ([MIC_idTipoServicio])
REFERENCES [TipoServicio] ([SRV_idTipoServicio])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: FuncionalidadXRol.FXR_idRol -> Rol.ROL_idRol
ALTER TABLE [FuncionalidadXRol] ADD CONSTRAINT
[FK_FuncionalidadXRol_FXR_idRol_Rol_ROL_idRol]
FOREIGN KEY ([FXR_idRol])
REFERENCES [Rol] ([ROL_idRol])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: FuncionalidadXRol.FXR_idFuncionalidad -> Funcionalidad.FNC_idFuncionalidad
ALTER TABLE [FuncionalidadXRol] ADD CONSTRAINT
[FK_FuncionalidadXRol_FXR_idFuncionalidad_Funcionalidad_FNC_idFuncionalidad]
FOREIGN KEY ([FXR_idFuncionalidad])
REFERENCES [Funcionalidad] ([FNC_idFuncionalidad])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Canje.CNJ_idProducto -> Producto.PRO_idProd
ALTER TABLE [Canje] ADD CONSTRAINT
[FK_Canje_CNJ_idProducto_Producto_PRO_idProd]
FOREIGN KEY ([CNJ_idProducto])
REFERENCES [Producto] ([PRO_idProd])
ON UPDATE NO ACTION
ON DELETE NO ACTION



-- Create Foreign Key: Recorrido.REC_idTipoServicio -> TipoServicio.SRV_idTipoServicio
ALTER TABLE [Recorrido] ADD CONSTRAINT
[FK_Recorrido_REC_idTipoServicio_TipoServicio_SRV_idTipoServicio]
FOREIGN KEY ([REC_idTipoServicio])
REFERENCES [TipoServicio] ([SRV_idTipoServicio])
ON UPDATE NO ACTION
ON DELETE NO ACTION


COMMIT


