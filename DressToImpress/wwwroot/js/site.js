// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.//My work

//By Emily Mago
async function getOutfitDetails(outfitId) {
    const response = await fetch(`https://localhost:7044/api/Outfit/${outfitId}`);
    const data = await response.json();
    document.getElementById('outfitOccasion').innerHTML = data[0].outfitOccasion;
    document.getElementById('outfitOccasion').style.visibility = "visible";
}

//By Emily Mago
async function getPriceDetails(clothingId) {
    const response = await fetch(`https://localhost:7044/api/Price/${clothingId}`);
    const price = await response.json();

    if (price !== null) {
        document.getElementById('price').innerHTML = price;
        document.getElementById('price').style.visibility = "visible";
    } else {
        console.error('Price not found for the specified clothing ID');
    }
}
//Rylee Norman
async function GetWeatherByType(WeatherID) {
    const response = await fetch(`https://localhost:7044/api/WeatherType/${WeatherID}`);
    const data = await response.json();
    document.getElementById('weatherType').innerHTML = data[0].weatherType;
    document.getElementById('weatherType').style.visibility = 'visible';
}
//Rylee Norman
async function GetTemperature(WeatherID) {
    const response = await fetch(`https://localhost:7044/api/Temperature/${WeatherID}`);
    const data = await response.json();
    document.getElementById('temperature').innerHTML = data[0].temperature;
    document.getElementById('temperature').style.visibility = 'visible';
}
// Emily Surface
async function GetUserOccupation(UserID) {
    const response = await fetch(`https://localhost:7044/api/Occupation/${UserID}`);
    const data = await response.json();
    document.getElementById('Occupation').innerHTML = data[0].occupation;
    document.getElementById('Occupation').style.visibility = 'visible';
}
// Emily Surface
async function GetOutfitID(OutfitID) {
    const response = await fetch(`https://localhost:7044/api/OutfitID/${OutfitID}`);
    const data = await response.json();
    document.getElementById('OutfitID').innerHTML = data[0].OutfitID;
    document.getElementById('OutfitID').style.visibility = 'visible';
}


 