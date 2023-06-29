CREATE PROCEDURE [dbo].[CSP_Login]
	@Email NVARCHAR(384), 
    @Passwd NVARCHAR(20)
AS
BEGIN
	SELECT	[Id], [Nom], [Prenom], [Email]
	FROM	Utilisateur
	WHERE	[Email] = @Email 
	AND		[Passwd] = dbo.CSF_HashPassword(@Passwd);
	RETURN 0
END