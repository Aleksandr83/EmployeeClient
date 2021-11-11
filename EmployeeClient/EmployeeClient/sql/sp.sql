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
	SELECT 
		id,
		name 
	FROM dbo.status;
RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetDepsReffer]
AS
	SET NOCOUNT OFF;
	SELECT 
		id,
		name 
	FROM dbo.deps;
RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetPostsReffer]
AS
	SET NOCOUNT OFF;
	SELECT 
		id,
		name 
	FROM dbo.posts;
RETURN  
GO  

CREATE PROCEDURE [dbo].[uspGetPersons]
AS
	SET NOCOUNT OFF;
	SELECT
		tablePersons.last_name + ' ' + LEFT(tablePersons.first_name,1) + '.' + LEFT(tablePersons.second_name,1) + '.' AS fio,
		tableStatus.name AS status,
		tableDeps.name   AS dep,
		tablePosts.name  AS post,
		date_employ		 AS date_employ,
		date_uneploy	 AS date_uneploy
	FROM dbo.persons tablePersons
	  INNER JOIN dbo.status tableStatus ON tablePersons.status  = tableStatus.id
	  INNER JOIN dbo.deps   tableDeps	ON tablePersons.id_dep  = tableDeps.id
	  INNER JOIN dbo.posts  tablePosts  ON tablePersons.id_post = tablePosts.id	
	 /* сортировку, фильтры, защиту sql injection добавлю позже */
RETURN  
GO  

