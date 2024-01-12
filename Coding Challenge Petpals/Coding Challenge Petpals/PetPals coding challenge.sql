


create database PetPals;

use PetPals;





-- TABLES CREATION


CREATE TABLE  Pets (
    PetID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Age INT,
    Breed VARCHAR(100),
    Type VARCHAR(50),
    AvailableForAdoption BIT
);

CREATE TABLE  Shelters (
    ShelterID INT PRIMARY KEY identity(1,1),
    Name VARCHAR(100),
    Location VARCHAR(255)
);

CREATE TABLE  Donations (
    DonationID INT PRIMARY KEY identity(1,1),
    DonorName VARCHAR(100),
    DonationType VARCHAR(50),
    DonationAmount DECIMAL(10, 2),
    DonationItem VARCHAR(100),
    DonationDate DATETIME
);

CREATE TABLE  AdoptionEvents (
    EventID INT PRIMARY KEY identity(1,1),
    EventName VARCHAR(100),
    EventDate DATETIME,
    Location VARCHAR(255)
);

CREATE TABLE  Participants (
    ParticipantID INT PRIMARY KEY identity(1,1),
    ParticipantName VARCHAR(100),
    ParticipantType VARCHAR(50),
    EventID INT,
    FOREIGN KEY (EventID) REFERENCES AdoptionEvents(EventID) on delete set null
);


insert into Pets 
values
    ( 'Argus', 2, 'German Shepherd', 'Dog', 0),
    ( 'Alf', 1, 'Persian', 'Cat', 1),
    ( 'Basil', 3, 'German Shepherd', 'Dog', 1),
    ( 'Ivory', 1, 'Pomeranian', 'Dog', 1),
    ( 'Houdini', 2, 'Ragdoll', 'Cat', 0),
    ( 'Jake', 4, 'Beagle', 'Dog', 1),
    ( 'Nellie', 1, 'Maine Coon', 'Dog', 0),
    ( 'Mitch', 2, 'Siamese', 'Cat', 1),
    ( 'Wayne', 1, 'Golden Retriever', 'Dog', 1),
    ( 'Scarlett', 3, 'Golden Retriever', 'Dog', 1);

	SELECT * FROM Pets


insert into Shelters
values
    ( 'Loving Paws Sanctuary', 'Mumbai, Maharashtra'),
    ( 'Harmony Haven for Pets', 'Delhi, Delhi'),
    ( 'Whisker Haven', 'Bangalore, Karnataka'),
    ( 'Rainbow Shelter', 'Chennai, Tamil Nadu'),
    ( 'Fur-ever Home Shelter', 'Kolkata, West Bengal'),
    ( 'Furry Friends Shelter', 'Hyderabad, Telangana'),
    ( 'Tail Wagging Retreat', 'Pune, Maharashtra'),
    ( 'Joyful Tails', 'Ahmedabad, Gujarat'),
    ( 'Rescue Me Pet Sanctuary', 'Jaipur, Rajasthan'),
    ( 'Second Chance Critter Rescue', 'Lucknow, Uttar Pradesh');

	--SELECT * FROM Shelters


insert into Donations 
values
    ( 'Kohli', 'Cash', 100.00, NULL, '2023-01-15 10:30:00'),
    ( 'Rohit', 'Item', NULL, 'Pet Food', '2023-02-02 15:45:00'),
    ( 'Messi', 'Cash', 50.00, NULL, '2023-03-10 08:20:00'),
    ( 'Ronaldo', 'Item', NULL, 'Pet Toys', '2023-04-05 12:10:00'),
    ( 'Neymar', 'Cash', 75.00, NULL, '2023-05-20 14:55:00'),
    ( 'Suarez', 'Item', NULL, 'Pet Bed', '2023-06-18 09:30:00'),
    ( 'Dembele', 'Cash', 120.00, NULL, '2023-07-03 11:40:00'),
    ( 'Pedri', 'Item', NULL, 'Cat Litter', '2023-08-22 16:15:00'),
    ( 'Gavi', 'Cash', 90.00, NULL, '2023-09-14 13:25:00'),
    ( 'Araujo', 'Item', NULL, 'Dog Leash', '2023-10-30 07:50:00');

	--select * from Donations


insert into AdoptionEvents 
values
    ( 'Adoptions Festival', '2023-01-25 11:00:00', 'Mumbai, Maharashtra'),
    ( 'FriendsHomes Expo', '2023-03-15 14:30:00', 'Lucknow, Uttar Pradesh'),
    ( 'Adopt-a-Palooza', '2023-05-05 12:00:00', 'Bangalore, Karnataka'),
    ( 'Pet Adoption Expo', '2023-07-10 10:00:00', 'Bangalore, Karnataka'),
    ( 'Year Ending Carnival', '2023-09-02 15:00:00', 'Ahmedabad, Gujarat'),
    ( 'Paws for Love', '2023-10-18 13:45:00', 'Mumbai, Maharashtra'),
    ( 'Pets Fair', '2023-12-01 09:30:00', 'Lucknow, Uttar Pradesh'),
    ( 'Love For Pets', '2024-02-08 11:20:00', 'Kolkata, West Bengal'),
    ( 'Pets Offer Sale', '2024-04-03 16:00:00', 'Jaipur, Rajasthan'),
    ( 'Adopt A Heart', '2024-06-22 10:45:00', 'Chennai, Tamil Nadu');

	--select * from AdoptionEvents


insert into Participants 
values
    ('Manideep', 'Shelter', 1),
    ('Shyam', 'Adopter', 1),
    ('Vasanth', 'Shelter', 2),
    ('Ram', 'Adopter', 2),
    ('Prem', 'Shelter', 3),
    ('Akhil', 'Adopter', 3),
    ('Jayanth', 'Shelter', 4),
    ('Bobby', 'Adopter', 4),
    ('Rainbow Shelter', 'Shelter', 5),
    ('Ananya', 'Adopter', 5);






