CREATE TABLE Student(Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Age INT,
    Email VARCHAR(100) UNIQUE) 
GO


INSERT INTO Student (Id, Name, Age, Email)
VALUES 
(2, 'Anjali', 21, 'anjali@gmail.com'),
(3, 'Kiran', 19, 'kiran@gmail.com'),
(4, 'Sneha', 22, 'sneha@gmail.com')
GO

SELECT * FROM Student 
GO