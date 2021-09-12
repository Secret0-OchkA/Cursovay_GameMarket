IF EXISTS (SELECT * FROM sysobjects WHERE name = 'ExistUser' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].ExistUser
GO

CREATE PROCEDURE [dbo].ExistUser
(
	@loginIn varchar(100),
	@passIn varchar(16)
)
AS
	SET NOCOUNT ON;
SELECT        COUNT(*) AS Exist
FROM            users
WHERE        (login = @loginIn) AND (password = @passIn)
GO