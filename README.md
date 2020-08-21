<p align="center">
  <a href="" rel="noopener">
 <img width=200px height=200px src="./ParkService/park.jpeg" alt="Project logo"></a>
</p>

<h3 align="center">Park Service Registrar</h3>

<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![GitHub Issues](https://img.shields.io/github/issues/Sudolphus/ParkService.Solution.svg)](https://github.com/Sudolphus/ParkService.Solution/issues)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr/Sudolphus/ParkService.Solution.svg)](https://github.com/Sudolphus/ParkService.Solution/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

<p align="center"> An api design to service a park directory.
    <br> 
</p>

## 📝 Table of Contents

- [About](#about)
- [Getting Started](#getting_started)
- [Usage](#usage)
- [Built Using](#built_using)
- [TODO](../TODO.md)
- [Contributing](../CONTRIBUTING.md)
- [Authors](#authors)
- [Acknowledgments](#acknowledgement)

## 🧐 About <a name = "about"></a>

This project is designed to serve as a backend api that returns data from a MySQL database about various parks, and supports full CRUD functionality.

## 🏁 Getting Started <a name = "getting_started"></a>

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See [deployment](#deployment) for notes on how to deploy the project on a live system.

### Prerequisites

1. MySQL Server [Mac](https://dev.mysql.com/downloads/file/?id=484914)/[Windows](https://dev.mysql.com/downloads/file/?id=484919)
2. [.NET framework](https://dotnet.microsoft.com/download/dotnet-core/2.2)
3. An app that can send API Request, such as [Postman](https://www.postman.com/downloads/)
4. A terminal, such as Powershell or Git Bash
5. A MySQL manager, such as MySQL Workbench (optional)
6. A code editor, such as VS Code or Atom (optional)

### Installing

1. To start, you'll need to acquire the repo, by either clicking the "Download" button or running `git clone https://github.com/Sudolphus/ParkService.Solution`
2. You'll also need MySql Server and .NET framework installed (linked above)
3. Once .NET is installed, navigate into the ParkService directory in your terminal of choice and acquire the necessary packages with `dotnet restore`
4. Install the database with `dotnet ef database update`. For this step to work, you'll need to update the {Password} in appsettings.json with your MySql Password
5. You can then build the project with `dotnet build`, or run the project directly with `dotnet run`
6. Once the project is running, you can send api requests using Postman or other requester (see below)

## 🎈 Usage <a name="usage"></a>

Once the program is running, you can interact with the database by sending api requests to `localhost:5000/api`.

For example, `GET http://localhost:5000/api/parks` will return a list of all parks in the database. For a full listing of available commands, see the [Swagger document](#swagger-)

Note that the PUT, POST, and DELETE requests will require authorization, which is done via JWT tokens. For information on acquiring and using a JWT token, please see the section on [Authorization](#authorization-)

## Authorization <a name="token"></a>

This applicaton uses JWTs to authorize api calls. By default, the only calls that are legal without a token are the GETs on parks and the user register and login POSTs. To obtain a token:
1. Create an account by sending a POST request to `http://localhost:5000/api/users/register`, with a JSON body of:
   ```
   {
     "userName": "{your_name}",
     "password": "{your_password}:
   }
   ```
   In Postman, this can be done by toggling to the "Body" tab, then selecting the "raw" and "JSON" objects, and entering the above with the username and password of your choice.

2. Log in to your account by sending a POST request to `http://localhost:5000/api/users/login`, with a JSON body that matches what you sent for login. The server will respond by sending you a long string as a token.
3. Add this token to your header as authorization to gain access to the remainder of the routes. In Postman, this can be done by toggling to the "Authorization" tab, selecting Bearer token from the drop-down list, and then pasting your token string into the input box.
   
## Swagger <a name="swagger"></a>

This program uses Swagger to document the available API calls. To access the Swagger page and see a full list of calls, please view `localhost:5000/Swagger` while the project is running.


## CORS <a name="cors"></a>

This program allows for cross-site scripting, so that the api can be called from any origin. To test this, you can use a site such as [Test-Cors](https://test-cors.org) to simulate a request.

## ⛏️ Built Using <a name = "built_using"></a>

- [MySql Server](https://dev.mysql.com/) - Database
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-core/2.2) - Development Framework
  
## ✍️ Authors <a name = "authors"></a>

- [@Micheal Hansen](https://github.com/Sudolphus)

## 🎉 Acknowledgements <a name = "acknowledgement"></a>

- Thanks to [John Mccann](https://unsplash.com/@jmacca88) for the project image