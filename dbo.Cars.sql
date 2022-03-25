CREATE TABLE [dbo].[Cars] (
    [CarId]       INT          NOT NULL,
    [BrandId]     INT          NOT NULL,
    [ColorId]     INT          NOT NULL,
    [ModelYear]   SMALLINT     NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] CHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
	CONSTRAINT [BrandId] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
	CONSTRAINT [ColorId] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);

