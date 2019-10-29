# Salon Management System

Salon Management systems to manage and track all of your stylist and their clients. 

## Authors


Hailey Gaylor, Haileygaylor@gmail.com

## Use
User can add recipes and cooking instructions or view their current recipes with cooking instruction by personal tags. Tags are used to categorize the recipes for user prefernce of food.

## Set-Up with MySQL Lite
- navigate to the desktop
- run $git clone https://github.com/Hgaylor0220/SalonManagementSystem.Solution.git in terminal to copy directory
- navigate to project directory 'SalonManagementSystem.Solution' and run $dotnet restore.
- Run in the terminal $dotnet run watch

## Setting up new DB
- Navigate to the SalonManagementSystem folder in the project
- In the terminal run the command $ dotnet ef migrations add NewDB. This will make file message of your new database.
- run the command $dotnet ef database update. This will add your new updated Database
- run the command $dotnet run watch To start the application 

## Specs

| Scenario | When| given that | Result |
|-|-|-|-|
| User can Add or Update a Stylist | Stylist Home page button is select | Index is attached and controller is on POST | Display active stylist or give the option to add stylist, client, edit and delete |
| User can add a client top a stylist | User selects Edit stylist or add a new client | Create paths is being direct to the lient contreoller| bring user to the Add a client page|
| user can update and delete Stylist | user clicks 'edit' or 'delete' links | all paths return corectly | deletes Stylist from database |
| user can edit client | user selects edit from client home page | All paths return correctly |  Edit the name of the client  |

## Known Bugs
No known bugs at this time. Please report all issues to the email address listed above.

## Technologies

C#, EntityFramework, .NET, MySQL Lite, VS Code, .cshtml;

## License

Open source, 2019 (MIT)