CREATE DATABASE Abarrotes

/*-------------------------------------------------------CREACION DE BASE DE DATOS*/

USE [Abarrotes]
GO
/****** Object:  Table [dbo].[Cartera]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cartera](
	[cartera_auto] [int] IDENTITY(1,1) NOT NULL,
	[no_venta] [int] NOT NULL,
	[cod_cliente] [varchar](8) NULL,
	[fecha] [date] NULL,
	[cargo] [float] NULL,
	[abono] [float] NULL,
	[adeudo] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_auto] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [varchar](8) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Ap_Paterno] [varchar](50) NULL,
	[Ap_Materno] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[cod_venta] [int] NULL,
	[cod_producto] [varchar](8) NULL,
	[cantidad] [float] NULL,
	[categoria] [varchar](10) NULL,
	[precio] [float] NULL,
	[sub_total] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[cod_producto] [varchar](8) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[Marca] [varchar](50) NULL,
	[categoria] [varchar](50) NULL,
	[departamento] [varchar](50) NULL,
	[cantidad] [float] NULL,
	[precio_compra] [float] NULL,
	[IVA] [varchar](50) NULL,
	[precio_unitario] [float] NULL,
	[precio_publico] [float] NULL,
	[aviso_cantidad] [float] NULL,
	[cod_proveedor] [int] NULL,
	[auto_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[cod_pedido] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [varchar](8) NULL,
	[Cantidad] [float] NULL,
	[Fecha_Pedido] [date] NULL,
	[cod_proveedor] [int] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[cod_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[cod_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Empresa] [varchar](50) NULL,
	[Direccion_Emp] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[cod_venta] [int] IDENTITY(1,1) NOT NULL,
	[no_venta] [int] NULL,
	[tipo_venta] [varchar](10) NULL,
	[fecha_venta] [date] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[cod_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Pendiente]    Script Date: 15/05/2018 19:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pendiente] 
AS SELECT cod_producto,descripcion FROM Inventario WHERE cod_producto IN(SELECT cod_producto FROM Inventario EXCEPT SELECT cod_producto FROM Proveedor) 


GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

GO
INSERT [dbo].[Cliente] ([id_auto], [cod_cliente], [Nombre], [Ap_Paterno], [Ap_Materno], [Telefono], [Direccion]) VALUES (2, N'AE_01', N'Alejandro', N'Esquer', N'Diaz', 1584275, N'Enrique Quijada 124')
GO
INSERT [dbo].[Cliente] ([id_auto], [cod_cliente], [Nombre], [Ap_Paterno], [Ap_Materno], [Telefono], [Direccion]) VALUES (5, N'LE_01', N'Lenika', N'Guerrero', N'Vasquez', 2643158, N'Rebeico 546')
GO
INSERT [dbo].[Cliente] ([id_auto], [cod_cliente], [Nombre], [Ap_Paterno], [Ap_Materno], [Telefono], [Direccion]) VALUES (3, N'LU_01', N'Luis', N'Peralta', N'Diaz', 2648123, N'San Rafael 547')
GO
INSERT [dbo].[Cliente] ([id_auto], [cod_cliente], [Nombre], [Ap_Paterno], [Ap_Materno], [Telefono], [Direccion]) VALUES (4, N'MA_01', N'Marco', N'Guerrero', N'Lozano', 21733904, N'Querobabi 301')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (4, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (74, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (74, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (11, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (75, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (76, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (14, N'CH_01', 1.5, N'Kg', 15, 22.5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (76, N'LA_05', 2, N'Pza', 5, 10)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (16, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (17, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (18, N'LA_05', 2, N'Pza', 5, 10)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (77, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (77, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (78, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (78, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (79, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (80, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (22, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (23, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (24, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (25, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (26, N'FA_01', 2, N'Pza', 12, 24)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (27, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (28, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (29, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (30, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (31, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (32, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (33, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (34, N'CH_01', 1.5, N'Kg', 15, 22.5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (35, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (36, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (37, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (38, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (39, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (40, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (41, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (42, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (43, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (44, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (45, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (46, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (47, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (48, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (49, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (50, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (51, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (52, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (53, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (54, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (55, N'CH_01', 2, N'Kg', 15, 30)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (56, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (57, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (58, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (59, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (60, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (61, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (62, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (63, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (64, N'AG_03', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (65, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (66, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (67, N'AG_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (68, N'TO_01', 1, N'Pza', 13, 13)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (69, N'FA_01', 1, N'Pza', 12, 12)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (70, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (71, N'CH_01', 1, N'Kg', 15, 15)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (72, N'LA_05', 1, N'Pza', 5, 5)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (73, N'AG_02', 1, N'Pza', 8, 8)
GO
INSERT [dbo].[Detalle_Venta] ([cod_venta], [cod_producto], [cantidad], [categoria], [precio], [sub_total]) VALUES (73, N'LA_05', 1, N'Pza', 5, 5)
GO
SET IDENTITY_INSERT [dbo].[Inventario] ON 

GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'AG_01', N'Agua 1lt', N'Ciel', N'Pieza', N'Abarrotes', 23, 10, N'IVA 16%', 11.6, 12, 5, 1, 2)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'AG_02', N'Agua 500ml', N'Ciel', N'Pieza', N'Abarrotes', 20, 3, N'Tasa Cero', 3, 8, 5, 1, 3)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'AG_03', N'Aguacate', N'Aguacatin', N'Kilo', N'Abarrotes', 21, 10, N'IVA 16%', 11.6, 15, 2, 7, 10)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'CH_01', N'Chorizo', N'HC', N'Kilo', N'Abarrotes', 20, 10, N'IVA 16%', 11.6, 15, 2, 3, 8)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'FA_01', N'Eucalipto- Jazmin', N'Fabuloso', N'Pieza', N'General', 0, 8, N'Tasa Cero', 8, 12, 5, 5, 6)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'LA_05', N'Lapiz', N'BIC', N'Pieza', N'General', 20, 2, N'Tasa Cero', 2, 5, 2, 4, 7)
GO
INSERT [dbo].[Inventario] ([cod_producto], [descripcion], [Marca], [categoria], [departamento], [cantidad], [precio_compra], [IVA], [precio_unitario], [precio_publico], [aviso_cantidad], [cod_proveedor], [auto_id]) VALUES (N'TO_01', N'Tostitos N', N'Sabritas', N'Pieza', N'Abarrotes', 19, 10, N'IVA 16%', 11.6, 13, 10, 2, 4)
GO
SET IDENTITY_INSERT [dbo].[Inventario] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (1, N'Proveedor CocaCola', 1154879, N'Cocacola', N'Luis Encinas 15')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (2, N'Proveedor Sabritas', 1548756, N'Sabritas', N'Capomo 123')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (3, N'Luis', 2842845, N'Chorizo H.C.', N'General Piña 240')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (4, N'Gabriel', 1234567, N'Sams', N'Morelos 111')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (5, N'Gabriel', 2345678, N'Costco', N'Colosio 10')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (7, N'Proveedor Maldonado', 2583691, N'Maldonado', N'Solidaridad 2')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (10, N'Pepe', 1544712, N'asdas', N'asdasda')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (11, N'Amanda', 8978456, N'Cosmeticos', N'Bacobampo 200')
GO
INSERT [dbo].[Proveedor] ([cod_proveedor], [Nombre], [Telefono], [Empresa], [Direccion_Emp]) VALUES (12, N'Proveedor Arenas', 9873211, N'Arenas', N'Torres 554')
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (4, 1, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (5, 2, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (6, 3, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (7, 4, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (8, 5, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (9, 6, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (10, 7, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (11, 8, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (12, 9, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (13, 10, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (14, 11, N'Efectivo', CAST(0x173E0B00 AS Date), 22.5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (15, 12, N'Efectivo', CAST(0x173E0B00 AS Date), 36.5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (16, 13, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (17, 14, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (18, 15, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (19, 16, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (20, 17, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (21, 18, N'Efectivo', CAST(0x173E0B00 AS Date), 7)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (22, 19, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (23, 20, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (24, 21, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (25, 22, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (26, 23, N'Efectivo', CAST(0x173E0B00 AS Date), 24)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (27, 24, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (28, 25, N'Efectivo', CAST(0x173E0B00 AS Date), 8)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (29, 26, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (30, 27, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (31, 28, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (32, 29, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (33, 30, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (34, 31, N'Efectivo', CAST(0x173E0B00 AS Date), 22.5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (35, 32, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (36, 33, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (37, 34, N'Efectivo', CAST(0x173E0B00 AS Date), 20)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (38, 35, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (39, 36, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (40, 37, N'Efectivo', CAST(0x173E0B00 AS Date), 30)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (41, 38, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (42, 39, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (43, 40, N'Efectivo', CAST(0x173E0B00 AS Date), 26)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (44, 41, N'Efectivo', CAST(0x173E0B00 AS Date), 38)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (45, 42, N'Efectivo', CAST(0x173E0B00 AS Date), 50)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (46, 43, N'Efectivo', CAST(0x173E0B00 AS Date), 62)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (47, 44, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (48, 45, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (49, 46, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (50, 47, N'Efectivo', CAST(0x173E0B00 AS Date), 8)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (51, 48, N'Efectivo', CAST(0x173E0B00 AS Date), 20)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (52, 49, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (53, 50, N'Efectivo', CAST(0x173E0B00 AS Date), 8)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (54, 51, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (55, 52, N'Efectivo', CAST(0x173E0B00 AS Date), 30)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (56, 53, N'Efectivo', CAST(0x173E0B00 AS Date), 5)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (57, 54, N'Efectivo', CAST(0x173E0B00 AS Date), 8)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (58, 55, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (59, 56, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (60, 57, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (61, 58, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (62, 59, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (63, 60, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (64, 61, N'Efectivo', CAST(0x173E0B00 AS Date), 15)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (65, 62, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (66, 63, N'Efectivo', CAST(0x173E0B00 AS Date), 8)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (67, 64, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (68, 65, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (69, 66, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (70, 67, N'Efectivo', CAST(0x173E0B00 AS Date), 20)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (71, 68, N'Efectivo', CAST(0x173E0B00 AS Date), 28)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (72, 69, N'Efectivo', CAST(0x173E0B00 AS Date), 21)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (73, 70, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (74, 71, N'Efectivo', CAST(0x173E0B00 AS Date), 28)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (75, 72, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (76, 73, N'Efectivo', CAST(0x173E0B00 AS Date), 22)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (77, 74, N'Efectivo', CAST(0x173E0B00 AS Date), 30)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (78, 75, N'Efectivo', CAST(0x173E0B00 AS Date), 20)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (79, 76, N'Efectivo', CAST(0x173E0B00 AS Date), 13)
GO
INSERT [dbo].[Venta] ([cod_venta], [no_venta], [tipo_venta], [fecha_venta], [total]) VALUES (80, 77, N'Efectivo', CAST(0x173E0B00 AS Date), 12)
GO
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
/****** Object:  Index [UQ_Cliente_Telefono]    Script Date: 15/05/2018 19:25:46 ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UQ_Cliente_Telefono] UNIQUE NONCLUSTERED 
(
	[Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Proveedor_Telefono]    Script Date: 15/05/2018 19:25:46 ******/
ALTER TABLE [dbo].[Proveedor] ADD  CONSTRAINT [UQ_Proveedor_Telefono] UNIQUE NONCLUSTERED 
(
	[Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cartera]  WITH CHECK ADD  CONSTRAINT [FK_Cartera_Cliente] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[Cliente] ([cod_cliente])
GO
ALTER TABLE [dbo].[Cartera] CHECK CONSTRAINT [FK_Cartera_Cliente]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Inventario] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Inventario] ([cod_producto])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Inventario]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Venta] FOREIGN KEY([cod_venta])
REFERENCES [dbo].[Venta] ([cod_venta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[Proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Proveedor]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[Proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Proveedor]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [CK_Inventario_Cantidad] CHECK  (([Cantidad]>=(0) AND [Cantidad]<=(150)))
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [CK_Inventario_Cantidad]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [CK_Pedido_Cantidad] CHECK  (([Cantidad]>=(1) AND [Cantidad]<=(100)))
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [CK_Pedido_Cantidad]
GO
