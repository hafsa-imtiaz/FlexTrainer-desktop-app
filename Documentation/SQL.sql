CREATE DATABASE FlexTrainer;
use FlexTrainer
--1
CREATE TABLE Users (--User Table
    UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, --generated khudse
    URole VARCHAR(50) NOT NULL,
	FName VARCHAR(50) NOT NULL,
    LName VARCHAR(50) NOT NULL,
	Email VARCHAR(100) UNIQUE NOT NULL,
	UPassword VARCHAR(50) NOT NULL,
    DoB DATE,
    Gender VARCHAR(10),
    PhoneNo VARCHAR(20),
    UAddress VARCHAR(255),

	JoinDate DATE --generated khudse
);

--2
CREATE TABLE GymOwner (	--Gym Owner Table
    OwnerID INT PRIMARY KEY NOT NULL,
    License VARCHAR(100) NOT NULL,
    FOREIGN KEY (OwnerID) REFERENCES Users(UserID) ON DELETE CASCADE
);

--3
CREATE TABLE Gym (	--Gym
    GymID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    GymName VARCHAR(100),
    PhoneNo VARCHAR(20),
    Address VARCHAR(255),
    OwnerID INT NOT NULL,
    FOREIGN KEY (OwnerID) REFERENCES GymOwner(OwnerID) ON DELETE CASCADE
);

--4
CREATE TABLE WorkoutPlan (	--WorkOut Plan
    WPlanID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    PlanName VARCHAR(100),
    Description VARCHAR(255),
    Share_Status VARCHAR(20),
    Goal VARCHAR(100),
    Difficulty VARCHAR(50),
    CreatedDate DATE,
    CreatorID INT,
    FOREIGN KEY (CreatorID) REFERENCES Users(UserID) ON DELETE CASCADE
);

--5
CREATE TABLE DietPlan (	--Diet Plan
    DPlanID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    PlanName VARCHAR(100),
    Type VARCHAR(50),
    Goal VARCHAR(100),
    Description VARCHAR(255),
	calorie_intake INT,
    CreationDate DATE,
    CreatorID INT,
    Share_Status VARCHAR(20),
    FOREIGN KEY (CreatorID) REFERENCES Users(UserID) ON DELETE CASCADE
);


--6
CREATE TABLE Gym_Membership (	--types of memberships in your gym
    GymID INT,
    MembershipType VARCHAR(50),
    Payment DECIMAL(10, 2),
    PRIMARY KEY (GymID, MembershipType),
    FOREIGN KEY (GymID) REFERENCES Gym(GymID) ON DELETE CASCADE
);

--7
CREATE TABLE Trainer (	--trainer table
    TrainerID INT PRIMARY KEY,
    Years INT,
    FOREIGN KEY (TrainerID) REFERENCES Users(UserID) ON DELETE CASCADE
);

--8
-- set dietplan workout plan to null khudse bbg
CREATE TABLE Member (	--member table
    MemID INT PRIMARY KEY,
    Height FLOAT,
    Goal VARCHAR(100),
	Weight FLOAT,
    DPlanID INT,
    WPlanID INT,
	GymID INT,
    MembershipType VARCHAR(50),
    Start_Date DATE,
	End_Date DATE,
	Account_Status VARCHAR(50),
	FOREIGN KEY (MemID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (DPlanID) REFERENCES DietPlan(DPlanID),
    FOREIGN KEY (WPlanID) REFERENCES WorkoutPlan(WPlanID),
    FOREIGN KEY (GymID) REFERENCES Gym(GymID)
);

--9
CREATE TABLE Trainer_Specializations (
    TrainerID INT,
    Specialization VARCHAR(255),
    PRIMARY KEY (TrainerID, Specialization),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID) ON DELETE CASCADE
);

--10
CREATE TABLE Trainer_Qualifications (
    TrainerID INT,
    Qualification VARCHAR(255),
    PRIMARY KEY (TrainerID, Qualification),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID) ON DELETE CASCADE
);

--11
CREATE TABLE Trainer_Feedback (
	backID INT IDENTITY(1,1) primary key,
    MemID INT,
    TrainerID INT,
    Rating DECIMAL(2),
    Date DATETIME,
    Comment VARCHAR(255),
    FOREIGN KEY (MemID) REFERENCES Member(MemID),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID)
);

--12
--whenever member/trainer is deleted delete yahan se too
CREATE TABLE Training_Session (
    SessID INT IDENTITY(1,1) PRIMARY KEY,
    MemID INT NOT NULL,
    TrainerID INT NOT NULL,
    Duration INT,
    Date DATE,
    Time TIME,
    Description VARCHAR(255),
	Status VARCHAR(50),	--stores whether it was scheduled, cancelled, attended, not-attended
    FOREIGN KEY (MemID) REFERENCES Member(MemID) ON DELETE CASCADE,
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID)
);

--13
CREATE TABLE Meal (
    MealID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Description VARCHAR(255),
    Fat FLOAT,
    Carbs FLOAT,
    Proteins FLOAT,
    Fibre FLOAT,
    Calories FLOAT
);

--14
CREATE TABLE Diet_Meal (	--stores har din ke meals
    DPlanID INT,
	DAY INT,
    MealID INT,
	MealType VARCHAR(50),
    PRIMARY KEY (DPlanID, Day, MealID),
    FOREIGN KEY (DPlanID) REFERENCES DietPlan(DPlanID) ON DELETE CASCADE,
    FOREIGN KEY (MealID) REFERENCES Meal(MealID)
);

--15
CREATE TABLE Meal_Allergens (
    MealID INT,
    AllergenName VARCHAR(100),
    PRIMARY KEY (MealID, AllergenName),
    FOREIGN KEY (MealID) REFERENCES Meal(MealID) ON DELETE CASCADE
);

--16
CREATE TABLE Member_Allergy (
    MemID INT,
    Allergens VARCHAR(255),
    PRIMARY KEY (MemID, Allergens),
    FOREIGN KEY (MemID) REFERENCES Member(MemID) ON DELETE CASCADE
);

--17
CREATE TABLE WorkOutSchedule (	--stores the workout days, and each days target muscle
    WPlanID INT,
    Day VARCHAR(20),
    MuscleGroup VARCHAR(100),
    PRIMARY KEY (WPlanID, Day),
    FOREIGN KEY (WPlanID) REFERENCES WorkoutPlan(WPlanID) ON DELETE CASCADE
);

--18
CREATE TABLE Machine (	--stores info regarding machines
    MachineName VARCHAR(100) PRIMARY KEY,
    Price DECIMAL(10, 2)
);

--19
CREATE TABLE Exercise (	--stores information regarding exercises 
    ExerciseName VARCHAR(255) PRIMARY KEY,
    EDescrip VARCHAR(255),
    Difficulty VARCHAR(50),
    MachineName VARCHAR(100),
	TargetMuscle VARCHAR(50),
    FOREIGN KEY (MachineName) REFERENCES Machine(MachineName) ON DELETE SET NULL
);

--20
CREATE TABLE Schedule_Exercise (	--stores the work done for each day
    PlanID INT,
    Day VARCHAR(20),
    ExerciseName VARCHAR(255),
    Sets INT,
    Reps INT,
    Rest_Interval INT,
    PRIMARY KEY (PlanID, Day, ExerciseName),
    FOREIGN KEY (PlanID, Day) REFERENCES WorkOutSchedule(WPlanID, Day) ON DELETE CASCADE,
    FOREIGN KEY (ExerciseName) REFERENCES Exercise(ExerciseName)
);

--21
--khudse delete entries upon deletion
CREATE TABLE Gym_Employment (	--gym employment
    GymID INT,
    TrainerID INT,
    endDate DATE,
    startDate DATE,
    Salary DECIMAL(10, 2),
	Status VARCHAR(50),
    PRIMARY KEY (GymID, TrainerID),
    FOREIGN KEY (GymID) REFERENCES Gym(GymID),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID)
);


--22
CREATE TABLE Gym_Equipment (	--stores information regarding different machines the gym has
    GymID INT,
    MachineName VARCHAR(100),
    MachineCount INT,
    PRIMARY KEY (GymID, MachineName),
    FOREIGN KEY (GymID) REFERENCES Gym(GymID) ON DELETE CASCADE,
    FOREIGN KEY (MachineName) REFERENCES Machine(MachineName)
);

--23
CREATE TABLE Exercise_Log (	--logs all the exercises the member has done
	RecordID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MemID INT NOT NULL,
	ExerciseName VARCHAR(255) NOT NULL,
	Sets INT,
	Reps INT,
	Calories INT, 
	Date DATETIME,
	Duration INT,
	FOREIGN KEY (MemID) REFERENCES Member(MemID) ON DELETE CASCADE,
	FOREIGN KEY (ExerciseName) REFERENCES Exercise(ExerciseName)
);

--24
--khudse delete entries upon deletion
CREATE TABLE Gym_Review (	--gym review
    GymID INT,
    MemberID INT,
    Comments VARCHAR(255),
    Date DATE,
    Time TIME,
    Rating INT,
    PRIMARY KEY (GymID, MemberID),
    FOREIGN KEY (GymID) REFERENCES Gym(GymID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemID)
);

--25
--stores all requests made to the admin to add gyms
--gym owner part of this is done
CREATE TABLE Gym_Requests(
	RequestID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	OwnerID INT,
	Address VARCHAR(255),
	GymName VARCHAR(100),
    PhoneNo VARCHAR(20),
	RequestDateTime DateTime,
	Status VARCHAR(50),
	FOREIGN KEY (OwnerID) REFERENCES GymOwner(OwnerID) ON DELETE CASCADE
);

--26
CREATE TABLE AccountLogs (
    LogID INT PRIMARY KEY,
    AccountType VARCHAR(50),
    Action VARCHAR(50),
    Reason VARCHAR(255),
    Date DATETIME,
    AdminID INT,
    FOREIGN KEY (AdminID) REFERENCES Users(UserID)
);

--27
CREATE TABLE Trainer_Request(
	RequestID INT IDENTITY(1,1) PRIMARY KEY,
	TrainerID INT,
	GymID INT,
	Status VARCHAR(100),
	Date DATETIME,
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID),
	FOREIGN KEY (GymID) REFERENCES Gym(GymID)
);


---Hafsa
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--PROCEDURES, FUNCTIONS, VIEWS ETC, CREATED FOR THE FRONTEND
--finds total gym members
CREATE OR ALTER FUNCTION TotalMembers
(
    @owner INT,
	@gymID INT
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalMembers INT;
    
    SELECT @TotalMembers = COUNT(*)
    FROM gym_membership ge
    INNER JOIN gym ON gym.gymID = ge.gymid
    WHERE gym.OwnerID = @owner AND gym.GymID = @GymID;

    RETURN @TotalMembers;
END

select fname, lname, Member.Weight, Member.Height, Member.Goal, DATEDIFF(YEAR, Dob, CURRENT_TIMESTAMP) AS Age, WorkoutPlan.PlanName AS WorkOut, DietPlan.PlanName AS Diet 
FROM Member 
INNER JOIN Users ON Member.MemID = Users.UserID 
INNER JOIN DietPlan ON Member.DPlanID = DietPlan.DPlanID 
INNER JOIN WorkoutPlan ON Member.WPlanID = WorkoutPlan.WPlanID 
WHERE Member.MemID = 30;
                

--finds total gym trainers
CREATE OR ALTER FUNCTION TotalTrainers
(
    @owner INT,
	@GymID INT
)
RETURNS INT
AS
BEGIN
    DECLARE @Trainers INT;
    
    SELECT @Trainers = COUNT(*)
    FROM Gym_Employment ge
    INNER JOIN gym ON gym.gymID = ge.gymid
    WHERE gym.OwnerID = @owner AND gym.GymID = @GymID;

    RETURN @Trainers;
END

--deactivates member
CREATE OR ALTER PROCEDURE DeactivateMember @Email Varchar(100)
AS BEGIN
	DECLARE @id INT;
	SELECT @id=UserID FROM USERS WHERE Email = @Email;
	UPDATE MEMBER
		set Account_Status='Deactivated'
	where MemID=@id;
END

--deletes member from gym
CREATE OR ALTER PROCEDURE RemoveMemberFromGym @Email Varchar(100)
AS BEGIN
	DECLARE @id INT;
	SELECT @id=UserID FROM USERS WHERE Email = @Email;
	UPDATE MEMBER
		set gymID=NULL
	where MemID=@id;
END

--updates gym info
CREATE OR ALTER PROCEDURE GymOwnerUpdateGym @gymID INT, @GymName VARCHAR(100), @PhoneNo VARCHAR(20), @Address VARCHAR(255)
AS BEGIN
	UPDATE GYM
		SET GymName = @GymName,
			Address = @Address,
			PhoneNo = @PhoneNo
		WHERE gymID = @gymID;
END

--delete gym from gyms
CREATE OR ALTER PROCEDURE GymOwnerDeleteGym @gymID INT
AS BEGIN
	DELETE Gym
	WHERE gymID = @gymID;
END

--this function checks if an email already exists in the system of not 
CREATE OR ALTER FUNCTION CheckIfEmailExists	--used when profile update
(
    @UID INT,
    @nayaEmail NVARCHAR(100)
)
RETURNS INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = @nayaEmail AND UserID <> @UID)
    BEGIN
        RETURN 1;
    END
    RETURN 0;
END

--this function checks if an email already exists in the system of not
CREATE OR ALTER FUNCTION GeneralCheckForEmail	--used when profile create
(
    @nayaEmail NVARCHAR(100)
)
RETURNS INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = @nayaEmail)
    BEGIN
        RETURN 1;
    END
    RETURN 0;
END


--Aoun
--REPORTS 

--1
CREATE OR ALTER VIEW TrainedBySpeceficTrainer AS
SELECT m.MemID,
	   m.Height,
	   m.Goal AS 'Member Goal',
	   m.Weight, 
       m.DPlanID,
	   m.WPlanID,
	   m.GymID,
	   m.MembershipType, 
       m.Start_Date AS 'Membership Start Date',
	   m.End_Date AS 'Membership End Date',
	   m.Account_Status AS 'Account Status',
       u.FName + ' ' + u.LName AS 'Member Name',
       u.Email AS 'Member Email',
	   u.PhoneNo AS 'Member Phone Number',
       u.UAddress AS 'Member Address',
       ts.TrainerID AS Trainer_ID, tu.FName + ' ' + tu.LName AS 'Trainer Name'
FROM Member m
JOIN Users u ON m.MemID = u.UserID
JOIN Training_Session ts ON m.MemID = ts.MemID
JOIN Trainer tr ON ts.TrainerID = tr.TrainerID
JOIN Users tu ON tr.TrainerID = tu.UserID
WHERE m.GymID = 1 
AND tr.TrainerID = 1; 

--2
CREATE OR ALTER VIEW Gym_DietPlan_Member_Details AS
SELECT m.MemID,
       m.Height,
       m.Goal AS 'Member Goal',
       m.Weight,
       m.DPlanID,
       m.WPlanID,
       m.GymID,
       m.MembershipType,
       m.Start_Date AS 'Membership Start Date',
       m.End_Date AS 'Membership End Date',
       m.Account_Status AS 'Account Status',
       u.FName + ' ' + u.LName AS 'Member Name',
       u.Email AS 'Member Email',
       u.PhoneNo AS 'Member Phone Number',
       u.UAddress AS 'Member Address',
       dp.DPlanID AS 'Diet Plan ID',
       dp.PlanName AS 'Diet Plan Name',
       dp.Type AS 'Diet Plan Type',
       dp.Goal AS 'Diet Plan Goal',
       dp.Description AS 'Diet Plan Description'
FROM Member m
JOIN Users u ON m.MemID = u.UserID
JOIN DietPlan dp ON m.DPlanID = dp.DPlanID
WHERE 
m.GymID = 1 -- specify the gym ID
AND
m.DPlanID = 1; -- specify the diet plan ID

--3 
CREATE OR ALTER VIEW Trainer_DietPlan_Member_Details
AS
SELECT m.MemID,
       m.Height,
       m.Goal AS 'Member Goal',
       m.Weight,
       m.DPlanID,
       m.WPlanID,
       m.GymID,
       m.MembershipType,
       m.Start_Date AS 'Membership Start Date',
       m.End_Date AS 'Membership End Date',
       m.Account_Status AS 'Account Status',
       u.FName + ' ' + u.LName AS 'Member Name',
       u.Email AS 'Member Email',
       u.PhoneNo AS 'Member Phone Number',
       u.UAddress AS 'Member Address',
       dp.DPlanID AS 'Diet Plan ID',
       dp.PlanName AS 'Diet Plan Name',
       dp.Type AS 'Diet Plan Type',
       dp.Goal AS 'Diet Plan Goal',
       dp.Description AS 'Diet Plan Description'
FROM Member m
JOIN Users u ON m.MemID = u.UserID
JOIN DietPlan dp ON m.DPlanID = dp.DPlanID
JOIN Training_Session ts ON m.MemID = ts.MemID
JOIN Trainer t ON ts.TrainerID = t.TrainerID
WHERE
t.TrainerID = 1 -- specify the trainer ID
AND 
m.DPlanID = 1;

 --4
CREATE OR ALTER VIEW MemberSpeceficCountMachineUsed AS
SELECT g.GymID,
       g.GymName,
       ge.MachineName,
       COUNT(ts.MemID) AS MemberCount
FROM Gym g
JOIN Gym_Equipment ge ON g.GymID = ge.GymID
LEFT JOIN Schedule_Exercise se ON g.GymID = se.PlanID
LEFT JOIN Exercise e ON se.ExerciseName = e.ExerciseName
LEFT JOIN Training_Session ts ON ge.MachineName = e.MachineName AND ts.Date = '2024-06-20'
WHERE g.GymID = 15-- Specify the gym ID
GROUP BY g.GymID, g.GymName, ge.MachineName;

 --5
CREATE OR ALTER VIEW BreakGreaterthan500 AS 
SELECT DISTINCT dp.DPlanID, dp.PlanName, dm.MealType ,m.Calories
FROM DietPlan dp
JOIN Diet_Meal dm ON dp.DPlanID = dm.DPlanID
JOIN Meal m ON dm.MealID = m.MealID
WHERE
dm.MealType = 'Breakfast'
AND
m.Calories < 500;

--6
CREATE OR ALTER VIEW Under300Carbs AS
SELECT dm.MealType, m.Calories, m.Carbs
FROM Diet_Meal dm
JOIN Meal m ON dm.MealID = m.MealID
WHERE m.Carbs < 300;

--7
CREATE OR ALTER VIEW WorkoutPlansWithoutMachine AS
SELECT ws.WPlanID, ws.Day, ws.MuscleGroup, wp.PlanName, e.MachineName
FROM WorkOutSchedule ws
JOIN WorkoutPlan wp ON ws.WPlanID = wp.WPlanID
LEFT JOIN Schedule_Exercise se ON ws.WPlanID = se.PlanID
LEFT JOIN Exercise e ON se.ExerciseName = e.ExerciseName
WHERE e.MachineName != 'Treadmill';

--8
CREATE OR ALTER VIEW DietPlansWithoutPeanuts AS
SELECT dp.DPlanID, dp.PlanName, dp.Type, dp.Goal, dp.Description
FROM DietPlan dp
WHERE NOT EXISTS (
    SELECT *
    FROM Diet_Meal dm
    JOIN Meal_Allergens ma ON dm.MealID = ma.MealID
    WHERE dm.DPlanID = dp.DPlanID
    AND ma.AllergenName = 'Peanuts'
);

--9
CREATE OR ALTER VIEW DisplayMembersJoinedInLast3Months AS 
SELECT 
    m.MemID, 
    m.Height, 
    m.Goal AS 'Member Goal', 
    m.Weight, 
    m.DPlanID, 
    m.WPlanID, 
    m.GymID, 
    m.MembershipType, 
    m.Start_Date AS 'Membership Start Date', 
    m.End_Date AS 'Membership End Date', 
    m.Account_Status AS 'Account Status',
    u.FName + ' ' + u.LName AS 'Member Name',
    u.Email AS 'Member Email', 
    u.PhoneNo AS 'Member Phone Number',
    u.UAddress AS 'Member Address',
    gm.Payment, 
    g.GymName, 
    gg.OwnerID AS Gym_OwnerID,
    gu.JoinDate AS Owner_StartDate
FROM 
    Member m
JOIN 
    Users u ON m.MemID = u.UserID
JOIN 
    Gym_Membership gm ON m.GymID = gm.GymID
JOIN 
    Gym g ON m.GymID = g.GymID
JOIN 
    GymOwner gg ON g.OwnerID = gg.OwnerID
JOIN 
    Users gu ON gg.OwnerID = gu.UserID
WHERE 
    m.GymID = 1-- Specify the specific gym ID here
    AND m.Start_Date >= DATEADD(MONTH, -3, GETDATE());


--10
CREATE OR ALTER VIEW NumberofMembersinLast6Months As 
SELECT g.GymID, g.GymName, COUNT(m.MemID) AS TotalMembers
FROM Gym g
JOIN Member m ON g.GymID = m.GymID
WHERE m.Start_Date >= DATEADD(MONTH, -6, GETDATE())
GROUP BY  g.GymName , g.GymID;


--SELF MADE REPORTS
--11
--Displaying Trainers and their Specializations 

CREATE OR ALTER VIEW TrainerWithSpecialization AS
SELECT top 100 TS.TrainerID , (U.FName + ' ' + U.LName) AS 'Trainer Name', TS.Specialization 
FROM Trainer_Specializations TS
JOIN Users u ON u.UserID = TS.TrainerID
WHERE u.UserID = TS.TrainerID
ORDER BY TS.TrainerID, TS.Specialization
--SELECT * FROM TrainerWithSpecialization

--12
--Displaying Trainers with their Qualifications
CREATE OR ALTER VIEW TrainerWithQualifications AS
SELECT top 100 TQ.TrainerID , (U.FName + ' ' + U.LName) AS 'Trainer Name', TQ.Qualification
FROM Trainer_Qualifications TQ
JOIN Users u ON u.UserID = TQ.TrainerID
WHERE u.UserID = TQ.TrainerID
ORDER BY TQ.TrainerID, TQ.Qualification
--SELECT * FROM TrainerWithQualifications;

--13 
--Average rating of each gym
CREATE OR ALTER VIEW AverageGymRating AS
SELECT GR.GymID, G.GymName, AVG(GR.Rating) AS 'Average Rating'
FROM Gym_Review GR
JOIN Gym g ON GR.GymID = G.GymID
GROUP BY GR.GymID, G.GymName
--SELECT * FROM AverageGymRating;

--14
--Members and they Allergies 
CREATE OR ALTER VIEW MemberWithAllergy AS
SELECT top 1000 M.MemID, (U.FName + ' ' + U.LName) AS 'Name', MA.Allergens
FROM Member M
JOIN Users U ON U.UserID = M.MemID
JOIN Member_Allergy MA ON MA.MemID = M.MemID
ORDER BY M.MemID
--SELECT * FROM MemberWithAllergy

--15 
--Average Rating for Trainers
CREATE OR ALTER VIEW TrainerAndAverageRating AS
SELECT TOP 1000 T.TrainerID, (U.FName + ' ' + U.LName) AS 'Trainer Name',AVG(TF.Rating) AS 'Average Rating' 
FROM Trainer T
JOIN Users U ON U.UserID = T.TrainerID
JOIN Trainer_Feedback TF ON TF.TrainerID = T.TrainerID
GROUP BY T.TrainerID, U.FName, U.LName;
--SELECT * FROM TrainerAndAverageRating;

--16 
--Gym with their Total Cost of their Equipment
CREATE OR ALTER VIEW GymEquipmentCost AS
SELECT TOP 1000 G.GymID, G.GymName, SUM(M.Price * GE.MachineCount) AS 'Net Cost of Equipment' 
FROM Gym G
JOIN Gym_Equipment GE ON GE.GymID = G.GymID
JOIN Machine M ON M.MachineName = GE.MachineName
GROUP BY G.GymID, G.GymName
ORDER BY 
    G.GymID , SUM(M.Price * GE.MachineCount);
--SELECT * FROM GymEquipmentCost;


--17
--Gyms and their Employed Trainers
CREATE OR ALTER VIEW GymWithEmployedTrainers AS
SELECT G.GymID, G.GymName, GE.TrainerID, (U.FName + ' ' + U.LName) AS 'Trainer Name'
FROM Gym G
JOIN Gym_Employment GE ON GE.GymID = G.GymID
JOIN Users U ON U.UserID = GE.TrainerID
--SELECT * FROM GymWithEmployedTrainers;

--18
--Machines which are used most in Exercise
CREATE OR ALTER VIEW NumTimesMachineUsed AS
SELECT M.MachineName, Count(E.MachineName) AS 'Number of Times Used'
FROM Machine M
JOIN Exercise E ON E.MachineName = M.MachineName
GROUP BY M.MachineName
--SELECT * FROM NumTimesMachineUsed

--19
--Trainers which have the most number of sessions booked
CREATE OR ALTER VIEW TrainersAndNumberOfSessionsBooked AS
SELECT T.TrainerID, (U.FName + ' ' + U.LName) AS 'Trainer Name' ,Count(TS.SessID) AS 'Sessions Booked'
FROM Trainer T
JOIN Users U ON U.UserID = T.TrainerID 
JOIN Training_Session TS ON TS.TrainerID = T.TrainerID
GROUP BY T.TrainerID, U.FName , U.LName;
--SELECT * FROM TrainersAndNumberOfSessionsBooked;

--20
--Total Salary given to Trainers at a Certain Gym
CREATE OR ALTER VIEW AverageSalaryGivenToTrainers AS
SELECT T.TrainerID, (U.FName + ' ' + U.LName) AS 'Trainer Name' , SUM(GE.Salary) AS 'Total Salary'
FROM Trainer T
JOIN Users U ON U.UserID = T.TrainerID
JOIN Gym_Employment GE ON GE.TrainerID = T.TrainerID
GROUP BY T.TrainerID, U.FName, U.LName;
--SELECT * FROM AverageSalaryGivenToTrainers;