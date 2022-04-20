CREATE TABLE Departments(
	d_id int PRIMARY KEY,
	d_name varchar(50),
);

CREATE TABLE Instructors(
	i_id int PRIMARY KEY,
	i_name VARCHAR(50), 
	i_salary REAL,
	i_age int 
);

CREATE TABLE Students(
	s_id int PRIMARY KEY,
	s_name VARCHAR(50),
	s_age int,
);
CREATE TABLE Courses(
	c_id int PRIMARY KEY,
	c_name VARCHAR(50), 
	i_id int FOREIGN KEY REFERENCES Instructors(i_id),
);


CREATE TABLE Works_in(
	d_id int REFERENCES Departments(d_id),
	i_id int REFERENCES Instructors(i_id),
	PRIMARY KEY(d_id, i_id),
);

CREATE TABLE Head(
	d_id int UNIQUE REFERENCES Departments(d_id),
	i_id int REFERENCES Instructors(i_id),
	PRIMARY KEY(d_id, i_id),
);

CREATE TABLE Enrolled(
	s_id int REFERENCES Students(s_id),
	c_id int REFERENCES Courses(c_id),
	PRIMARY KEY(s_id, c_id)

);

CREATE TABLE teach(
	i_id int FOREIGN KEY REFERENCES Instructors(i_id),
	c_id int FOREIGN KEY REFERENCES Courses(c_id),
	);
	
CREATE TABLE Offer(
	d_id int FOREIGN KEY REFERENCES Departments(d_id), 
	c_id int FOREIGN KEY REFERENCES Courses(c_id),
	PRIMARY KEY(d_id,c_id),
);
INSERT INTO Departments VALUES(0,'Mathematics'),(1, 'Art'), (2,'English'), (3, 'Science')
GO 

INSERT INTO Instructors VALUES (66, 'Frank', 100000, 60), (11, 'Paul' ,39000, 70 ),(22, 'Steve', 80000, 55), (33, 'Barbera',95000, 53),(44, 'Lisa', 45000, 40),(55, 'Karen', 21000, 49),(77, 'Tom', 750000, 80), (88, 'Greg' ,49000, 36 ),(99, 'Mindy', 80000, 45)
GO

INSERT INTO Students VALUES (777, 'Sam', 19), (111, 'Charlie', 21), (222, 'Alex', 22), (333, 'Max', 20), (444, 'Elena', 24), (555 ,'Vicky', 22), (666,'Adon', 21), (888, 'Michael', 21), (999, 'Daniel', 20), (101, 'Oury', 22), (102, 'Ella', 19)
GO

INSERT INTO Works_in VALUES (0,66), (1,11), (2,22), (3,33), (3,44), (0,55), (1,77), (2,88), (3,99)
GO 

INSERT INTO Head Values (0,66), (1,11), (2,88) , (3,33)
GO

INSERT INTO Courses VALUES(201, 'Calculus', 66),( 202, 'Databases',66), (203,'Pottery',77), (204, 'Painting',11), (205, 'New books',22), (206,'Old books',88), (207, 'Chemistry',33), (208, 'Physics',99) 
GO 

INSERT INTO ENROLLED VALUES(777,201) , (111,203) , (111,204) , (222,205) , (222,206), (333,207), (333, 208), (444,201), (444,202), (555, 203), (555,204) , (666,205), (666,206), (777,207), (777,208), (888,201), ( 888,202), (999,203),(999,204), (101, 205),(101,206), (102,207), (102,208),(777,203), (777,204) , (111,205) , (111,206) , (222,207) , (222,208), (333,204), (333, 201), (444,203), (444,204), (555, 201), (555,202) , (666,208), (666,204), (777,202), (777,206), ( 888,205), (999,207),(999,206), (101, 207),(101,203), (102,204), (102,206)
GO