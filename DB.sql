USE [master]
GO
/****** Object:  Database [FireSystemDB]    Script Date: 9/8/2018 9:47:16 PM ******/
CREATE DATABASE [FireSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FireSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FireSystemDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FireSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FireSystemDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FireSystemDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FireSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FireSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FireSystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FireSystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FireSystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FireSystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FireSystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FireSystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FireSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FireSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FireSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FireSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FireSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FireSystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FireSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FireSystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FireSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FireSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FireSystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FireSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FireSystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FireSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FireSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FireSystemDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FireSystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [FireSystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FireSystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FireSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FireSystemDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FireSystemDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FireSystemDB]
GO
/****** Object:  Table [dbo].[CONFIG_REMITENTE_EMAIL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONFIG_REMITENTE_EMAIL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PUERTO] [int] NULL,
	[HOST] [varchar](50) NULL,
	[EMAIL] [varchar](50) NULL,
	[PASSWORD] [varchar](50) NULL,
	[DAILY_EMAIL] [time](7) NULL,
	[LAST_DAILY_EMAIL] [date] NULL,
 CONSTRAINT [PK_CONFIG_REMITENTE_EMAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONFIGURACION_PUERTO_SERIAL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONFIGURACION_PUERTO_SERIAL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[COM] [varchar](50) NULL,
	[BAUDRATE] [int] NULL,
	[DATABITS] [varchar](50) NULL,
	[PARITY] [varchar](50) NULL,
	[STOPBIT] [varchar](50) NULL,
	[NEWLINE] [varchar](50) NULL,
	[ID_FACP] [int] NULL,
 CONSTRAINT [PK_CONFIGURACION_PUERTO_SERIAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETECTORES_POR_ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETECTORES_POR_ZONAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_ZONA] [int] NULL,
	[NOMBRE] [varchar](50) NULL,
	[TAMAÑO_PX] [int] NULL,
	[POSICION_X] [int] NULL,
	[POSICION_Y] [int] NULL,
	[IDENTIFICADOR] [varchar](50) NULL,
	[ESTADO] [varchar](50) NULL CONSTRAINT [DF_DETECTORES_POR_ZONAS_ESTADO]  DEFAULT ('OK'),
	[DESCRIPCION_ESTADO] [varchar](max) NULL,
	[Email] [bit] NULL CONSTRAINT [DF_DETECTORES_POR_ZONAS_Email]  DEFAULT ((0)),
	[DISPOSITIVO] [varchar](100) NULL,
	[TIPO_DISPOSITIVO] [varchar](100) NULL,
	[FIGURA] [varchar](50) NULL,
 CONSTRAINT [PK_DETECTORES_POR_ZONAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DISPOSITIVO]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DISPOSITIVO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DISPOSITIVO] [varchar](50) NULL,
 CONSTRAINT [PK_DISPOSITIVO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMAIL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMAIL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[EMAIL] [varchar](100) NULL,
	[CONEXION] [bit] NULL,
	[WARNING] [bit] NULL,
	[ALARMA] [bit] NULL,
 CONSTRAINT [PK_EMAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FACP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[ESTADO] [varchar](max) NULL CONSTRAINT [DF_FACP_ESTADO]  DEFAULT ('OK'),
	[FECHA_UPDATED] [datetime] NULL CONSTRAINT [DF_FACP_FECHA_UPDATED]  DEFAULT (getdate()),
	[EVACUACION] [bit] NULL CONSTRAINT [DF_FACP_EVACUACION]  DEFAULT ((0)),
 CONSTRAINT [PK_FACP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOG_ESTADOS_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOG_ESTADOS_FACP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_FACP] [int] NULL,
	[MENSAJE] [varchar](max) NULL,
	[FECHA] [datetime] NOT NULL CONSTRAINT [DF_LOG_ESTADOS_FACP_FECHA]  DEFAULT (getdate()),
 CONSTRAINT [PK_LOG_ESTADOS_FACP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOFTWARE_ACTIVATION]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOFTWARE_ACTIVATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ACTIVATED] [bit] NULL CONSTRAINT [DF_SOFTWARE_ACTIVATION_ACTIVATED]  DEFAULT ((0)),
	[TIPO] [varchar](50) NULL,
	[FECHA_ACTIVADO] [date] NULL,
	[FECHA_VENCIMIENTO] [date] NULL,
	[HDD_SERIAL] [varchar](max) NULL,
	[SOFTWARE] [varchar](50) NULL,
	[TRIAL_PERIOD_END] [bit] NULL CONSTRAINT [DF_SOFTWARE_ACTIVATION_TRIAL_PERIOD_END]  DEFAULT ((0)),
	[LAST_USED_DATE] [date] NULL,
	[PUERTOS_TOTALES] [int] NULL CONSTRAINT [DF_SOFTWARE_ACTIVATION_PUERTOS_TOTALES]  DEFAULT ((0)),
 CONSTRAINT [PK_SOFTWARE_ACTIVATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOS_DISPOSITIVOS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOS_DISPOSITIVOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_DISPOSITIVO] [int] NULL,
	[TIPO_DISPOSITIVO] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOS_DISPOSITIVOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZONAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_FACP] [int] NULL,
	[NOMBRE] [varchar](50) NULL,
	[DESCRIPCION] [varchar](100) NULL,
	[IMAGE] [varbinary](max) NULL,
	[ESTADO] [bit] NOT NULL CONSTRAINT [DF_ZONAS_estado]  DEFAULT ((1)),
 CONSTRAINT [PK_ZONAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ACTIVAR_SOFTWARE]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[ACTIVAR_SOFTWARE]
@mensaje bit output, @tipo varchar(50), @hdd_serial varchar(max), @software varchar(100), @totalPuertos int
as
declare @fechaActivacion date = (select getdate())
declare @fechaVencimiento date = (select DATEADD(DAY, 25, getdate()))
set @mensaje = 0
begin
	

	if exists(select * from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
		begin
			update SOFTWARE_ACTIVATION set ACTIVATED= 1, tipo = @tipo, FECHA_ACTIVADO = @fechaActivacion, FECHA_VENCIMIENTO = @fechaVencimiento,
			SOFTWARE = @software, PUERTOS_TOTALES = @totalPuertos, LAST_USED_DATE = @fechaActivacion, TRIAL_PERIOD_END = 0 where HDD_SERIAL = @hdd_serial and SOFTWARE = @software

						
			set @mensaje = 1
		end
	else 
		begin
			Insert into SOFTWARE_ACTIVATION (ACTIVATED, FECHA_ACTIVADO, FECHA_VENCIMIENTO, HDD_SERIAL, SOFTWARE, TIPO, PUERTOS_TOTALES, LAST_USED_DATE,TRIAL_PERIOD_END)
			VALUES(1, @fechaActivacion,@fechaVencimiento, @hdd_serial, @software, @tipo, @totalPuertos, @fechaActivacion, 0)
			set @mensaje = 1
		end
			

	
	
end



GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_CONFIGURACION_PUERTO_SERIAL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ACTUALIZAR_CONFIGURACION_PUERTO_SERIAL]
@identificador varchar(50), @com varchar(50), @baudrate int, @databits varchar(50), @parity varchar(50), @stopbit varchar(50),
@newline varchar(50), @mensaje int output, @id int

as
	set @mensaje = 0
begin
	update CONFIGURACION_PUERTO_SERIAL set  NOMBRE = @identificador, COM = @com, BAUDRATE= @baudrate,
	 DATABITS= @databits, PARITY= @parity, STOPBIT= @stopbit, NEWLINE= @newline
	where ID = @id

	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_DETECTORES_ZONA]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ACTUALIZAR_DETECTORES_ZONA]
@idDetector int ,@idZona int, @nombre varchar(50),@tamaño int, @pos_x int, @pos_y int, @mensaje int output,
@identificador varchar(50), @dispositivo varchar (100), @tipoDispositivo varchar(100), @figura varchar(100)
as
set @mensaje = 0
begin
	update DETECTORES_POR_ZONAS set NOMBRE = @nombre, TAMAÑO_PX = @tamaño, POSICION_X = @pos_x, IDENTIFICADOR = @identificador,
	POSICION_Y = @pos_y , DISPOSITIVO = @dispositivo, TIPO_DISPOSITIVO = @tipoDispositivo, FIGURA = @figura
	where ID = @idDetector and ID_ZONA = @idZona
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ESTADO_DETECTOR]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ACTUALIZAR_ESTADO_DETECTOR]
@idFacp int, @mensaje int output, @estado varchar(50), @identificador varchar(50), @descripcion varchar (max)
as
set @mensaje = 0
begin
	
	update U 
	set U.ESTADO = @estado, U.DESCRIPCION_ESTADO = @descripcion
	from DETECTORES_POR_ZONAS U 
	join ZONAS Z on Z.ID = U.ID_ZONA 
	join FACP F on F.ID = Z.ID_FACP
	where F.ID = @idFacp and U.IDENTIFICADOR = @identificador

	set @mensaje = 1
end


GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ESTADO_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ACTUALIZAR_ESTADO_FACP]
@idFacp int, @mensaje int output, @estado varchar(max)
as
set @mensaje = 0
begin
	declare @facpEstado varchar(max)
	set @facpEstado = (select ESTADO from FACP where ID = @idFacp)
	if @facpEstado = 'OK' or @facpEstado = ''
		begin
			update FACP set ESTADO = @estado where ID = @idFacp
		end
	else
		begin
			update FACP set ESTADO = ESTADO + char(13)+ @estado where ID = @idFacp
		end
	

	set @mensaje = 1
end


GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ACTUALIZAR_FACP]	
@nombre varchar(50), @mensaje int output, @idFacp int

as

set @mensaje = 0
begin
	update FACP set NOMBRE = @nombre
	where ID = @idFacp
	 
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_FECHA_CORREO_DIARIO]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTUALIZAR_FECHA_CORREO_DIARIO]
@mensaje int output
as
set @mensaje = 0
begin
	update CONFIG_REMITENTE_EMAIL set LAST_DAILY_EMAIL = GETDATE() where ID = 1
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ONLINE_ESTATUS_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ACTUALIZAR_ONLINE_ESTATUS_FACP]	
@idFacp int, @mensaje int output
as
set @mensaje = 0

begin
	update FACP set FECHA_UPDATED = GETDATE() where ID = @idFacp
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ZONA]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ACTUALIZAR_ZONA]
@idZona int, @nombre varchar(50), @descripcion varchar(100), @estado bit, @mensaje int output, @img varbinary(max),
@idFacp int

as
set @mensaje = 0
begin
	update ZONAS set NOMBRE = @nombre, DESCRIPCION = @descripcion, ESTADO = @estado, IMAGE = @img,
	ID_FACP = @idFacp
	where ID = @idZona
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[BORRAR_DETECTOR]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BORRAR_DETECTOR]
@idZona int, @idDetector int, @mensaje int output

as

set @mensaje = 0

begin

	Delete From DETECTORES_POR_ZONAS where ID = @idDetector and ID_ZONA = @idZona
	set @mensaje = 1;

end

GO
/****** Object:  StoredProcedure [dbo].[BORRAR_EMAIL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BORRAR_EMAIL]
@id int, @mensaje int output
as
set @mensaje = 0
begin
	delete From EMAIL Where ID = @id
	set @mensaje = 1

end


GO
/****** Object:  StoredProcedure [dbo].[CHECK_SOFTWARE_ACTIVATION]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHECK_SOFTWARE_ACTIVATION]
@hdd_serial varchar(max), @mensaje varchar(200) output, @software varchar(100)

as

set @mensaje = 'NONE'


begin
	if exists(select TIPO from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
		begin
			declare @ultimoUso date ;
			set @ultimoUso = (SELECT LAST_USED_DATE FROM SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
			declare @activado bit;
			set @activado = (select ACTIVATED from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
			if @activado = 1
				begin
					if @ultimoUso >  GETDATE()
						begin
							update SOFTWARE_ACTIVATION set TRIAL_PERIOD_END = 1 where HDD_SERIAL = @hdd_serial and SOFTWARE = @software
						end
					else
						begin
							update SOFTWARE_ACTIVATION set LAST_USED_DATE = GETDATE() where HDD_SERIAL = @hdd_serial and SOFTWARE = @software
						end
					
					set @mensaje = (select TIPO from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
				end
			
		end
	


end



GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ELIMINAR_FACP]
@idFacp int, @mensaje int output
as

set @mensaje = 0

begin
	delete from FACP where ID = @idFacp
	delete from ZONAS where ID_FACP = @idFacp
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_DISPOSITIVOS_Y_TIPOS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_DISPOSITIVOS_Y_TIPOS]
AS

BEGIN
	IF NOT EXISTS(SELECT ID FROM DISPOSITIVO WHERE ID = 1)
		BEGIN 
			INSERT INTO DISPOSITIVO (DISPOSITIVO)
			VALUES('DETECTOR'),
			('MODULE')	

		END
	IF NOT EXISTS(SELECT ID FROM TIPOS_DISPOSITIVOS WHERE ID = 1)
		BEGIN 
			INSERT INTO TIPOS_DISPOSITIVOS(ID_DISPOSITIVO, TIPO_DISPOSITIVO)
			VALUES(1,'SMOKE PHOTO'),
			(1,'SMOKE ION'),
			(1, 'HEAD DETECT'),
			(1, 'SMOKE DUCT P'),	
			(1, 'PHOTO W/ HEAT'),
			(1, 'DUCT-SUPERV'),
			(1, 'PHOTO SUPERV AV'),
			(1, 'ADAPT'),
			(1, 'BEAM'),
			(2, 'PULL STATION'),
			(2, 'WATERFLOW'),
			(2, 'MONITOR'),
			(2, 'SMOKE CONVENTIONAL'),
			(2, 'HEAT-CONVENTIONAL'),
			(2, 'BELL CIRCUIT'),
			(2, 'HORN CIRCUIT'),
			(2, 'RELAY'),
			(2, 'STROBE CIRCUIT'),
			(2, 'CONTROL'),
			(2, 'RESETTEABLE POWER'),
			(2, 'HVAC SHUTDN')

		END

END

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_LOG_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[INSERTAR_LOG_FACP] 
@idFacp int, @estadoFacp varchar(max), @mensaje int output
as
set @mensaje = 0

begin 

	insert LOG_ESTADOS_FACP(ID_FACP, MENSAJE)
	VALUES (@idFacp, @estadoFacp)
	set @mensaje = 1

end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_CONFIG_REMITENTE]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[OBTENER_CONFIG_REMITENTE]

as

begin
	
	select * FROM CONFIG_REMITENTE_EMAIL
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_CONFIGURACION_ESPECIFICA]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[OBTENER_CONFIGURACION_ESPECIFICA]
@nombre varchar(50)

as


begin
	if not exists(select ID from CONFIGURACION_PUERTO_SERIAL where id = 1)
		begin
				insert into CONFIGURACION_PUERTO_SERIAL(NOMBRE,COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE)
				Values('Default', 'COM1', 9600, '8', 'None', '1', '\n\r')
			
				--select * from CONFIGURACION_PUERTO_SERIAL
		end
	
	if @nombre != '' and exists(Select ID from CONFIGURACION_PUERTO_SERIAL where NOMBRE = @nombre)
		begin
			 select Top  1 C.NOMBRE, COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE as FACP from CONFIGURACION_PUERTO_SERIAL C
			
			 where C.NOMBRE = @nombre
		end
	else
		begin
			select Top  1 C.NOMBRE, COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE from CONFIGURACION_PUERTO_SERIAL C
			  where C.ID = 1 
		end
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_CONFIGURACIONES_PUERTO_SERIAL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_CONFIGURACIONES_PUERTO_SERIAL]
--@identificador int, @com varchar(50), @baudrate int, @databits varchar(50), @parity varchar(50), @stopbit varchar(50),
--@newline varchar(50), @mensaje int output

as

begin
	if not exists(select ID from CONFIGURACION_PUERTO_SERIAL where id = 1)
		begin
			insert into CONFIGURACION_PUERTO_SERIAL(NOMBRE,COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE)
			Values('Default', 'COM1', 9600, '8', 'None', '1', '\n\r')
			
			select C.ID , C.NOMBRE, COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE from CONFIGURACION_PUERTO_SERIAL C
			
		end
	else
		begin
			
			select C.ID , C.NOMBRE, COM, BAUDRATE, DATABITS, PARITY, STOPBIT, NEWLINE from CONFIGURACION_PUERTO_SERIAL C

		end
end 

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_DATA_ENVIAR_EMAIL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_DATA_ENVIAR_EMAIL]
@idFacp int

as

begin

	select D.ID as IDDETECTOR, Z.NOMBRE  as ZONA, D.NOMBRE as DETECTOR, D.IDENTIFICADOR, D.ESTADO, D.DISPOSITIVO, D.TIPO_DISPOSITIVO from DETECTORES_POR_ZONAS D 
	join ZONAS Z on Z.ID = D.ID_ZONA
	join FACP F on F.ID = Z.ID_FACP
	where F.ID = @idFacp and D.ESTADO != 'OK'
	
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_DETECTORES_POR_ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_DETECTORES_POR_ZONAS]
@idZona int

as
begin
	select ID , NOMBRE, TAMAÑO_PX, POSICION_X, POSICION_Y, IDENTIFICADOR, ESTADO, DESCRIPCION_ESTADO, DISPOSITIVO, TIPO_DISPOSITIVO, FIGURA
	from DETECTORES_POR_ZONAS 
	where ID_ZONA = @idZona
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_DIAS_ACTIVO]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[OBTENER_DIAS_ACTIVO]
@hdd_serial varchar(max), @software varchar(100)
as

declare @fechaActivacion date = (select FECHA_ACTIVADO from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software) 
declare @fechaVencimiento date = (select FECHA_VENCIMIENTO from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
declare @lastUsed date = (select LAST_USED_DATE from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
begin
	declare @dias int = ISNULL(DATEDIFF(DAY,format (GETDATE(), 'yyyy-MM-dd'),  format (@fechaVencimiento, 'yyyy-MM-dd')), 0)
	if @lastUsed > GETDATE()
		begin
			SET @dias = 0
		end
	IF @dias  <= 0 
		begin
			update SOFTWARE_ACTIVATION set TRIAL_PERIOD_END = 1 where HDD_SERIAL = @hdd_serial and SOFTWARE = @software
		end
	declare @trial_ended bit;
	set @trial_ended = (select TRIAL_PERIOD_END from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software)
	if @trial_ended = 1
		begin
			set @dias = 0
		end
	select @dias as DIAS
end



GO
/****** Object:  StoredProcedure [dbo].[OBTENER_DISPOSITIVOS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_DISPOSITIVOS]

AS

BEGIN

	SELECT ID, DISPOSITIVO FROM DISPOSITIVO

END

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_EMAILS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[OBTENER_EMAILS]
as

begin
	select ID, NOMBRE, EMAIL, CONEXION, WARNING, ALARMA from EMAIL
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ESTADO_DETECTOR_INDIVIDUAL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_ESTADO_DETECTOR_INDIVIDUAL]
@idZona int, @idDetector int, @identificador varchar(50), @nombre varchar(50)

as
begin

select ESTADO, DESCRIPCION_ESTADO 
from DETECTORES_POR_ZONAS 
where ID_ZONA = @idZona and ID = @idDetector and 
(IDENTIFICADOR = @identificador or NOMBRE = @nombre)
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ESTADO_EMAIL_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_ESTADO_EMAIL_FACP]
@idFacp int

as
begin
	select ESTADO from FACP where ID = @idFacp 
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ESTADO_EVACUACION_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_ESTADO_EVACUACION_FACP]
@idFacp int
as
begin
	select EVACUACION from FACP where ID = @idFacp
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ESTADO_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_ESTADO_FACP]
@idFacp int

as
begin
	select top 50 MENSAJE, FECHA from LOG_ESTADOS_FACP where ID_FACP = @idFacp order by FECHA DESC
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ESTADO_ZONA]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_ESTADO_ZONA]
@idZona int
as

begin
	if exists(select Z.ID from ZONAS Z join DETECTORES_POR_ZONAS D on D.ID_ZONA = Z.ID where D.ESTADO != 'OK' and Z.ID = @idZona)
		begin
			if exists(select Z.ID from ZONAS Z join DETECTORES_POR_ZONAS D on D.ID_ZONA = Z.ID where (D.ESTADO = 'HEAT' or  D.ESTADO = 'SMOKE' or  D.ESTADO = 'PULL STATION' or D.ESTADO = 'MONITOR') and Z.ID = @idZona)
				begin
					select 'ALARMA'
				end
			else 
				begin
					select 'ADVERTENCIA'
				end
		end
	else
		begin
			select 'OK'
		end
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[OBTENER_FACP]
AS

BEGIN
	SELECT ID, NOMBRE FROM FACP
END

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_IMAGENES_ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_IMAGENES_ZONAS]	
@idZona int
as

Begin
	select ID, IMAGE from ZONAS where ID = @idZona
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_INFO_SOFTWARE]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[OBTENER_INFO_SOFTWARE]
@hdd_serial varchar(max), @software varchar(100)
as

begin

	select TIPO, FECHA_ACTIVADO, FECHA_VENCIMIENTO, PUERTOS_TOTALES 
	from SOFTWARE_ACTIVATION 
	where HDD_SERIAL = @hdd_serial and SOFTWARE = @software

end


GO
/****** Object:  StoredProcedure [dbo].[OBTENER_LOG_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_LOG_FACP]
@idFacp int, @hasta datetime, @desde datetime
as
begin
	Select F.NOMBRE, LEF.MENSAJE as ESTADO, format (LEF.FECHA, 'dd-MM-yy hh:mm:ss tt') as FECHA 
	from LOG_ESTADOS_FACP LEF
	join FACP F on F.ID = LEF.ID_FACP
	where LEF.ID_FACP = @idFacp 
	and format(LEF.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_NOMBRE_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[OBTENER_NOMBRE_FACP]
@idFacp int
as

begin
	select NOMBRE from FACP where id = @idFacp
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ONLINE_ESTATUS_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[OBTENER_ONLINE_ESTATUS_FACP]	
@idFacp int, @mensaje int output
as
set @mensaje = 0
declare @fechaActual datetime = (select GETDATE()) 
declare @fechaActualizado datetime = (SELECT FECHA_UPDATED FROM  FACP where ID = @idFacp)
begin
	
	if (DATEDIFF(SECOND, @fechaActualizado, @fechaActual)) < 5
		begin
			set @mensaje = 1
		end
	
	
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_TIPOS_DISPOSITIVOS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_TIPOS_DISPOSITIVOS]
@id int
AS

BEGIN

	SELECT ID, TIPO_DISPOSITIVO FROM TIPOS_DISPOSITIVOS where ID_DISPOSITIVO = @id

END

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_TOTAL_PUERTOS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_TOTAL_PUERTOS]

@hdd_serial varchar(max), @mensaje INT output, @software varchar(100)
AS

SET @mensaje = 1

begin
	set @mensaje = isNull((select PUERTOS_TOTALES from SOFTWARE_ACTIVATION where HDD_SERIAL = @hdd_serial and SOFTWARE = @software),0)
end


GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ULTIMO_ESTADO_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OBTENER_ULTIMO_ESTADO_FACP]	
@idFacp int
as

begin

	SELECT TOP 1 MENSAJE FROM LOG_ESTADOS_FACP WHERE ID_FACP = @idFacp
	ORDER BY ID DESC 
end

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_ZONAS]
@idFacp int
AS

BEGIN

	SELECT Z.ID, Z.NOMBRE as 'NOMBRE ZONA', Z.DESCRIPCION, Z.ESTADO, F.NOMBRE as FACP FROM ZONAS Z
	join FACP F on F.ID = Z.ID_FACP
	where ID_FACP = @idFacp
END

GO
/****** Object:  StoredProcedure [dbo].[OBTENER_ZONAS_HABILITADAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OBTENER_ZONAS_HABILITADAS]
@idFacp int
AS

BEGIN

	SELECT Z.ID, Z.NOMBRE, Z.DESCRIPCION, Z.IMAGE, F.NOMBRE as FACP FROM ZONAS Z 
	join FACP F on F.ID = Z.ID_FACP 
	
	where Z.ESTADO = 1 and ID_FACP = @idFacp
END

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_CONFIG_REMITENTE]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REGISTRAR_CONFIG_REMITENTE]
@puerto int, @host varchar(50), @email varchar(50), @password varchar(50), @mensaje int output, @desde datetime
as
set @mensaje = 0

begin
	if(not exists(select ID FROM CONFIG_REMITENTE_EMAIL))
		begin
			insert into CONFIG_REMITENTE_EMAIL (PUERTO, HOST, EMAIL, PASSWORD, DAILY_EMAIL)
			VALUES (@puerto, @host, @email, @password, @desde)
			set @mensaje = 1
		end
	else
		begin
			
			update CONFIG_REMITENTE_EMAIL set EMAIL = @email, PUERTO = @puerto, PASSWORD = @password, HOST = @host, DAILY_EMAIL = @desde
			--LAST_DAILY_EMAIL = DATEADD(DAY, -1, getdate())
			where ID = 1
			set @mensaje = 1
		end
	
end

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_CONFIGURACION_PUERTO_SERIAL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REGISTRAR_CONFIGURACION_PUERTO_SERIAL]
@identificador varchar(50), @com varchar(50), @baudrate int, @databits varchar(50), @parity varchar(50), @stopbit varchar(50),
@newline varchar(50), @mensaje int output

as
	set @mensaje = 0
begin
	insert into CONFIGURACION_PUERTO_SERIAL (NOMBRE, COM, BAUDRATE, DATABITS, PARITY, STOPBIT,NEWLINE)
	Values(@identificador, @com, @baudrate, @databits, @parity, @stopbit, @newline)

	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_DETECTORES]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REGISTRAR_DETECTORES]
@idZona int, @nombre varchar(50), @tamaño int, @pos_x int, @pos_y int, @mensaje int output,
@identificador varchar(50), @dispositivo varchar (100), @tipoDispositivo varchar(100), @figura varchar(100)
as
set @mensaje = 0
begin

	Insert into DETECTORES_POR_ZONAS (ID_ZONA, NOMBRE, TAMAÑO_PX, POSICION_X, POSICION_Y, IDENTIFICADOR, DISPOSITIVO, TIPO_DISPOSITIVO, FIGURA)
	VALUES (@idZona, @nombre, @tamaño, @pos_x, @pos_y, @identificador, @dispositivo, @tipoDispositivo, @figura)
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_EMAIL]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REGISTRAR_EMAIL]
@nombre varchar(50), @email varchar(50), @conexion bit, @warning bit, @alarma bit, @mensaje int output
as
set @mensaje = 0
begin
	insert into EMAIL(NOMBRE, EMAIL, CONEXION, WARNING, ALARMA)
	VALUES (@nombre, @email, @conexion, @warning, @alarma)

	set @mensaje = 1

end


GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REGISTRAR_FACP]	
@nombre varchar(50), @mensaje int output

as

set @mensaje = 0
begin
	insert into FACP (NOMBRE)
	values (@nombre)
	set @mensaje = 1
end

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_ZONAS]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REGISTRAR_ZONAS]
@nombre varchar(50), @descripcion varchar(100), @mensaje int output, @img varbinary(max),
@idFacp int

as

set @mensaje = 0

begin
	insert into ZONAS(NOMBRE, DESCRIPCION, IMAGE, ID_FACP)
	VALUES (@nombre, @descripcion, @img, @idFacp)

	set @mensaje = (select MAX(ID) from ZONAS)

end


GO
/****** Object:  StoredProcedure [dbo].[RESET_ESTADOS_DETECTORES_FACP_ESPECIFICO]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[RESET_ESTADOS_DETECTORES_FACP_ESPECIFICO]
@idFacp int, @mensaje int output

as
set @mensaje = 0
begin
	
	update FACP set ESTADO = 'OK', EVACUACION = 0 where ID = @idFacp
	
	update U 
	set U.ESTADO = 'OK', DESCRIPCION_ESTADO = 'SISTEMA OK'
	from DETECTORES_POR_ZONAS U 
	join ZONAS Z on Z.ID = U.ID_ZONA 
	join FACP F on F.ID = Z.ID_FACP
	where F.ID = @idFacp

	

	set @mensaje =1
end

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_EVACUACION_FIELD_FACP]    Script Date: 9/8/2018 9:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_EVACUACION_FIELD_FACP]
@idFacp int, @mensaje int output
as
set @mensaje = 0
begin

	update FACP set EVACUACION = 1 where ID = @idFacp
	set @mensaje = 1
end

GO
USE [master]
GO
ALTER DATABASE [FireSystemDB] SET  READ_WRITE 
GO
