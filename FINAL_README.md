# Dress To Impress Outfit Generating Website

![Image Alt text](/DressToImpress/DresstoImpressLogo.jpg "Dress to Impress")

## Creators

### Rylee Norman
### Emily Surface
### Emily Mago


## Introduction (Description)

The goal of this project is to create a webpage that generates an outfit for the user based on current weather data. During my creative process, I noticed my roommate complaining that the weather had ruined his shoes, which sparked my idea for a website to prevent just that. Not only did I want this website to save everyone’s nice shoes, I wanted to tie in an aspect to save myself time in the mornings, which is selecting an outfit. I spend a lot of my time on Pinterest looking for inspiration, so not only would this website be efficient for preparing for the weather, but also give a random generation of an outfit so that each day can be something new, without having to brainstorm or search for yourself. Our ultimate goal is for the user to obtain a randomly generated outfit (based on weather conditions and occasion), and be able to purchase the outfit directly from our website. We hope to also integrate third-parties or businesses as User Generated Content to post and sell clothing on our website for our profit.The concept is there along with the website design and color scheme, but could use a few functional details.


## Webpage Composition


### Index (Home Page)

The first page you land on when launching the website is the Index or Home Page. This page is composed of two Hero Images with buttons that take you to the two other pages and also descriptions of these pages. It is meant to be the most aesthetically pleasing page, as it is the first thing you see. While building this page I wanted to showcase more of a “brand image” or a certain type of branding to match with the name of the website. I used a good bit of custom CSS throughout the pages for different things, such as buttons or dividers to give a cleaner look. I also used the “Lux” theme from Bootswatch, as I also thought it was fitting for the brand image. Some of the code inspiration and research from this part of the website comes from W3Schools, such as the hero images and the dividers. After going to any of the other pages, you can navigate back to the home page by clicking the “Home” button in the navigation bar.


### Outfit Results

This page is linked to the first hero image button on the Home Page. This is where the user will go to get their generated outfit for the day. The page is made up of a two column layout from W3Schools. Currently, there is an anchored button that will take the user to the Weather Channel’s website to check their weather for that area. The next section there is a button that will randomly generate an outfit every time the user clicks the button. The function used is JavaScript that puts uploaded images from the developer into an array that chooses one at random each time. This was a personal idea that ChatGPT was able to clean up and help make my code functional. (Includes User Occupation API and Clothing Season API)


### Look Book (Editorial)

This page is linked to the second hero image button on the Home Page. This is where the user can go to get season inspiration, more about the “brand image” and favorite picks from the creator. I wanted this page to give more personality to the brand and almost give the feel of a blog but a more refined and sophisticated version. It is composed of a four column layout also from W3Schools, for each of the four seasons of the year. At the bottom of the page there is a table with more details about inspiration for the outfit picks from the creator, which includes individuals known for their wardrobe picks, what their occupation was and what time period they are from. The table I used is one from the Bootstrap section on W3Schools. I also used a lot of my header tags throughout this page such as &lt;h1> and &lt;h2>. (Includes Price API)


### Privacy Policy

This will be one of our non-dynamic pages. The privacy policy will be the fourth page for our website and will include important topics for our customers to be aware of. These topics usually include use of cookies, use of customer location, customer data collection (including payment information), and how we disclose personal information. This will be a relatively simple and “boring” page, but important nonetheless to be transparent with data for customers.


### All Clothing (Inventory)

This page will act as a reference page for all clothing on our website and a place for brands or companies to input their own items. This page will be implementing User Generated Content, but instead of customers or normal people, this will be someone working for a specific brand as a partner to our website. UGC allows us (Dress to Impress) to not have to find content on our own, but also provide a source of income. Brands will be able to upload pictures and prices of their products after (hopefully) entering specific log-in information to prevent SQL injection or malicious intent from a customer or someone visiting our site. (Includes Outfit Details API)


### Weather

This page is used for the user to research weather based data on our website. The Weather Page is composed of three hero images each with a button. The first two which take API information and display the results after user input, and the last which houses the link to the weather forecast. (Includes Get Weather By Type API and Temperature API)


### Listings

This page shows each and every item on our website that is available. This is where you can find prices, sizing, and other information. For future development, this should be where users can also add an item to their cart.


### Photo Upload

This page serves as our User Generated Content. This is where brands or third parties can upload their items to be sold on our website, which we will take part of the profits.


## Deployment Guide


### Finding Information on GitHub

All information needed to recreate this site can be found on the “DresstoImpress” Repository on GitHub. This includes prototype research, documentation at each implementation stage, and future ideas.


### Integrating Database

To recreate and obtain data/information to use “DresstoImpress” APIs, you will need to create our database. Each of these files are also housed in our repository on GitHub. First, create the database and title it “FashionWeatherDB”. Next, you can begin creating tables, inserting the same data we currently use, and creating stored procedures, using the files saved in our repository with the title beginning with “SQL”. Each of these files should have enough information to have an exact clone of our database including stored procedures.


### Clone GitHub Repository to Open in Visual Studio

To obtain the code to create this website, you will need to clone the “DresstoImpress” repository on GitHub. This can be easily done through a browser, but the GitHub desktop app is recommended. Once the repository is cloned and the database is created, you should have all the code and information necessary to have your website up and running like ours.


### Avoidance and Recommendations

Some pitfalls you may encounter along the way are configuration issues, which is what we as a team struggled with throughout the integration process over multiple VMs. The best reference to use for these issues are the “Program.cs” files and the “appsettings.json” which should currently be up to date. Note, if you are working on a virtual machine or your own computer, your data source will be different than ours mentioned in the code (“lab8L4JUY” make sure to alter this.) Another source of troubleshooting to understand our code is another example repository by our Professor, Joshua Meadows. It is linked in the Citations section below. 


### Developer Documentation

Our website was developed as a part of the MIST 353 (Advanced Technology) class at West Virginia University with Dr.  . The code used to include javascript, html, css, and sql.  The HTML and CSS coding was taken and used from W3 schools and bootstrap to develop the frontend of the code.  Our database that is used for the website is encapsulated inside of a SQL server and is used through stored procedures.  Additionally javascript is used to be able to run our generative outfit results page and integrate our APIs into the system. The code that was developed both inside Visual Studio inside of a virtual machine and through SQL server to be able to build and utilize listings inside the database. 


## API Documentation


### ClothingSeasonService (Rylee Norman)


#### What It Does

This API takes an input of ClothingID and returns the Season of the piece of clothing. This is helpful because our outfits are generated based on the outdoor conditions for the day. You do not want to recommend someone a tank top in the winter.


#### Inputs



*  {ClothingID}: The unique identifier for each piece of clothing


#### Outputs

Returns the ClothingID and Clothing Season



* int ClothingID
* String ClothingSeason


#### How to Use

Insert a ClothingID into the input box, click the button next to the input box, and see the information requested appear, which would display the Clothing Season (Spring, Winter, etc.)


### OutfitService (Emily Mago)


#### What It Does

This API takes an input of OutfitID and returns all the details for that specific outfit. This is helpful because we have certain data in the table that will allow us to recommend different outfits for different people. For example, which outfit is for which weather conditions? Or which outfit is best for a formal occasion?


#### Inputs



*  {OutfitID}: The unique identifier for each outfit


#### Outputs

Returns the OutfitID, WeatherID, ClothingID, OutfitOccasion



* int OutfitID
* int WeatherID
* int ClothingID
* string OutfitOccasion


#### How to Use

Insert an OutfitID into the input box, click the button next to the input box, and see the information requested appear, which would display the WeatherID, ClothingID, and Outfit Occasion that corresponds to the Outfit.


### UserOccupationService (Emily Surface)


#### What It Does

This API retrieves the details of the User Occupation based of the UserID


#### Inputs



* {UserID}: The unique identifier for the user in the FashionWeather database


#### Outputs

Returns the UserID and the user occupation.



* int UserID
* string UserOccupation


#### How to Use

Insert a UserID into the input box, click the button next to the input box, and see the information requested appear, which would display the User Occupation (Doctor, Nurse, Engineer, etc).


### TemperatureService (Emily Surface)


#### What It Does

This API retrieves the temperature for the day based on the WeatherID given


#### Inputs



* {WeatherID}: The unique identifier for the Weather in the FashionWeather database


#### Outputs

Returns the WeatherID and Temperature



* int WeatherID
* string Temperature


#### How to Use

Insert a WeatherID into the input box, click the button next to the input box, and see the information requested appear, which would display the Temperature(25℃, etc).


### GetPriceService (Emily Mago)


#### What It Does

This API takes an input of ClothingID and returns the Clothing item and Price of all pieces under $20.00. This can be helpful in many ways, especially if there is a customer that is trying to find a sale or stick to a budget. This allows our website to give affordable options within our customer’s range, as we do not want to turn away anyone because of the price of an item.


#### Inputs



* {ClothingID}: Unique identifier for each piece of clothing


#### Outputs

Returns the ClothingID and Price



* int ClothingID
* money Price


#### How to Use

Insert a ClothingID into the input box, click the button next to the input box, and see the information requested appear, which would display the Clothing Price ($19.99, etc).


### WeatherTypeService (Rylee Norman)


#### What it Does

This API takes an input of WeatherID and returns the Weather type (ex. Rainy, Snowy, etc.). This is another important service that will help us give the best recommendations to our customers for the day. This will allow us to include things like a raincoat, boots, or gloves that you may forget in the mornings while getting ready for your day.


#### Inputs



* {WeatherID}: Unique identifier for the Weather in the FashionWeather database


#### Outputs

Returns the WeatherID and WeatherType



* tnt WeatherID
* string WeatherType


#### How to Use

Insert a WeatherID into the input box, click the button next to the input box, and see the information requested appear, which would display the Weather Type (Rainy, Sunny, etc).


## Future Enhancements

Some of the enhancements that we would like to incorporate in the future is a more complex database to integrate the different outfit combinations for different seasons for more of a wide selection. Another advancement that needs to be made is the creation of a cart, where users can purchase directly from our site. We hope to collaborate with many different businesses to promote on our website for profit, such as selling their clothing items. Our business idea is also great to implement a subscription model in the future for “subscribers” or “members”. If we decide to incorporate a membership based model, we would love to expand our services to different things such as personal stylists for paying customers or maybe even a social media platform that will allow members to create their own outfit ideas for others to “like” or “comment” on them.


## Citations

[https://bootswatch.com/lux/](https://bootswatch.com/lux/)

​​[https://github.com/joshuatmeadows/MIST353-TravelSite](https://github.com/joshuatmeadows/MIST353-TravelSite)

[https://www.w3schools.com/bootstrap5/bootstrap_tables.php](https://www.w3schools.com/bootstrap5/bootstrap_tables.php)

[https://www.w3schools.com/css/css_website_layout.asp](https://www.w3schools.com/css/css_website_layout.asp)

[https://www.w3schools.com/html/html_div.asp](https://www.w3schools.com/html/html_div.asp)

[https://chat.openai.com/](https://chat.openai.com/)

[https://www.w3schools.com/html/html_headings.asp](https://www.w3schools.com/html/html_headings.asp)

[https://www.w3schools.com/css/css_dimension.asp](https://www.w3schools.com/css/css_dimension.asp)

[https://www.pinterest.com/](https://www.pinterest.com/)

Class Lectures and Code
