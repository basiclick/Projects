﻿CREATE DATABASE GAMES

GO

USE GAMES

GO 

CREATE TABLE Games

(Id INT NOT NULL PRIMARY KEY IDENTITY,

GameName NVARCHAR(200) NOT NULL,

ReleaseDate DateTime NOT NULL,

Title NVARCHAR(200) NOT NULL,

Description NVARCHAR(200) NOT NULL,

Text nText NOT NULL );