USE [FashionWeatherDB]
GO

CREATE PROCEDURE [dbo].[GetWeatherByType]
	@WeatherID int
AS
BEGIN
	SELECT WeatherID, WeatherType
	From Weather
	Where WeatherID=@WeatherID;
END
GO
/*
EXECUTE GetWeatherByType @WeatherID=1
*/

