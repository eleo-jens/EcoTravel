﻿--CREATE PROCEDURE [dbo].[SP_Logements_2_Dates]
--	@date1 DATE,
--	@date2 DATE
--AS
--	SELECT [Logement].* FROM [Logement]
--	JOIN  [VueDisponibilite] ON [VueDisponibilite].[idLogement] = [Logement].[idLogement]
--	WHERE [VuedateDebutDispo] >= @date1 AND [VuedateFinDispo] <= @date2
