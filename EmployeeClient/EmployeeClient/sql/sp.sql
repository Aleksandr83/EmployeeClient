USE SIRIUS_DB;
GO

IF OBJECT_ID('dbo.uspGetStatusReffer', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.uspGetStatusReffer;  
GO  

IF OBJECT_ID('dbo.uspGetDepsReffer', 'P')   IS NOT NULL  
    DROP PROCEDURE dbo.uspGetDepsReffer;  
GO  

IF OBJECT_ID('dbo.uspGetPostsReffer', 'P')  IS NOT NULL  
    DROP PROCEDURE dbo.uspGetPostsReffer;  
GO 

IF OBJECT_ID('dbo.uspGetPersons', 'P')  	IS NOT NULL  
    DROP PROCEDURE dbo.uspGetPersons;  
GO 

CREATE PROCEDURE [dbo].[uspGetStatusReffer]
AS
	SET NOCOUNT OFF;
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

	BEGIN TRANSACTION; 

	SELECT 
		id,
		name 
	FROM dbo.status
	WITH (UPDLOCK, HOLDLOCK);

	COMMIT TRANSACTION;

RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetDepsReffer]
AS
	SET NOCOUNT OFF;
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

	BEGIN TRANSACTION; 

	SELECT 
		id,
		name 
	FROM dbo.deps
	WITH (UPDLOCK, HOLDLOCK);

	COMMIT TRANSACTION;
RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetPostsReffer]
AS
	SET NOCOUNT OFF;
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	
	BEGIN TRANSACTION; 

	SELECT 
		id,
		name 
	FROM dbo.posts
	WITH (UPDLOCK, HOLDLOCK);

	COMMIT TRANSACTION;
	
RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetPersons]
AS
	SET NOCOUNT OFF;
	SELECT
		tablePersons.id  AS Id,
		tablePersons.last_name + ' ' + LEFT(tablePersons.first_name,1) + '.' + LEFT(tablePersons.second_name,1) + '.' AS fio,
		tableStatus.name AS status,
		tableDeps.name   AS departament,
		tablePosts.name  AS post,
		CONVERT(NVARCHAR,date_employ, 104) AS dateEmploy,
		CONVERT(NVARCHAR,date_uneploy,104) AS dateUneploy
	FROM dbo.persons tablePersons
	  LEFT OUTER JOIN dbo.status tableStatus ON tablePersons.status  = tableStatus.id
	  LEFT OUTER JOIN dbo.deps   tableDeps	 ON tablePersons.id_dep  = tableDeps.id
	  LEFT OUTER JOIN dbo.posts  tablePosts  ON tablePersons.id_post = tablePosts.id	
	 /* сортировку, фильтры, защиту sql injection добавлю позже */
RETURN  
GO  

