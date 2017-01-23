CREATE TABLE [dbo].[Sales]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EntryDate] DATE NOT NULL, 
    [StateCode] NVARCHAR(2) NOT NULL, 
    [SaleAmount] MONEY NOT NULL, 
    [TaxRate] DECIMAL(18, 2) NOT NULL, 
    [TotalAmount] DECIMAL(18, 2) NOT NULL, 
	CONSTRAINT [FK_Sales_StateCode] FOREIGN KEY ([StateCode]) REFERENCES [State]([StateCode])
)
