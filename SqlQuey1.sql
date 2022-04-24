CREATE DATABASE FIFA;
USE FIFA; --it specifies to use this database

CREATE TABLE FootBallLeague
(
MatchID INTEGER NOT NULL PRIMARY KEY,
TeamName1 VARCHAR(30) NOT NULL,
TeamName2 VARCHAR(30) NOT NULL,
MatchStatus VARCHAR(30) NOT NULL,
WinningTeam VARCHAR(30),
Points INTEGER NOT NULL
);

INSERT INTO FootBallLeague(MatchID,TeamName1,TeamName2,MatchStatus,WinningTeam,Points)
VALUES(1001,'Italy','France','Win','France',4),
(1002,'Brazil','Portugal','Draw','NULL',2),
(1003,'England','Japan','Win','England',4),
(1004,'USA','Russia','Win','Russia',4),
(1005,'Portugal','Italy','Draw','NULL',2),
(1006,'Brazil','France','Win','Brazil',4),
(1007,'England','Russia','Win','Russia',4),
(1008,'Japan','USA','Draw','NULL',2),
(1009,'India','China','Win','India',4),
(1010,'India','Pakistan','Win','India',4);

SELECT * FROM FootBallLeague;

 --Creating stored procedure
CREATE PROCEDURE spGetFootBallLeague  
AS
BEGIN
SELECT * FROM FootBallLeague
END

--To execute sp
EXECUTE spGetFootBallLeague ;

--a)Retrieve all the winning TeamNames.
SELECT WinningTeam
FROM FootBallLeague
WHERE MatchStatus='Win';

--b)Create View Match_View to display the teams whose status is Draw
CREATE VIEW Match_View
AS
SELECT TeamName1,TeamName2
FROM FootBallLeague
WHERE MatchStatus='Draw';

--c)Retrieve the details of all matches in which Japan played
SELECT * FROM FootBallLeague
WHERE TeamName1='Japan' OR TeamName2='Japan';

