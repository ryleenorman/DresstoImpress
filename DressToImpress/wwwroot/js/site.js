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

async function GetWeatherByType(WeatherID) {
    const response = await fetch(`https://localhost:7044/api/WeatherType/${WeatherID}`);
    const data = await response.json();
    document.getElementById('weatherType').innerHTML = data[0].weatherType;
    document.getElementById('weatherType').style.visibility = 'visible';
}

 