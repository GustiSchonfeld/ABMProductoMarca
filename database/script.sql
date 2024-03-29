USE [master]
GO
/****** Object:  Database [Deportivo]    Script Date: 11/11/2019 04:47:19 ******/
CREATE DATABASE [Deportivo] 
GO
USE [Deportivo]
GO
/****** Object:  Table [dbo].[TiposTarjeta]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposTarjeta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](15) NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_TiposTarjeta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TiposTarjeta] ON
INSERT [dbo].[TiposTarjeta] ([ID], [Descripcion], [Borrado]) VALUES (1, N'Débito', 0)
INSERT [dbo].[TiposTarjeta] ([ID], [Descripcion], [Borrado]) VALUES (2, N'Crédito', 0)
SET IDENTITY_INSERT [dbo].[TiposTarjeta] OFF
/****** Object:  Table [dbo].[TipoProveedor]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProveedor](
	[id_tipoP] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProveedor] ON
INSERT [dbo].[TipoProveedor] ([id_tipoP], [descripcion], [borrado]) VALUES (1, N'Mayorista', 0)
INSERT [dbo].[TipoProveedor] ([id_tipoP], [descripcion], [borrado]) VALUES (2, N'Minorista', 0)
INSERT [dbo].[TipoProveedor] ([id_tipoP], [descripcion], [borrado]) VALUES (3, N'Productor', 0)
SET IDENTITY_INSERT [dbo].[TipoProveedor] OFF
/****** Object:  Table [dbo].[TipoFactura]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoFactura](
	[id_tipoFactura] [char](1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'A', N'Factura del tipo A', 0)
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'B', N'Factura del tipo B', 0)
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'C', N'Factura del tipo C', 0)
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'A', N'Factura del tipo A', 0)
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'B', N'Factura del tipo B', 0)
INSERT [dbo].[TipoFactura] ([id_tipoFactura], [descripcion], [borrado]) VALUES (N'C', N'Factura del tipo C', 0)
/****** Object:  Table [dbo].[TipoCliente]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoCliente](
	[id_tipoC] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoCliente] ON
INSERT [dbo].[TipoCliente] ([id_tipoC], [descripcion], [borrado]) VALUES (1, N'Mayorista', 0)
INSERT [dbo].[TipoCliente] ([id_tipoC], [descripcion], [borrado]) VALUES (2, N'Minorista', 0)
INSERT [dbo].[TipoCliente] ([id_tipoC], [descripcion], [borrado]) VALUES (3, N'Consumidor', 0)
SET IDENTITY_INSERT [dbo].[TipoCliente] OFF
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[TipoTarjeta] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tarjetas] ON
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (1, N'Visa', N'Nativa', 2, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (2, N'MasterCard', N'Nativa', 2, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (3, N'BBVA Visa', N'TarjetaVisaBBVA', 1, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (4, N'NacionMaestro', N'Maestro Banco Nacion', 1, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (5, N'Galicia', N'TarjetaGalicia', 1, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (6, N'Galicia', N'TarjetaGalicia', 2, 0)
INSERT [dbo].[Tarjetas] ([ID], [Nombre], [Descripcion], [TipoTarjeta], [Borrado]) VALUES (8, N'Naranja', N'TarjetaNaranja', 2, NULL)
SET IDENTITY_INSERT [dbo].[Tarjetas] OFF
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[cuit] [varchar](13) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (1, N'Perez', N'Enzo', N'20-30145238-7', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (2, N'Pratto', N'Lucas', N'20-31489721-6', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (3, N'Ponzio', N'Leonardo', N'20-29223890-5', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (4, N'Armani', N'Franco', N'20-32675231-4', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (6, N'Martinez Quarta', N'Lucas', N'20-39035289-2', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (7, N'Casco', N'Milton', N'20-35470981-1', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (8, N'Alvarez', N'Julian', N'20-42086156-8', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (9, N'Suarez', N'Matias', N'20-35489034-9', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (14, N'Almada', N'Pablo', N'20-43887698-5', 1)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (15, N'Juarez', N'Gonzalo', N'20-22225654-8', 1)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (16, N'Bologna', N'Beto', N'20-26089152-7', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (17, N'Ruiz', N'Susana', N'27-27677799-7', 0)
INSERT [dbo].[Clientes] ([id], [apellido], [nombre], [cuit], [borrado]) VALUES (18, N'Nuñez', N'Hilda', N'27-34565757-6', 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
/****** Object:  Table [dbo].[Ciudades]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudades](
	[id_ciudad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ciudades] ON
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (1, N'Córdoba', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (2, N'Jesús María', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (3, N'Carlos Paz', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (4, N'Cosquin', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (5, N'Arroyito', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (6, N'Río Cuarto', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (7, N'Río Tercero', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (8, N'Villa María', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (9, N'Alta Gracia', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (10, N'San Francisco', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (11, N'Bell-Ville', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (12, N'La Falda', 0)
INSERT [dbo].[Ciudades] ([id_ciudad], [nombre], [borrado]) VALUES (13, N'La Calera', 0)
SET IDENTITY_INSERT [dbo].[Ciudades] OFF
/****** Object:  Table [dbo].[Categorias]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON
INSERT [dbo].[Categorias] ([id_categoria], [descripcion], [borrado]) VALUES (1, N'Suplementos dietarios', 0)
INSERT [dbo].[Categorias] ([id_categoria], [descripcion], [borrado]) VALUES (2, N'Alimentos para celíacos', 0)
INSERT [dbo].[Categorias] ([id_categoria], [descripcion], [borrado]) VALUES (3, N'Alimentos orgánicos', 0)
INSERT [dbo].[Categorias] ([id_categoria], [descripcion], [borrado]) VALUES (4, N'Hierbas Medicinales', 0)
INSERT [dbo].[Categorias] ([id_categoria], [descripcion], [borrado]) VALUES (5, N'Alimentos dietéticos', 0)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
/****** Object:  Table [dbo].[Perfiles]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Vendedor', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Marketing', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Gerente', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Marcas]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (2, N'Nike', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (3, N'Adidas', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (4, N'Reebok', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (5, N'Fila', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (6, N'New Balance', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (7, N'Puma', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (8, N'pepe', 1)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (9, N'ohj', 1)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (10, N'Prostar', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (11, N'Ardidas', 1)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (12, N'af', 1)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (13, N'fdssasa', 1)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (14, N'Mitre', 0)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
/****** Object:  Table [dbo].[Formularios]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormasPago](
	[Id] [int] NULL,
	[Descripcion] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (2, N'Tarjeta')
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[id_factura_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[borrado] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FacturasDetalle] ON
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (1, 1, 2, CAST(400.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (2, 2, 1, CAST(500.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (3, 2, 8, CAST(400.00 AS Decimal(18, 2)), CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (4, 3, 4, CAST(135.00 AS Decimal(18, 2)), CAST(9 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (5, 4, 2, CAST(400.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (6, 5, 3, CAST(250.00 AS Decimal(18, 2)), CAST(0 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (7, 6, 3, CAST(250.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (8, 7, 4, CAST(135.00 AS Decimal(18, 2)), CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (9, 8, 10, CAST(500.00 AS Decimal(18, 2)), CAST(4 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (10, 8, 4, CAST(135.00 AS Decimal(18, 2)), CAST(5 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (11, 9, 3, CAST(250.00 AS Decimal(18, 2)), CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (12, 9, 1, CAST(500.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (13, 10, 2, CAST(400.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (14, 11, 1, CAST(500.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[FacturasDetalle] OFF
/****** Object:  Table [dbo].[Facturas]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[nro_factura] [int] NULL,
	[fecha] [date] NOT NULL,
	[cliente] [int] NULL,
	[tipoFactura] [char](1) NOT NULL,
	[subtotal] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](18, 2) NOT NULL,
	[borrado] [bit] NOT NULL,
	[formapago] [int] NULL,
	[tipotarjeta] [int] NULL,
	[tarjeta] [int] NULL,
	[nro_tarjeta] [int] NULL,
	[codigo] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (1, 0, CAST(0x32400B00 AS Date), 1, N'A', CAST(800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (2, 0, CAST(0x32400B00 AS Date), 2, N'A', CAST(5000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (3, 0, CAST(0xC53E0B00 AS Date), 6, N'B', CAST(1215.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (4, 0, CAST(0x32400B00 AS Date), 2, N'B', CAST(800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (5, 0, CAST(0x32400B00 AS Date), 4, N'B', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (6, 0, CAST(0x583D0B00 AS Date), 6, N'A', CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (10, 0, CAST(0x32400B00 AS Date), 2, N'B', CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, 1, 4, 234, 234234)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (11, 0, CAST(0x32400B00 AS Date), 2, N'B', CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, 1, 5, 234234, 23234)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (7, 0, CAST(0x32400B00 AS Date), 6, N'B', CAST(1350.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (8, 0, CAST(0x32400B00 AS Date), 16, N'A', CAST(2675.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [cliente], [tipoFactura], [subtotal], [descuento], [borrado], [formapago], [tipotarjeta], [tarjeta], [nro_tarjeta], [codigo]) VALUES (9, 0, CAST(0x32400B00 AS Date), 7, N'A', CAST(3500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
/****** Object:  Table [dbo].[EstadoProveedor]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoProveedor](
	[id_estadoP] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estadoP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoProveedor] ON
INSERT [dbo].[EstadoProveedor] ([id_estadoP], [descripcion], [borrado]) VALUES (1, N'En Alta', 0)
INSERT [dbo].[EstadoProveedor] ([id_estadoP], [descripcion], [borrado]) VALUES (2, N'De Baja', 0)
SET IDENTITY_INSERT [dbo].[EstadoProveedor] OFF
/****** Object:  Table [dbo].[EstadoCliente]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoCliente](
	[id_estadoC] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estadoC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoCliente] ON
INSERT [dbo].[EstadoCliente] ([id_estadoC], [descripcion], [borrado]) VALUES (1, N'En Alta', 0)
INSERT [dbo].[EstadoCliente] ([id_estadoC], [descripcion], [borrado]) VALUES (2, N'De Baja', 0)
SET IDENTITY_INSERT [dbo].[EstadoCliente] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_marca] [int] NULL,
	[cantidad] [int] NULL,
	[precio_venta] [float] NULL,
	[borrado] [bit] NULL,
	[fecha_alta] [datetime] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_Productos] ON [dbo].[Productos] 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (1, N'Pelota ', 2, 8, 500, 0, CAST(0x0000AA2F00000000 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (2, N'Remera', 4, 14, 400, 0, CAST(0x0000AA0E00000000 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (3, N'Short', 3, 5, 250, 0, CAST(0x0000AA0400000000 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (4, N'Medias', 4, 9, 135, 0, CAST(0x0000AA8100000000 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (5, N'Guantes ', 1, 4, 210, 0, CAST(0x0000AAE100000000 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (6, N'short', 3, 1, 350, 0, CAST(0x0000AAD4018384B7 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (7, N'zapatilla', 7, 2, 4000, 0, CAST(0x0000AADD013F901E AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (8, N'Gorro', 6, 4, 400, 0, CAST(0x0000AADD01447659 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (9, N'aa', 4, 2, 50, 1, CAST(0x0000AADE012C3696 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (10, N'Pantalon', 7, 2, 500, 0, CAST(0x0000AAE200CD0616 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (11, N'Guantes', 10, 4, 301, 0, CAST(0x0000AAE701578DA6 AS DateTime))
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado], [fecha_alta]) VALUES (12, N'Calza', 14, 4, 900, 0, CAST(0x0000AAE7015CCA22 AS DateTime))
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[tipoFactura] [char](1) NOT NULL,
	[nro_factura] [decimal](8, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[cliente] [int] NULL,
	[condiva] [varchar](40) NULL,
	[condventa] [varchar](20) NULL,
	[subtotal] [decimal](10, 2) NULL,
	[porc_descuento] [int] NULL,
	[importe_neto] [decimal](10, 2) NULL,
	[importe_iva] [decimal](10, 2) NULL,
	[importe_total] [decimal](10, 2) NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipoFactura] ASC,
	[nro_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(1 AS Decimal(8, 0)), CAST(0x2F3F0B00 AS Date), 4, N'Responsable Inscripto', N'Contado', CAST(2338.82 AS Decimal(10, 2)), 0, CAST(2338.82 AS Decimal(10, 2)), CAST(491.15 AS Decimal(10, 2)), CAST(2829.97 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(2 AS Decimal(8, 0)), CAST(0x423F0B00 AS Date), 1, N'Responsable Inscripto', N'Cuenta Corriente', CAST(16015.20 AS Decimal(10, 2)), 10, CAST(14413.68 AS Decimal(10, 2)), CAST(3026.87 AS Decimal(10, 2)), CAST(17440.55 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(3 AS Decimal(8, 0)), CAST(0x763F0B00 AS Date), 6, N'Responsable Inscripto', N'Contado', CAST(2750.54 AS Decimal(10, 2)), 0, CAST(2750.54 AS Decimal(10, 2)), CAST(577.61 AS Decimal(10, 2)), CAST(3328.15 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(4 AS Decimal(8, 0)), CAST(0x8B3F0B00 AS Date), 3, N'Responsable Inscripto', N'Cuenta Corriente', CAST(2921.59 AS Decimal(10, 2)), 0, CAST(2921.59 AS Decimal(10, 2)), CAST(613.53 AS Decimal(10, 2)), CAST(3535.12 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(5 AS Decimal(8, 0)), CAST(0xA63F0B00 AS Date), 6, N'Responsable Inscripto', N'Contado', CAST(9296.60 AS Decimal(10, 2)), 5, CAST(8831.77 AS Decimal(10, 2)), CAST(1854.67 AS Decimal(10, 2)), CAST(10686.44 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(6 AS Decimal(8, 0)), CAST(0xBD3F0B00 AS Date), 2, N'Responsable Inscripto', N'Cuenta Corriente', CAST(4867.64 AS Decimal(10, 2)), 5, CAST(4624.26 AS Decimal(10, 2)), CAST(971.09 AS Decimal(10, 2)), CAST(5595.35 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(7 AS Decimal(8, 0)), CAST(0xF43F0B00 AS Date), 2, N'Responsable Inscripto', N'Cuenta Corriente', CAST(681.85 AS Decimal(10, 2)), 0, CAST(681.85 AS Decimal(10, 2)), CAST(143.19 AS Decimal(10, 2)), CAST(825.04 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(8 AS Decimal(8, 0)), CAST(0x0D400B00 AS Date), 2, N'Responsable Inscripto', N'Cuenta Corriente', CAST(4563.16 AS Decimal(10, 2)), 0, CAST(4563.16 AS Decimal(10, 2)), CAST(958.26 AS Decimal(10, 2)), CAST(5521.42 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(9 AS Decimal(8, 0)), CAST(0x21400B00 AS Date), 5, N'Responsable Inscripto', N'Contado', CAST(8641.23 AS Decimal(10, 2)), 5, CAST(8209.17 AS Decimal(10, 2)), CAST(1723.93 AS Decimal(10, 2)), CAST(9933.10 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(10 AS Decimal(8, 0)), CAST(0x50400B00 AS Date), 6, N'Responsable Inscripto', N'Contado', CAST(13580.17 AS Decimal(10, 2)), 0, CAST(13580.17 AS Decimal(10, 2)), CAST(2851.84 AS Decimal(10, 2)), CAST(16432.01 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(11 AS Decimal(8, 0)), CAST(0xEF3F0B00 AS Date), 1, N'Responsable Inscripto', N'Tarjeta', CAST(2472.90 AS Decimal(10, 2)), 0, CAST(2472.90 AS Decimal(10, 2)), CAST(519.31 AS Decimal(10, 2)), CAST(2992.21 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(12 AS Decimal(8, 0)), CAST(0x993F0B00 AS Date), 1, N'Responsable Inscripto', N'Contado', CAST(9854.20 AS Decimal(10, 2)), 0, CAST(9854.20 AS Decimal(10, 2)), CAST(2069.38 AS Decimal(10, 2)), CAST(11923.58 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(13 AS Decimal(8, 0)), CAST(0xEA3F0B00 AS Date), 5, N'Responsable Inscripto', N'Tarjeta', CAST(4749.24 AS Decimal(10, 2)), 0, CAST(4749.24 AS Decimal(10, 2)), CAST(997.34 AS Decimal(10, 2)), CAST(5746.58 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'A', CAST(14 AS Decimal(8, 0)), CAST(0xBB3F0B00 AS Date), 6, N'Responsable Inscripto', N'Contado', CAST(5187.36 AS Decimal(10, 2)), 0, CAST(5187.36 AS Decimal(10, 2)), CAST(1089.35 AS Decimal(10, 2)), CAST(6276.71 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(1 AS Decimal(8, 0)), CAST(0x263F0B00 AS Date), 9, N'Consumidor Final', N'Tarjeta', CAST(3746.02 AS Decimal(10, 2)), 0, CAST(3746.02 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(3746.02 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(2 AS Decimal(8, 0)), CAST(0x4D3F0B00 AS Date), 10, N'Consumidor Final', N'Contado', CAST(2351.40 AS Decimal(10, 2)), 0, CAST(2351.40 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(2351.40 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(3 AS Decimal(8, 0)), CAST(0x703F0B00 AS Date), 5, N'Consumidor Final', N'Cuenta Corriente', CAST(4323.30 AS Decimal(10, 2)), 0, CAST(4323.30 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(4323.30 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(4 AS Decimal(8, 0)), CAST(0x953F0B00 AS Date), 2, N'Consumidor Final', N'Tarjeta', CAST(6423.81 AS Decimal(10, 2)), 0, CAST(6423.81 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(6423.81 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(5 AS Decimal(8, 0)), CAST(0xA23F0B00 AS Date), 7, N'Consumidor Final', N'Contado', CAST(6057.16 AS Decimal(10, 2)), 0, CAST(6057.16 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(6057.16 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(6 AS Decimal(8, 0)), CAST(0xCA3F0B00 AS Date), 8, N'Consumidor Final', N'Contado', CAST(5083.59 AS Decimal(10, 2)), 0, CAST(5083.59 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(5083.59 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(7 AS Decimal(8, 0)), CAST(0xE63F0B00 AS Date), 8, N'Consumidor Final', N'Tarjeta', CAST(3019.20 AS Decimal(10, 2)), 5, CAST(2868.24 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(2868.24 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(8 AS Decimal(8, 0)), CAST(0xFB3F0B00 AS Date), 8, N'Consumidor Final', N'Contado', CAST(5306.54 AS Decimal(10, 2)), 0, CAST(5306.54 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(5306.54 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(9 AS Decimal(8, 0)), CAST(0x30400B00 AS Date), 7, N'Consumidor Final', N'Cuenta Corriente', CAST(1929.69 AS Decimal(10, 2)), 0, CAST(1929.69 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(1929.69 AS Decimal(10, 2)), 0)
INSERT [dbo].[Ventas] ([tipoFactura], [nro_factura], [fecha], [cliente], [condiva], [condventa], [subtotal], [porc_descuento], [importe_neto], [importe_iva], [importe_total], [borrado]) VALUES (N'B', CAST(10 AS Decimal(8, 0)), CAST(0x50400B00 AS Date), 2, N'Consumidor Final', N'Cuenta Corriente', CAST(1693.47 AS Decimal(10, 2)), 0, CAST(1693.47 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(1693.47 AS Decimal(10, 2)), 0)
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'ADMIN', N'123', N'admin@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Vendedor1', N'1234', N'vendedor@yahoo.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'UsuarioMercado', N'mercado', N'usuariomercado@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 2, N'Vendedor2', N'1234', N'vend@yahoo.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'UsrMercado', N'mercado', N'usrmercado@hotmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 4, N'Principal', N'12345678', N'general@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (11, 2, N'Vendedor3', N'1234', N'vendedor3@gmail.com', N'S', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Permisos]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetVentas]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetVentas](
	[tipo_factura] [char](1) NOT NULL,
	[nro_factura] [decimal](8, 0) NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio] [decimal](10, 2) NULL,
	[cantidad] [int] NULL,
	[importe] [decimal](10, 2) NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_factura] ASC,
	[nro_factura] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(1 AS Decimal(8, 0)), 8, CAST(167.06 AS Decimal(10, 2)), 12, CAST(2004.72 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(1 AS Decimal(8, 0)), 15, CAST(33.41 AS Decimal(10, 2)), 10, CAST(334.10 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(2 AS Decimal(8, 0)), 4, CAST(175.90 AS Decimal(10, 2)), 12, CAST(2110.80 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(2 AS Decimal(8, 0)), 13, CAST(579.35 AS Decimal(10, 2)), 24, CAST(13904.40 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(3 AS Decimal(8, 0)), 3, CAST(189.50 AS Decimal(10, 2)), 13, CAST(2463.50 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(3 AS Decimal(8, 0)), 7, CAST(12.48 AS Decimal(10, 2)), 23, CAST(287.04 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(4 AS Decimal(8, 0)), 10, CAST(114.81 AS Decimal(10, 2)), 8, CAST(918.48 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(4 AS Decimal(8, 0)), 16, CAST(117.83 AS Decimal(10, 2)), 17, CAST(2003.11 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(5 AS Decimal(8, 0)), 1, CAST(643.54 AS Decimal(10, 2)), 14, CAST(9009.56 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(5 AS Decimal(8, 0)), 7, CAST(12.48 AS Decimal(10, 2)), 23, CAST(287.04 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(6 AS Decimal(8, 0)), 9, CAST(290.20 AS Decimal(10, 2)), 13, CAST(3772.60 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(6 AS Decimal(8, 0)), 11, CAST(68.44 AS Decimal(10, 2)), 16, CAST(1095.04 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(7 AS Decimal(8, 0)), 14, CAST(52.45 AS Decimal(10, 2)), 13, CAST(681.85 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(8 AS Decimal(8, 0)), 3, CAST(189.50 AS Decimal(10, 2)), 10, CAST(1895.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(8 AS Decimal(8, 0)), 6, CAST(242.56 AS Decimal(10, 2)), 11, CAST(2668.16 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(9 AS Decimal(8, 0)), 5, CAST(542.57 AS Decimal(10, 2)), 11, CAST(5968.27 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(9 AS Decimal(8, 0)), 8, CAST(167.06 AS Decimal(10, 2)), 16, CAST(2672.96 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(10 AS Decimal(8, 0)), 1, CAST(643.54 AS Decimal(10, 2)), 13, CAST(8366.02 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(10 AS Decimal(8, 0)), 13, CAST(579.35 AS Decimal(10, 2)), 9, CAST(5214.15 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(11 AS Decimal(8, 0)), 10, CAST(114.81 AS Decimal(10, 2)), 10, CAST(1148.10 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(11 AS Decimal(8, 0)), 17, CAST(110.40 AS Decimal(10, 2)), 12, CAST(1324.80 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(12 AS Decimal(8, 0)), 9, CAST(290.20 AS Decimal(10, 2)), 10, CAST(2902.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(12 AS Decimal(8, 0)), 13, CAST(579.35 AS Decimal(10, 2)), 12, CAST(6952.20 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(13 AS Decimal(8, 0)), 9, CAST(290.20 AS Decimal(10, 2)), 12, CAST(3482.40 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(13 AS Decimal(8, 0)), 18, CAST(74.52 AS Decimal(10, 2)), 17, CAST(1266.84 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(14 AS Decimal(8, 0)), 6, CAST(242.56 AS Decimal(10, 2)), 18, CAST(4366.08 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'A', CAST(14 AS Decimal(8, 0)), 11, CAST(68.44 AS Decimal(10, 2)), 12, CAST(821.28 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(1 AS Decimal(8, 0)), 6, CAST(242.56 AS Decimal(10, 2)), 12, CAST(2910.72 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(1 AS Decimal(8, 0)), 8, CAST(167.06 AS Decimal(10, 2)), 5, CAST(835.30 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(2 AS Decimal(8, 0)), 11, CAST(68.44 AS Decimal(10, 2)), 15, CAST(1026.60 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(2 AS Decimal(8, 0)), 17, CAST(110.40 AS Decimal(10, 2)), 12, CAST(1324.80 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(3 AS Decimal(8, 0)), 4, CAST(175.90 AS Decimal(10, 2)), 21, CAST(3693.90 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(3 AS Decimal(8, 0)), 14, CAST(52.45 AS Decimal(10, 2)), 12, CAST(629.40 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(4 AS Decimal(8, 0)), 2, CAST(339.93 AS Decimal(10, 2)), 13, CAST(4419.09 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(4 AS Decimal(8, 0)), 8, CAST(167.06 AS Decimal(10, 2)), 12, CAST(2004.72 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(5 AS Decimal(8, 0)), 9, CAST(290.20 AS Decimal(10, 2)), 16, CAST(4643.20 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(5 AS Decimal(8, 0)), 16, CAST(117.83 AS Decimal(10, 2)), 12, CAST(1413.96 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(6 AS Decimal(8, 0)), 5, CAST(542.57 AS Decimal(10, 2)), 9, CAST(4883.13 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(6 AS Decimal(8, 0)), 15, CAST(33.41 AS Decimal(10, 2)), 6, CAST(200.46 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(7 AS Decimal(8, 0)), 3, CAST(189.50 AS Decimal(10, 2)), 12, CAST(2274.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(7 AS Decimal(8, 0)), 18, CAST(74.52 AS Decimal(10, 2)), 10, CAST(745.20 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(8 AS Decimal(8, 0)), 2, CAST(339.93 AS Decimal(10, 2)), 14, CAST(4759.02 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(8 AS Decimal(8, 0)), 11, CAST(68.44 AS Decimal(10, 2)), 8, CAST(547.52 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(9 AS Decimal(8, 0)), 7, CAST(12.48 AS Decimal(10, 2)), 13, CAST(162.24 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(9 AS Decimal(8, 0)), 16, CAST(117.83 AS Decimal(10, 2)), 15, CAST(1767.45 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(10 AS Decimal(8, 0)), 15, CAST(33.41 AS Decimal(10, 2)), 15, CAST(501.15 AS Decimal(10, 2)), 0)
INSERT [dbo].[DetVentas] ([tipo_factura], [nro_factura], [id_producto], [precio], [cantidad], [importe], [borrado]) VALUES (N'B', CAST(10 AS Decimal(8, 0)), 18, CAST(74.52 AS Decimal(10, 2)), 16, CAST(1192.32 AS Decimal(10, 2)), 0)
/****** Object:  Table [dbo].[Barrios]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ciudad] [int] NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Barrios] ON
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (1, N'Alberdi', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (2, N'Nueva Cordoba', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (3, N'Centro', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (4, N'Junior', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (5, N'Gral Paz', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (6, N'Alta Córdoba', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (7, N'Talleres Este', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (8, N'Talleres Oeste', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (9, N'Villa Esquiú', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (10, N'Yofre Norte', 1, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (11, N'Centro', 2, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (12, N'Barrancas', 2, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (13, N'Pueblo Nuevo', 2, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (14, N'Centro', 3, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (15, N'La Cuesta', 3, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (16, N'Costa Azul Sur', 3, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (17, N'Altos de las Vertientes', 3, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (18, N'Villa del Lago', 3, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (19, N'Centro', 4, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (20, N'Cumbre Azul', 4, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (21, N'Pan de Azucar', 4, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (22, N'Alto Mieres', 4, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (23, N'Yacanto', 5, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (24, N'Centro', 5, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (25, N'Los Reartes', 5, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (26, N'San Javier', 5, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (27, N'Centro', 6, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (28, N'Banda Norte', 6, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (29, N'Abilene', 6, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (30, N'Centro', 7, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (31, N'Golf Club', 7, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (32, N'Las Quintas', 7, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (33, N'Centro', 8, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (34, N'Obrero', 8, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (35, N'Centro', 9, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (36, N'1° de Mayo', 9, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (37, N'Parque del Virrey', 9, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (38, N'Centro', 10, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (39, N'Las Rosas', 10, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (40, N'Maipú', 10, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (41, N'Centro', 11, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (42, N'El Prado', 11, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (43, N'Santa Rosa', 12, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (44, N'Valle Verde', 12, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (45, N'Centro', 13, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (46, N'Stoecklin', 13, 0)
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [ciudad], [borrado]) VALUES (47, N'Villa Los Paraísos', 13, 0)
SET IDENTITY_INSERT [dbo].[Barrios] OFF
/****** Object:  Table [dbo].[Proveedores]    Script Date: 11/11/2019 04:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](13) NULL,
	[nombre_local] [varchar](50) NULL,
	[nombre_proveedor] [varchar](50) NOT NULL,
	[domicilio_calle] [varchar](50) NOT NULL,
	[domicilio_numero] [int] NOT NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fecha_registro] [date] NULL,
	[barrio] [int] NULL,
	[tipo_proveedor] [int] NULL,
	[estado_proveedor] [int] NULL,
	[borrado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (1, N'32-25749163-6', N'Herboeste', N'Juan Muriega', N'Av. Juan B. Justo', 364, N'03532-42541', N'info@herboeste.com.ar', CAST(0x50400B00 AS Date), 13, 1, 1, 0)
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (2, N'35-24987632-1', N'Bio-Salud', N'Ernesto Suazo', N'Bv. Los Alemanes', 2345, N'3543-425147', N'ventas@bio-salud.com.ar', CAST(0x50400B00 AS Date), 7, 1, 1, 0)
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (3, N'34-85796424-5', N'Hierbas Guiral', N'Josefina Sábato', N'Bv. San Juan', 234, N'0351-4245588', N'ventas@guiral.com.ar', CAST(0x50400B00 AS Date), 2, 2, 1, 0)
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (4, N'36-24579654-4', N'Hierbas Suquia', N'Luis Herrera', N'Crisol', 1234, N'03543-425687', N'info@hierbassuquia.com.ar', CAST(0x50400B00 AS Date), 14, 3, 1, 0)
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (5, N'37-12587963-2', N'Verde Menta', N'Ezequiel Carrizo', N'Obispo Salguero', 456, N'0351-4268754', N'info@v-menta.com.ar', CAST(0x50400B00 AS Date), 5, 1, 1, 0)
INSERT [dbo].[Proveedores] ([id_proveedor], [cuit], [nombre_local], [nombre_proveedor], [domicilio_calle], [domicilio_numero], [telefono], [email], [fecha_registro], [barrio], [tipo_proveedor], [estado_proveedor], [borrado]) VALUES (6, N'31-21246635-7', N'Granja del Centro', N'Carla Ozán', N'Isabel La Católica', 345, N'0351-4578962', N'ventas@granjadelcentro.com.ar', CAST(0x50400B00 AS Date), 6, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
/****** Object:  Default [DF__TipoProve__borra__6754599E]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[TipoProveedor] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__TipoFactu__borra__68487DD7]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[TipoFactura] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__TipoClien__borra__693CA210]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[TipoCliente] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Clientes__borrad__6D0D32F4]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Ciudades__borrad__6A30C649]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Ciudades] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Categoria__borra__6B24EA82]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Categorias] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Perfiles__borrad__628FA481]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Perfiles] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__EstadoPro__borra__6383C8BA]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[EstadoProveedor] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__EstadoCli__borra__6477ECF3]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[EstadoCliente] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Productos__borra__6EF57B66]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Ventas__importe___6FE99F9F]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT ((0)) FOR [importe_iva]
GO
/****** Object:  Default [DF__Ventas__borrado__70DDC3D8]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Usuarios__estado__656C112C]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ('S') FOR [estado]
GO
/****** Object:  Default [DF__Usuarios__borrad__66603565]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__DetVentas__borra__71D1E811]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[DetVentas] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Barrios__borrado__6C190EBB]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Barrios] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Proveedor__borra__6E01572D]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Proveedores] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  ForeignKey [FK_Productos_Marcas]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
/****** Object:  ForeignKey [FK_Usuarios_Perfiles]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
/****** Object:  ForeignKey [FK_Permisos_Formularios]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
/****** Object:  ForeignKey [FK_Permisos_Perfiles]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
/****** Object:  ForeignKey [FK__DetVentas__787EE5A0]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[DetVentas]  WITH CHECK ADD FOREIGN KEY([tipo_factura], [nro_factura])
REFERENCES [dbo].[Ventas] ([tipoFactura], [nro_factura])
GO
/****** Object:  ForeignKey [FK_Ciudad]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Ciudad] FOREIGN KEY([ciudad])
REFERENCES [dbo].[Ciudades] ([id_ciudad])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_Ciudad]
GO
/****** Object:  ForeignKey [FK_barrioP]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_barrioP] FOREIGN KEY([barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_barrioP]
GO
/****** Object:  ForeignKey [FK_estado_proveedor]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_estado_proveedor] FOREIGN KEY([estado_proveedor])
REFERENCES [dbo].[EstadoProveedor] ([id_estadoP])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_estado_proveedor]
GO
/****** Object:  ForeignKey [FK_tipo_proveedor]    Script Date: 11/11/2019 04:47:20 ******/
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_tipo_proveedor] FOREIGN KEY([tipo_proveedor])
REFERENCES [dbo].[TipoProveedor] ([id_tipoP])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_tipo_proveedor]
GO
