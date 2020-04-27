# GSBrevets

## Introduction :

GSBrevets est une application développée en C#, suivant le contexte GSB (Galaxy-Swiss Bourdin) imposé dans le cadre du BTS.

Le sujet est le suivant, les laboratoires GSB avaient mis en place un document Excel qui avait pour but de centraliser l'information entre différents pôles d'activités (chercheurs, commerciaux, RH). Ce document est devenu trop volumineux c'est pour quoi un prestataire du nom de 'Stein' (ma société fictive) a été mandatée afin de créer une solution alternative.

## Contraintes :

L'application se doit :

- d'être Intuitive
- d'être consultable sur des postes comprenant des versions d'OS allant de windows 7 à windows 10
- de posséder différentes interfaces qui permettront aux utilisateurs de consulter, de modifier ou de supprimer : les molécules, leurs effets, les entreprises partenaires, etc...
- de posséder un panel administrateur qui permettra uniquement à l'équipe informatique de pouvoir ajouter ou supprimer des utilisateurs

## Outils utilisés

Le projet est donc divisé en 3 parties :

- La base de données (bdd)
- Le Backend (qui récupère/altère/supprime les données contenues dans la bdd)
- Le Frontend qui afficher les données contenues de la bdd)

Afin de réaliser le tout en C# j'ai créé une solution qui se divise en 2 parties :

- BackEndGSBrevet -> qui est une bibliothèque de classe (.dll)
- FrontEndGSBrevet -> qui est une application de type WinForm (.exe)

## Le Backend :

Le Backend fut développé avec l'aide du Framework 'EntityFramework v6.4'

La bibliothèque de classes fut réalisé en mode Code First, ainsi j'ai pu créer la base de données au fur et à mesure en créant des migrations (disponible dans le code source)

Voulant créer un projet qui se rapproche le plus possible de la réalité j'ai décidé de bâtir mon Backend sur un modèle UnitOfWork croisé avec du MVC.

Les modèles ne sont donc pas accessible directement, en effet l'application fait appel à des contrôleur qui vont appeler des repository.

**Exemple** :

```c#
// retourner tous les utilisateurs
return unitOfWork.Users.GetAll();
// récupérer un utilisateur qui a pour nom 'Pierro'
User user = unitOfWork.Users.FirstOrDefault(u => u.last_name == "Pierro");
// retourner toutes les molécules qui ont 'eau' dans leur nom
return unitOfWork.Users.GetAll()Where(m => m.name == "eau");
```

Afin de faciliter l'appel des fonctions depuis le Frontend, les fonctions sont statiques ce qui donne :

**Exemple** :

```c#
// backend
    public static IEnumerable<Molecule> getAll()
    {
        return unitOfWork.Molecules.GetAll();
    }
// frontend
 using BackEndGSBrevet.Controller;
 ...
 var molecules = MoleculeController.getAll();
    foreach(var molecule in molecules)
    {
        lbl_MoleculeName += $"{molecule.name} | ";
    }
 ...
```

Etant sous forme de bibliothèque de classes, le BackEnd pourra être utilisé par le FrontEnd il suffit de l'ajouter dans les références.

## Le Frontend :

Le Frontend a pou ojectif d'afficher les données et au besoin de pouvoir les éditer ou de les supprimer.

Afin de le mettre en place plus rapidement j'ai utilisé la librairie nommé 'GunaUI' disponible sur github

Il est rare de trouver un projet C# correctement structurer, j'ai donc pris la liberté de le structurer en faisant un mixe entre un projet Laravel et un projet AngularJs.

Ainsi j'ai une architecture propre, améliorant ainsi mon efficacité :

```c#
├───bin
│   ├───Debug
│   └───Release
├───obj
│   ├───Debug
│   │   └───TempPE
│   └───Release
│       └───TempPE
├───Properties // contient les dlls
├───Resources // contient les images
├───Utils     // contient les fichiers qui permettent de changer de view
└───Views
    ├───Admin // admin form
    │   ├───Role
    │   │   ├───CreateUpdate
    │   │   └───RoleModel
    │   └───Users
    │       ├───CreateUpdate
    │       └───UserModel
    ├───Public // public form
    │   ├───Analytics
    │   ├───Companies
    │   │   ├───CompanyModel
    │   │   └───CreateUpdate
    │   ├───Contracts
    │   │   ├───ContractModel
    │   │   └───CreateUpdate
    │   ├───Molecules
    │   │   ├───CreateUpdate
    │   │   └───MoleculeModel
    │   ├───Patents
    │   │   ├───CreateUpdate
    │   │   └───PatentModel
    │   ├───Profil
    │   ├───Settings
    │   └───Utilities
    │       ├───CreateUpdate
    │       └───UtilityModel
    └───Shared // menus pouvant être utilisés par les deux forms
        ├───CreateMenu
        ├───MainMenu
        └───SettingsMenu
```

## Base de données :

Afin de pouvoir recréer la base de données sur une machine distante j'en ai exporté une partie :

```SQL
USE [BackEndGSBrevet.GSBrevetDbContext]
GO
/****** Object:  User [read]    Script Date: 27/04/2020 16:17:52 ******/
CREATE USER [read] FOR LOGIN [read] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[companies]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[companies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[city] [nvarchar](255) NULL,
	[zip_code] [nvarchar](255) NULL,
 CONSTRAINT [PK_dbo.companies] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contracts]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contracts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NOT NULL,
	[patent_id] [int] NOT NULL,
	[create_date] [datetime] NULL,
	[duration] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_dbo.contracts] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_at] [datetime2](6) NULL,
	[activity_id] [varchar](255) NULL,
	[type] [varchar](7) NULL,
	[username] [varchar](255) NULL,
	[message] [varchar](255) NULL,
	[passed_through] [varchar](255) NULL,
PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[molecules]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[molecules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[generic_name] [nvarchar](255) NULL,
	[real_name] [nvarchar](255) NULL,
	[formula] [nvarchar](255) NULL,
 CONSTRAINT [PK_dbo.molecules] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patents]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[molecule_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
	[country] [nvarchar](255) NULL,
	[number] [nvarchar](255) NULL,
	[deposit_date] [datetime] NULL,
	[duration] [int] NULL,
 CONSTRAINT [PK_dbo.patents] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [nvarchar](255) NULL,
 CONSTRAINT [PK_dbo.roles] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[last_name] [nvarchar](255) NULL,
	[first_name] [nvarchar](255) NULL,
	[birth_date] [datetime] NULL,
	[username] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
	[role_id] [int] NULL,
 CONSTRAINT [PK_dbo.users] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilities]    Script Date: 27/04/2020 16:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[molecule_id] [int] NOT NULL,
	[name] [nvarchar](255) NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_dbo.utilities] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
```

Enfin pour créer un admin on peut l'insérer de la façon suivante :

```sql
-- les deux rôles : utilisateur et administrateur
INSERT [dbo].[roles] ([id], [libelle]) VALUES (1, N'user')
INSERT [dbo].[roles] ([id], [libelle]) VALUES (2, N'admin')
--utilisateur avec comme identifiant : pduv || mot de passe : password
INSERT [dbo].[users] ([id], [last_name], [first_name], [birth_date], [username], [password], [role_id]) VALUES (1, N'Duv', N'Pierro', CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'pduv', N'$2a$11$N79ZGSy7AW2iUTOMWdmnk.2H9JNShpgL9.MmzCvslmQ80P803mG6.', 2)
```
