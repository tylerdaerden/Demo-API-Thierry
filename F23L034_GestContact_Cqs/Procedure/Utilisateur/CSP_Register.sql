CREATE PROCEDURE [dbo].[CSP_Register]
	@Nom NVARCHAR(50), 
    @Prenom NVARCHAR(50), 
    @Email NVARCHAR(384), 
    @Passwd NVARCHAR(20)
AS
BEGIN
	INSERT INTO [Utilisateur] ([Nom], [Prenom], [Email], [Passwd])
    VALUES (@Nom, @Prenom, @Email, dbo.CSF_HashPassword(@Passwd));
    RETURN 0;
END
