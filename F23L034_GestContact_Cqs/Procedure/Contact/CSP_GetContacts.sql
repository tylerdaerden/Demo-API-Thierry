CREATE PROCEDURE [dbo].[CSP_GetContacts]
	@UtilisateurId int
AS
BEGIN
	SELECT	[Id], [Nom], [Prenom], [Email], [Anniversaire], [Tel]
	FROM	[Contact]
	WHERE	[UtilisateurId] = @UtilisateurId;
	RETURN 0
END
