USE [sakila];
GO

/*Object: Trigger[dbo].[insert_film] Script Date: 3/30/2020 9:38:16 AM*/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[insert_film] ON [dbo].[film]
AFTER INSERT
AS

INSERT INTO film_text(film_id, title, [description])
values ('1', 'sometime', 'someDescription')
GO

BEGIN TRAN
UPDATE film
SET original_language_id= '1'
WHERE language_id =1
COMMIT TRAN