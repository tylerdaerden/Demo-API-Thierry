CREATE PROCEDURE [dbo].[CSP_AddContact]
	@Nom NVARCHAR(50), 
    @Prenom NVARCHAR(50), 
    @Email NVARCHAR(50), 
    @Anniversaire DATE, 
    @Tel NVARCHAR(20), 
    @UtilisateurId INT
AS
BEGIN
	INSERT INTO [Contact] ([Nom], [Prenom], [Email], [Anniversaire], [Tel], [UtilisateurId])
    VALUES (@Nom, @Prenom, @Email, @Anniversaire, @Tel, @UtilisateurId)
    RETURN 0
END
