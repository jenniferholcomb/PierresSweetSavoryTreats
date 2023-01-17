
# Pierre's Sweet and Savory Bakery

#### By Jennifer Holcomb

#### An application to market Pierre's sweet and savory treats. (fictitious)

## Technologies Used

* C#
* .NET 6
* ASP.NET Core 6 MVC
* EF Core 6
* SQL
* mySQL
* LINQ
* Dotnet-ef
* ASP.NET Core Identity

## Description

This application lists all treats available at Pierre's Bakery, as well as flavor profiles. User can search by treats, or can search by flavor.  Treats and flavor are a many-to-many relationship; treats can be tagged with a flavor, and flavor can be tagged with a treat.  There is CRUD capability for both treat and flavor classes. There is also user authentication. User can create an account, then has access to create, edit, and delete both flavor and treats. All visitors to the site have read access.

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to program directory (PierresBakery)
  * add .gitignore file to this directory
    * add bin, obj, appsettings.json to file
    * push this file to GitHub first
* Navigate to production directory (PierresBakery)
  * Create a file appsettings.json
    * Add the following to appsettings.json,
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=pierres_bakery;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    * In appsettings.json, replace '[YOUR-USERNAME-HERE]' with your SQL username, and '[YOUR-PASSWORD-HERE]' with your SQL password
* In production directory, on command line run ```dotnet restore```
* To load application database with migrations, in production directory,
  run ```dotnet ef database update```
* In production directory, run ```dotnet watch run``` in command line to start project in development mode in watcher.
* Open brower to https://localhost:5001


## Known Bugs

* No known bugs. 
* If any issues are discovered, please email jenniferlholcomb@gmail.com


## License

MIT License

Copyright (c) 2023 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
