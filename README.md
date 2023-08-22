# CRUD
## Description
This REST API developed with .NET allows you to perform CRUD (create,read, update, delete) operations on specific resources. It is created with the Entity Framework Code First approach so you don't have to redesign the database.

## Endpoints and Methods
The available endpoints are described below along with the HTTP methods that can be used:

### Get all users
#### Method: GET
- URL: /api/User/List
- Description: Gets all the users that exist in the database.
### Get a user by their ID
#### Method: GET
- URL: /api/User/Get/{id}
- Description: Obtains a specific User according to his ID.
### Register a new user
#### Method: POST
- URL: /api/User/Save
- Description: Create a new User. The data must be provided in the request body in JSON format.
### Modify an existing user
#### Method: PUT
- URL: /api/User/{Edit
- Description: Update an existing user based on their ID. The new data must be provided in the request body in JSON format.
### Unsubscribe a user
#### Method: DELETE
- URL: /api/User/Delete/{id}
- Description: Delete an existing User according to his ID.
## Installation and configuration
1. Clone this repository to your local machine.
```
git clone https://github.com/ramiroquin/PruebaEvoltis.git
```
3. Open the project with Visual Studio.
4. Make sure you have .NET, MySql and all necessary dependencies installed.
5. Open the SQL connection file (appsettings.json).
```
    "ConnectionStrings": {
     "SqlConnection": "Change_Here_Your_SQL_Connection_String"
}
```
5. Change the connection string to point to your local database.
6. Press the "Start debugging" (F5) or "Start without debugging" (Ctrl+F5) button to run the application.
