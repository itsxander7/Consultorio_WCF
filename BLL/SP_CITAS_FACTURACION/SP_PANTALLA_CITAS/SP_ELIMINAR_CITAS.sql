USE [DB_CONSULTORIO]
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_ELIMINAR_CITAS]    Script Date: 1/5/2023 19:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Stored procedure para eliminar un usuario existente
CREATE PROCEDURE [SCH_ADMIN].[SP_ELIMINAR_CITAS]
    (
	@ID_CITA INT
)
AS
BEGIN
    DELETE FROM [SCH_ADMIN].[CITAS]
    WHERE [ID_CITA] = @ID_CITA
END
