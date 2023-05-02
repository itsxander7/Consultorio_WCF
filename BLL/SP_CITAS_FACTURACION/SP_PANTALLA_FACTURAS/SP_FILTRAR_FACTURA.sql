USE [DB_CONSULTORIO]
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_FILTRAR_FACTURA]    Script Date: 1/5/2023 19:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_FILTRAR_FACTURA]    Script Date: 4/29/2023 10:22:29 AM ******/

CREATE PROCEDURE [SCH_ADMIN].[SP_FILTRAR_FACTURA]
(
    @id_Detalle_Factura INT
)
AS
BEGIN
    SELECT 
           DF.[ID_FACTURA] AS 'NUMERO FACTURA',
		   CONCAT(C.NOMBRE_CLIENTE,' ',C.APELLIDO1_CLIENTE,' ',C.APELLIDO2_CLIENTE) AS CLIENTE,
		   C.ID_CLIENTE AS 'CEDULA',
           S.DETALLE_SERVICIO AS 'DETALLE',
		   E.NOMBRE_ESPECIALIDAD AS 'ESPECIALIDAD',
		   S.COSTO_SERVICIO AS 'COSTO ESPECIALIDAD',
		   MP.NOMBRE_METODO_PAGO AS 'METODO DE PAGO',
           F.[TOTAL_NETO] AS 'TOTAL'
    FROM [SCH_ADMIN].[DETALLE_FACTURA] AS DF
    INNER JOIN [SCH_ADMIN].[FACTURAS] AS F ON DF.[ID_FACTURA] = F.[ID_FACTURA]
	INNER JOIN [SCH_ADMIN].[SERVICIOS] AS S ON DF.ID_SERVICIO=S.ID_SERVICIO
	INNER JOIN [SCH_ADMIN].[ESPECIALIDADES] AS E ON S.ID_ESPECIALIDAD=E.ID_ESPECIALIDAD
	INNER JOIN [SCH_ADMIN].[METODO_PAGO] AS MP ON F.ID_METODO_PAGO=MP.ID_METODO_PAGO
	INNER JOIN [SCH_ADMIN].[CLIENTES] AS C ON F.ID_CLIENTE=C.ID_CLIENTE
	WHERE DF.[ID_FACTURA] = @id_Detalle_Factura
END
