CREATE TABLE [dbo].[MessagingTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DisplayName] NVARCHAR(20) NOT NULL, 
    [Location] NVARCHAR(50) NULL, 
    [Message] NVARCHAR(200) NOT NULL, 
    [Visible] CHAR(4) NOT NULL
)
