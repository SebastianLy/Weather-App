# Weather App

## Technologies
* **C# 8.0**,
* **.NET 4.7.2 (WinForms, LINQ)**,
* **Newtonsoft**,
* **Entity Framework**.

## Before launch
You need to create databases for store users and weather forecasts. You can use already prepared script (files: **CreateUsersDB** and **CreateWeathersDB**).
You can populate tables in this databases on your own in application or execute prepared script (files: **CreateAndFillTableUsers** and **CreateAndFillTableWeathers**).<br>
If you have databases, now you can change `connectionStrings in App.config`. After it you can use application.
If you choose script, there is two accounts in database: administrator (Login: Sebastian, Password: Lary), user (Login: Adam, Password: user123).
If you want to create administrator account, you have to create user account and give him Role *Admin*.

## Description
When you start application you will see window to login. If you don't have account you can sign up by pressing button in right-down corner of login window.
When you log in you will see displayed records of weather forecast. In left-top corner you can search forecast by date. If you are logged in as administrator, 
you will see button *Refresh*, which adds new record to database by using [Open Weather Map API](https://rapidapi.com/community/api/open-weather-map).
