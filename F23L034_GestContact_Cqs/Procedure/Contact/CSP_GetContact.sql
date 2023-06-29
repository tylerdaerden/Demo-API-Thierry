CREATE PROCEDURE [dbo].[CSP_GetContact]
	@Id int,
	@UtilisateurId int
AS
	SELECT	[Id], [Nom], [Prenom], [Email], [Anniversaire], [Tel]
	FROM	[Contact]
	WHERE	[UtilisateurId] = @UtilisateurId
	AND		[Id] = @Id;
	RETURN 0
RETURN 0
