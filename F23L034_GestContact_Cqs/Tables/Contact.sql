CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Anniversaire] DATE NOT NULL, 
    [Tel] NVARCHAR(20) NULL, 
    [UtilisateurId] INT NOT NULL, 
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Contact_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateur]([Id]) 
)

GO

CREATE INDEX [IK_Contact_UtilisateurId] ON [dbo].[Contact] ([UtilisateurId])
