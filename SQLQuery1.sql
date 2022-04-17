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

