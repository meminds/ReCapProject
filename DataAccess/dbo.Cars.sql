CREATE TABLE [dbo].[Cars] (
    [CarId]       INT          NOT NULL,
    [BrandId]     INT          NULL,
    [ColorId]     INT          NULL,
    [ModelYear]   SMALLINT     NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] CHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC)
);

GO
CREATE NONCLUSTERED INDEX [BrandsCars]
    ON [dbo].[Cars]([BrandId] ASC);

GO
CREATE NONCLUSTERED INDEX [BrandId]
    ON [dbo].[Cars]([BrandId] ASC);

GO
CREATE NONCLUSTERED INDEX [ColorId]
    ON [dbo].[Cars]([ColorId] ASC);

GO
CREATE NONCLUSTERED INDEX [ColorsCars]
    ON [dbo].[Cars]([ColorId] ASC);

