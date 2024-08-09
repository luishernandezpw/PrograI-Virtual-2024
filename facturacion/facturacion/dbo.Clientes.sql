CREATE TABLE [dbo].[Clientes] (
    [idCliente] INT        IDENTITY (1, 1) NOT NULL,
    [codigo]    CHAR (10)  NOT NULL,
    [nombre]    CHAR (100) NOT NULL,
    [direccion] CHAR (150) NOT NULL,
    [telefono]  CHAR (10)  NULL,
    [dui]       CHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([idCliente] ASC)
);

