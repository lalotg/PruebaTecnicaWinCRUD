USE [master]
GO
/****** Object:  Database [Data]    Script Date: 20/02/2020 04:24:19 p. m. ******/
CREATE DATABASE [Data]

/****** Object:  Table [dbo].[CPMX_Asentamientos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPMX_Asentamientos](
	[IdAsentamiento] [int] NOT NULL,
	[Asentamiento] [varchar](270) NULL,
	[IdMunicipio] [int] NOT NULL,
	[IdEstado] [int] NULL,
	[IdTipo] [int] NULL,
	[CP] [varchar](5) NOT NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAsentamiento] ASC,
	[IdMunicipio] ASC,
	[CP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPMX_Estados]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPMX_Estados](
	[IdEstado] [int] NOT NULL,
	[Estado] [varchar](250) NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPMX_Municipios]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPMX_Municipios](
	[IdMunicipio] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[Municipio] [varchar](270) NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMunicipio] ASC,
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPMX_TiposAsentamiento]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPMX_TiposAsentamiento](
	[IdTipo] [int] NOT NULL,
	[TipoAsentamiento] [varchar](170) NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXA_Datos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXA_Datos](
	[IdDato] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[PrimerApellido] [varchar](150) NULL,
	[SegundoApellido] [varchar](150) NULL,
	[FechaNacimiento] [date] NULL,
	[IdSexo] [int] NULL,
	[EstadoNacimiento] [varchar](150) NULL,
	[CURP] [varchar](30) NULL,
	[Telefono] [varchar](25) NULL,
	[DireccionActual] [varchar](250) NULL,
	[CP] [varchar](5) NULL,
	[Municipio] [varchar](170) NULL,
	[Asentamiento] [varchar](170) NULL,
	[Calle] [varchar](150) NULL,
	[Numero] [varchar](150) NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
	[Estado] [varchar](170) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PER_Sexos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PER_Sexos](
	[IdSexo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](120) NULL,
	[Creacion] [datetime] NULL,
	[Modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CPMX_Asentamientos] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[CPMX_Asentamientos] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[CPMX_Estados] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[CPMX_Estados] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[CPMX_Municipios] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[CPMX_Municipios] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[CPMX_TiposAsentamiento] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[CPMX_TiposAsentamiento] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[EXA_Datos] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[EXA_Datos] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[PER_Sexos] ADD  DEFAULT (getdate()) FOR [Creacion]
GO
ALTER TABLE [dbo].[PER_Sexos] ADD  DEFAULT (getdate()) FOR [Modificacion]
GO
ALTER TABLE [dbo].[CPMX_Asentamientos]  WITH CHECK ADD FOREIGN KEY([IdMunicipio], [IdEstado])
REFERENCES [dbo].[CPMX_Municipios] ([IdMunicipio], [IdEstado])
GO
ALTER TABLE [dbo].[CPMX_Municipios]  WITH CHECK ADD FOREIGN KEY([IdEstado])
REFERENCES [dbo].[CPMX_Estados] ([IdEstado])
GO
ALTER TABLE [dbo].[EXA_Datos]  WITH CHECK ADD FOREIGN KEY([IdSexo])
REFERENCES [dbo].[PER_Sexos] ([IdSexo])
GO
/****** Object:  StoredProcedure [dbo].[SPD_EXA_Dato]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPD_EXA_Dato]
@Id int
As
Begin
 Delete From 
	EXA_Datos
 Where
	IdDato = @Id
End
GO
/****** Object:  StoredProcedure [dbo].[SPI_CPMX_Asentamiento]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPI_CPMX_Asentamiento]
@IdAsentamiento int,
@Asentamiento varchar(270),
@IdMunicipio int,
@IdEstado int,
@IdTipo int,
@CP varchar(5)
As
Begin
 Insert Into CPMX_Asentamientos(
	IdAsentamiento,
	Asentamiento,
	IdMunicipio,
	IdEstado,
	IdTipo,
	CP
 )
 Values(
	@IdAsentamiento,
	@Asentamiento,
	@IdMunicipio,
	@IdEstado,
	@IdTipo,
	@CP
 )
End
GO
/****** Object:  StoredProcedure [dbo].[SPI_CPMX_Estado]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPI_CPMX_Estado]
@Estado varchar(250),
@Id int
As
Begin
 Insert Into CPMX_Estados(
	IdEstado,
	Estado
 )
 Values(
	@Id,
	@Estado
 )
End
GO
/****** Object:  StoredProcedure [dbo].[SPI_CPMX_Municipio]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPI_CPMX_Municipio]
@IdMunicipio int,
@IdEstado int,
@Municipio varchar(270)
As
Begin
 Insert Into CPMX_Municipios(
	IdMunicipio,
	IdEstado,
	Municipio
 )
 Values(
	@IdMunicipio,
	@IdEstado,
	@Municipio
 )
End
GO
/****** Object:  StoredProcedure [dbo].[SPI_CPMX_TipoAsentamiento]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPI_CPMX_TipoAsentamiento]
@IdTipo int,
@TipoAsentamiento varchar(170)
As
Begin
 Insert Into CPMX_TiposAsentamiento(
	IdTipo,
	TipoAsentamiento
 )
 Values(
	@IdTipo,
	@TipoAsentamiento
 )
End
GO
/****** Object:  StoredProcedure [dbo].[SPI_EXA_Datos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPI_EXA_Datos]  
@Nombre varchar(150),  
@PrimerApellido varchar(150),  
@SegundoApellido varchar(150),  
@FechaNacimiento Date,  
@IdSexo int,  
@EstadoNacimiento varchar(150),  
@CURP varchar(30),  
@Telefono varchar(25),  
@DireccionActual varchar(250),  
@CP varchar(5),  
@Estado varchar(170),
@Municipio varchar(170),  
@Asentamiento varchar(170),  
@Calle varchar(150),  
@Numero varchar(150),  
@Id int out  
As  
Begin  
 Insert Into EXA_Datos(  
 Nombre  
 ,PrimerApellido  
 ,SegundoApellido  
 ,FechaNacimiento  
 ,IdSexo  
 ,EstadoNacimiento  
 ,CURP  
 ,Telefono  
 ,DireccionActual  
 ,CP  
 ,Estado
 ,Municipio  
 ,Asentamiento  
 ,Calle  
 ,Numero  
 )Values(  
 @Nombre  
 ,@PrimerApellido  
 ,@SegundoApellido  
 ,@FechaNacimiento  
 ,@IdSexo  
 ,@EstadoNacimiento  
 ,@CURP  
 ,@Telefono  
 ,@DireccionActual  
 ,@CP  
 ,@Estado
 ,@Municipio  
 ,@Asentamiento  
 ,@Calle  
 ,@Numero  
 )  
 Set @Id = SCOPE_IDENTITY()  
End  
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_Asentamientos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_CPMX_Asentamientos]
@IdEstado int,
@IdMunicipio int
As
Begin
	Select 
		IdAsentamiento,
		IdEstado,
		IdMunicipio,
		Asentamiento,
		CP
	From
		CPMX_Asentamientos
	Where
		IdMunicipio = @IdMunicipio and
		IdEstado = @IdEstado
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_AsentamientosCP]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPS_CPMX_AsentamientosCP]
@CP varchar(5)
As  
Begin  
 Select   
  IdAsentamiento,  
  IdEstado,  
  IdMunicipio,  
  Asentamiento,  
  CP  
 From  
  CPMX_Asentamientos  
 Where  
  CP = @CP
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_EstadoId]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_CPMX_EstadoId]
@Id int
As  
Begin  
 Select  
	IdEstado,  
	Estado  
 From  
	CPMX_Estados
 Where
	IdEstado = @Id
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_Estados]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_CPMX_Estados]
As
Begin
 Select
	IdEstado,
	Estado
 From
	CPMX_Estados
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_MunicipioPorEM]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_CPMX_MunicipioPorEM]  
@IdEstado int,
@IdMunicipio int
As  
Begin  
 Select  
  IdMunicipio,  
  IdEstado,  
  Municipio  
 From  
  CPMX_Municipios  
 Where  
  IdEstado = @IdEstado and
  IdMunicipio = @IdMunicipio
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_CPMX_MunicipiosPorEstado]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_CPMX_MunicipiosPorEstado]
@IdEstado int
As
Begin
	Select
		IdMunicipio,
		IdEstado,
		Municipio
	From
		CPMX_Municipios
	Where
		IdEstado = @IdEstado
End
GO
/****** Object:  StoredProcedure [dbo].[SPS_EXA_Datos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPS_EXA_Datos]  
As  
Begin  
 Select  
  IdDato  
  ,Nombre  
  ,PrimerApellido  
  ,SegundoApellido  
  ,FechaNacimiento  
  ,IdSexo  
  ,EstadoNacimiento  
  ,CURP  
  ,Telefono  
  ,DireccionActual  
  ,CP  
  ,Estado
  ,Municipio  
  ,Asentamiento  
  ,Calle  
  ,Numero  
 From  
  EXA_Datos  
End  
GO
/****** Object:  StoredProcedure [dbo].[SPS_PER_Sexos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_PER_Sexos]
As
Begin
 Select
	IdSexo,
	Descripcion
 From
	PER_Sexos
End
GO
/****** Object:  StoredProcedure [dbo].[SPU_EXA_Datos]    Script Date: 20/02/2020 04:24:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPU_EXA_Datos]  
@Nombre varchar(150),  
@PrimerApellido varchar(150),  
@SegundoApellido varchar(150),  
@FechaNacimiento Date,  
@IdSexo int,  
@EstadoNacimiento varchar(150),  
@CURP varchar(30),  
@Telefono varchar(25),  
@DireccionActual varchar(250),  
@CP varchar(5),  
@Estado varchar(170),
@Municipio varchar(170),  
@Asentamiento varchar(170),  
@Calle varchar(150),  
@Numero varchar(150),  
@Id int  
As  
Begin  
 Update EXA_Datos  
 Set  
  Nombre = @Nombre  
 ,PrimerApellido = @PrimerApellido  
 ,SegundoApellido = @SegundoApellido  
 ,FechaNacimiento = @FechaNacimiento  
 ,IdSexo = @IdSexo  
 ,EstadoNacimiento = @EstadoNacimiento  
 ,CURP = @CURP  
 ,Telefono = @Telefono  
 ,DireccionActual = @DireccionActual  
 ,CP = @CP  
 ,Estado = @Estado
 ,Municipio = @Municipio  
 ,Asentamiento = @Asentamiento  
 ,Calle = @Calle  
 ,Numero = @Numero  
 ,Modificacion = GETDATE()  
 Where  
 IdDato = @Id  
End
GO
USE [master]
GO
ALTER DATABASE [Data] SET  READ_WRITE 
GO
