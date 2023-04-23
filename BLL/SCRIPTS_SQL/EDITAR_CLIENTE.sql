USE [DB_CONSULTORIO]
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_EDITAR_CLIENTE]    Script Date: 22/4/2023 22:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [SCH_ADMIN].[SP_EDITAR_CLIENTE]
   (
    @id_cliente INT,
    @nombre_cliente VARCHAR(50),
    @apellido1_cliente VARCHAR(50),
    @apellido2_cliente VARCHAR(50),
    @direccion_cliente VARCHAR(100),
    @telefono_cliente VARCHAR(100),
    @correo_cliente VARCHAR(100)
	)
AS
BEGIN
    --SET NOCOUNT ON;
    UPDATE [SCH_ADMIN].[CLIENTES]
    SET [NOMBRE_CLIENTE] = @nombre_cliente,
        [APELLIDO1_CLIENTE] = @apellido1_cliente,
        [APELLIDO2_CLIENTE] = @apellido2_cliente,
        [DIRECCION_CLIENTE] = @direccion_cliente,
        [TELEFONO_CLIENTE] = @telefono_cliente,
        [CORREO_CLIENTE] = @correo_cliente
    WHERE [ID_CLIENTE] = @id_cliente;
END
