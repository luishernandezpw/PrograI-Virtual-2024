CREATE TABLE [dbo].[Productos] (
    [idProducto]   INT             IDENTITY (1, 1) NOT NULL,
    [codigo]       CHAR (10)       NOT NULL,
    [nombre]       CHAR (100)      NOT NULL,
    [marca]        CHAR (65)       NOT NULL,
    [presentacion] CHAR (75)       NULL,
    [precio]       DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([idProducto] ASC)
);

