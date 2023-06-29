CREATE PROCEDURE [dbo].[CSP_UpdateContact]
    @Id INT,
	@Nom NVARCHAR(50), 
    @Prenom NVARCHAR(50), 
    @Email NVARCHAR(50), 
    @Anniversaire DATE, 
    @Tel NVARCHAR(20), 
    @UtilisateurId INT
AS
BEGIN
	UPDATE  Contact
    SET     Nom = @Nom,
            Prenom = @Prenom,
            Email = @Email,
            Anniversaire = @Anniversaire,
            Tel = @Tel
    WHERE   [Id] = @Id
    AND     [UtilisateurId] = @UtilisateurId;
    RETURN 0
END
