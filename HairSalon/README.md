# Hair Salon

### By Nick Hennessy

## Technologies Used

* C#
* .NET 5.0
* ASP.NET Core MVC
* HTML 
* Bootstrap
* MySQL Workbench
* Entity Framework

## Description
This is an MVC web application for managing client and stylist information at a hair salon.

## Setup and Installation
* Clone this repository and open in your favorite text editor
* Navigate to HairSalon.Solution/HairSalon
* Create the file HairSalon/appsettings.json and add the following code:
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nick_hennessy;uid=root;pwd=[your password];"
  }
}
* Replace [your password] with your mysql password
* In MySQL Workbench go to administration > management and select Data Import/Restore
* Select Import from Self-Contained File
* Select nick_hennessy.sql, contained in this directory and then click start import
* In the terminal, run the commands dotnet build, then dotnet run
## Known Bugs
none
## License
MIT LICENSE
Copyright (c) 2021 Nick Hennessy

## Contact Information
njhnny@gmail.com