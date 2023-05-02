USE [DB_CONSULTORIO]
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_INSERTAR_CITAS]    Script Date: 1/5/2023 19:13:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [SCH_ADMIN].[SP_INSERTAR_CITAS]    Script Date: 4/29/2023 10:22:29 AM ******/

CREATE PROCEDURE [SCH_ADMIN].[SP_INSERTAR_CITAS]
(

@IdCliente VARCHAR(50),
@IdDoctor Int,
@IdEspecialidad int,
@fecha datetime
)
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO [SCH_ADMIN].[CITAS]

			([ID_CLIENTE],
			[ID_DOCTOR],
			[ID_ESPECIALIDAD],
			[FECHA])
VALUES(@IdCliente,@IdDoctor,@IdEspecialidad,@fecha);
SELECT MAX([ID_CITA]) FROM [SCH_ADMIN].[CITAS]
END
