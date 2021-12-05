CREATE DATABASE People;
 USE People

CREATE TABLE [dbo].[MOCK_DATA] (
    [id]         INT           NOT NULL,
    [first_name] NVARCHAR (50) NULL,
    [last_name]  NVARCHAR (50) NULL,
    [email]      NVARCHAR (50) NULL,
    [username]   NVARCHAR (50) NULL,
    [password]   NVARCHAR (50) NULL,
    [country]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_MOCK_DATA] PRIMARY KEY CLUSTERED ([id] ASC)
);

