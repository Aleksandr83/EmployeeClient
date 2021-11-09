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
		a.last_name + ' ' + LEFT(first_name,1) + '.' + LEFT(second_name,1) + '.' AS fio,
		b.name AS status,
		c.name AS dep,
		d.name AS post,
		date_employ  AS date_employ,
		date_uneploy AS date_uneploy
	FROM dbo.persons a
	  INNER JOIN dbo.status b ON a.status  = b.id
	  INNER JOIN dbo.deps   c ON a.id_dep  = c.id
	  INNER JOIN dbo.posts  d ON a.id_post = d.id	
	 /* сортировку, фильтры, защиту sql injection добавлю позже */
RETURN  
GO  

