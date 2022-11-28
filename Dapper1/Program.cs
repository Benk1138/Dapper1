﻿// See https://aka.ms/new-console-template for more information
using Dapper1;
using Microsoft.Extensions.Configuration;
    using MySql.Data.MySqlClient;
    using System.Data;

    var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
    string connString = config.GetConnectionString("DefaultConnection");
    IDbConnection conn = new MySqlConnection(connString);

var repo = new DapperDepartmentRepository(conn);

var depts = repo.GetAllDepartments();

foreach (var dept in depts)
{
    Console.WriteLine(dept.NAME);
}


