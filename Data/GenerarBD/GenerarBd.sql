USE [master]
GO
/****** Object:  Database [DBVENTAS]    Script Date: 30/9/2024 21:58:50 ******/
CREATE DATABASE [DBVENTAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBVENTAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\DBVENTAS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBVENTAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\DBVENTAS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBVENTAS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBVENTAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBVENTAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBVENTAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBVENTAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBVENTAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBVENTAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBVENTAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBVENTAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBVENTAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBVENTAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBVENTAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBVENTAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBVENTAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBVENTAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBVENTAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBVENTAS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBVENTAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBVENTAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBVENTAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBVENTAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBVENTAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBVENTAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBVENTAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBVENTAS] SET RECOVERY FULL 
GO
ALTER DATABASE [DBVENTAS] SET  MULTI_USER 
GO
ALTER DATABASE [DBVENTAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBVENTAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBVENTAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBVENTAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBVENTAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBVENTAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBVENTAS', N'ON'
GO
ALTER DATABASE [DBVENTAS] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBVENTAS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBVENTAS]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPRA]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPRA](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdProveedor] [int] NULL,
	[TipoDocumento] [varchar](50) NULL,
	[Documento] [varchar](50) NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_COMPRA]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_COMPRA](
	[IdDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdCompra] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioCompra] [decimal](10, 2) NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_VENTA]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_VENTA](
	[IdDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[Subtotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISO](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[NombreMenu] [varchar](50) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
	[IdCategoria] [int] NULL,
	[Stock] [int] NOT NULL,
	[PrecioCompra] [decimal](10, 2) NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[RazonSocial] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[NombreCompleto] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[IdRol] [int] NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTA]    Script Date: 30/9/2024 21:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTA](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[TipoDocumento] [varchar](50) NULL,
	[Documento] [varchar](50) NULL,
	[DocumentoCliente] [varchar](50) NULL,
	[NombreCliente] [varchar](100) NULL,
	[MontoPago] [decimal](10, 2) NULL,
	[MontoCambio] [decimal](10, 2) NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PERMISO] ON 

INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (1, 1, N'SettingsLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (2, 1, N'UserLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (3, 1, N'VentasLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (4, 1, N'ComprasLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (5, 1, N'ClientesLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (6, 1, N'ProveedoresLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (7, 1, N'ReportesLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (8, 1, N'AcercaLabel', CAST(N'2024-09-24T12:25:39.137' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (9, 2, N'VentasLabel', CAST(N'2024-09-24T12:29:32.107' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (10, 2, N'ComprasLabel', CAST(N'2024-09-24T12:29:32.107' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (11, 2, N'ClientesLabel', CAST(N'2024-09-24T12:29:32.107' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (12, 2, N'ProveedoresLabel', CAST(N'2024-09-24T12:29:32.107' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (13, 2, N'AcercaLabel', CAST(N'2024-09-24T12:29:32.107' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (14, 3, N'UserLabel', CAST(N'2024-09-30T17:05:35.103' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (15, 3, N'ReportesLabel', CAST(N'2024-09-30T17:06:43.853' AS DateTime))
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaCreacion]) VALUES (16, 3, N'AcercaLabel', CAST(N'2024-09-30T17:06:43.853' AS DateTime))
SET IDENTITY_INSERT [dbo].[PERMISO] OFF
GO
SET IDENTITY_INSERT [dbo].[ROL] ON 

INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaCreacion]) VALUES (1, N'ADMINISTRADOR', CAST(N'2024-09-23T15:52:03.697' AS DateTime))
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaCreacion]) VALUES (2, N'EMPLEADO', CAST(N'2024-09-24T12:27:21.550' AS DateTime))
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaCreacion]) VALUES (3, N'GERENTE', CAST(N'2024-09-30T09:26:00.343' AS DateTime))
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaCreacion]) VALUES (1, N'43532954', N'ADMIN', N'admin@mail.com', N'123', 1, 1, CAST(N'2024-09-23T15:52:03.697' AS DateTime))
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaCreacion]) VALUES (2, N'000', N'Empleado', N'empleado@mail.com', N'123', 2, 1, CAST(N'2024-09-24T12:37:58.983' AS DateTime))
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaCreacion]) VALUES (3, N'1111', N'Gerente', N'gerente@gerente.com', N'gerente', 3, 1, CAST(N'2024-09-30T16:49:08.953' AS DateTime))
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[CLIENTE] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[COMPRA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD  DEFAULT ((0)) FOR [PrecioCompra]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD  DEFAULT ((0)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[DETALLE_VENTA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[PERMISO] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [PrecioCompra]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[PROVEEDOR] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[ROL] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[VENTA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[PROVEEDOR] ([IdProveedor])
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD FOREIGN KEY([IdCompra])
REFERENCES [dbo].[COMPRA] ([IdCompra])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD FOREIGN KEY([IdVenta])
REFERENCES [dbo].[VENTA] ([IdVenta])
GO
ALTER TABLE [dbo].[PERMISO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CATEGORIA] ([IdCategoria])
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
USE [master]
GO
ALTER DATABASE [DBVENTAS] SET  READ_WRITE 
GO
