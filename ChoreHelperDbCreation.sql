IF db_id('ChoreHelper') IS NULL
	CREATE DATABASE ChoreHelper;

CREATE TABLE ChoreHelper.dbo.Chore (
	Chore varchar(255),
	Id int IDENTITY(1,1) PRIMARY KEY
	);

CREATE TABLE ChoreHelper.dbo.ChoreEvent(
	Id int IDENTITY(1,1) PRIMARY KEY,
	ChoreId int NOT NULL,
	EventDate DateTime,
	FOREIGN KEY (ChoreId) REFERENCES ChoreHelper.dbo.Chore(Id)
	);
