
CREATE TYPE dbo.tbl_transacciones_alignet_type AS TABLE
(
    [NUMERO_PEDIDO] [varchar](15) NULL,
	[ESTADO_TRANSACCION] [varchar](20) NULL,
	[COMERCIO] [varchar](50) NULL,
	[PAN] [varchar](50) NULL,
	[MONTO] [varchar](12) NULL,
	[FECHA_PEDIDO] [varchar](20) NULL,
	[VCI] [varchar](5) NULL,
	[TITULAR] [varchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
	[CODIGO_AUTORIZACION] [varchar](20) NULL,
	[MARCA_TARJETA] [varchar](20) NULL,
	[TIPO_TARJETA] [varchar](20) NULL,
	[BANCO] [varchar](20) NULL,
	[CODIGO_UNICO] [varchar](50) NULL,
	[ORDEN_COMPRA] [varchar](50) NULL,
	[ASL] [varchar](50) NULL,
	[CANAL] [varchar](50) NULL
)

