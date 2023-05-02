USE [DB_CONSULTORIO]
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_EDITAR_CITAS]    Script Date: 1/5/2023 19:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [SCH_ADMIN].[SP_EDITAR_CITAS]
    (
	@id_cita INT,
    @id_cliente INT,
    @id_especialidad INT,
    @id_doctor INT,
    @fecha DATETIME
)
AS
BEGIN
    UPDATE [SCH_ADMIN].[CITAS]
    SET [ID_CLIENTE] = @id_cliente,
        [ID_ESPECIALIDAD] = @id_especialidad,
        [ID_DOCTOR] = @id_doctor,
        [FECHA] = @fecha
    WHERE
        [ID_CITA] = @id_cita
END
