CREATE TABLE [dbo].[Zaposlenik]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
    [Ime] nvarchar(30) NOT NULL,
    [Prezime] nvarchar(30) NOT NULL,
    [Placa] MONEY NOT NULL,
    [Voditelj] INT foreign key references [dbo].[Zaposlenik]([Id])
)
