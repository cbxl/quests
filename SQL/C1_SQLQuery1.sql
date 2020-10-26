/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
SELECT
	[name] AS "Nom du candidat",
    [age] AS "Age du candidat",
    [is_male] AS "Est un homme",
    [height] AS "Taille du candidat",
    [years_studied] AS "Nombre d'années d'étude",
    [is_working] AS "En poste"
FROM [SQL_Quest1].[dbo].[Quest1BDD.flat]
WHERE
       (
          age < 25 AND
          years_studied < 3 AND
          is_working = 'True'
       );