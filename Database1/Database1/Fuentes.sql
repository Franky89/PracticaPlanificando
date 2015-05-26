CREATE TABLE [dbo].[Fuentes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Coordenadas] NVARCHAR(50) NOT NULL, 
    [Valoracion] INT NULL, 
    [Temperatura] NCHAR(10) NOT NULL, 
    [Caudal] INT NULL
)
