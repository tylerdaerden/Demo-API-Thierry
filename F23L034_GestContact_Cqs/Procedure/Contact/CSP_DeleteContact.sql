CREATE PROCEDURE [dbo].[CSP_DeleteContact]
	@Id int,
	@UtilisateurId int
AS
BEGIN
	IF @Id < 0
	BEGIN 
		RAISERROR ('Invalid Id', 16, 1)
		RETURN 1;
	END

	IF @UtilisateurId < 0
	BEGIN 
		RAISERROR ('Invalid UtilisateurId', 16, 1)
		RETURN 2;
	END

	DELETE 
	FROM	[Contact]
	WHERE	[Id] = @Id
	AND		[UtilisateurId] = @UtilisateurId;
	RETURN 0;
END