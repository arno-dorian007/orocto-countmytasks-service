CREATE TABLE UserDetails
(
  UserID int primary key not null identity(1, 1),
  FirstName nvarchar(100) not null,
  MiddleName nvarchar(100),
  LastName nvarchar(100),
  Age int,
  GenderID int not null
)
