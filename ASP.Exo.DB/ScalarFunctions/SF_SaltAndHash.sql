CREATE FUNCTION [dbo].[SF_SaltAndHash]
(
	@value NVARCHAR(32),
	@salt UNIQUEIDENTIFIER
)
RETURNS VARBINARY(32)
AS
BEGIN
	DECLARE @encrypted NVARCHAR(68);
	SET @encrypted = CONCAT(@salt,@value);
	RETURN HASHBYTES('SHA2_512', @encrypted)
END
