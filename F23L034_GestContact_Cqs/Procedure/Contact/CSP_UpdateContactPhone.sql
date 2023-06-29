CREATE PROCEDURE [dbo].[CSP_UpdateContactPhone]
    @Id INT,
    @Tel NVARCHAR(20), 
    @UtilisateurId INT
AS
BEGIN
	UPDATE  Contact
    SET     Tel = @Tel
    WHERE   [Id] = @Id
    AND     [UtilisateurId] = @UtilisateurId;
    RETURN 0
END
