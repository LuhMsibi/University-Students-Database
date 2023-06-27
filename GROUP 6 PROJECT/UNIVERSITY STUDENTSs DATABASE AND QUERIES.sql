CREATE DATABASE University_StudentsS;
use University_StudentsS;


-- Create the departments table 1
CREATE TABLE departments (
  department_id INT PRIMARY KEY,
  department_name VARCHAR(255) NOT NULL
);

-- Create the instructors table 2
CREATE TABLE instructors (
  instructor_id INT PRIMARY KEY,
  instructor_Fname VARCHAR(255) NOT NULL,
  instructor_Lname VARCHAR(255) NOT NULL,
  instructor_address VARCHAR(255),
  instructor_phone BIGINT,
  department_id INT,
  FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

----Create the courses table--- 3
CREATE TABLE courses (
  course_id INT PRIMARY KEY,
  course_name VARCHAR(255) NOT NULL,
  department_id INT,
  instructor_id INT,
  sections_id INT,
  FOREIGN KEY (department_id) REFERENCES departments(department_id),
  FOREIGN KEY (instructor_id) REFERENCES instructors(instructor_id)
);

-- Create the sections table 4
CREATE TABLE sections (
  section_id INT PRIMARY KEY,
  course_id INT,
  instructor_id INT,
  room_num INT,
  room_color VARCHAR(150),
  FOREIGN KEY (course_id) REFERENCES courses(course_id),
  FOREIGN KEY (instructor_id) REFERENCES instructors(instructor_id)
);


---5
CREATE TABLE enrollment (
  enrollment_id INT PRIMARY KEY,
  section_id INT,
  grade INT,
  FOREIGN KEY (section_id) REFERENCES sections(section_id)
);


-- CREATING TABLE AND PROCEDURE TO INSERT DATA TO IT
CREATE TABLE STUDENTS(                       
ID VARCHAR (10) PRIMARY KEY NOT NULL,
First_Name VARCHAR (50),
Last_Name VARCHAR (50),
Email VARCHAR (50),
Phone VARCHAR (10),
Password VARCHAR (50),
CourseId INT,
FOREIGN KEY (CourseId) REFERENCES COURSES(COURSE_ID)
)


--inserting data from the forms to students
CREATE PROCEDURE INSERT_STUDENT	
@id VARCHAR (10),
@Fname VARCHAR (50),
@Lname VARCHAR (50),
@email VARCHAR (50),
@phone VARCHAR (10),
@password VARCHAR (50),
@courseid INT
AS
INSERT INTO STUDENTS VALUES (@id, @Fname, @Lname, @email, @phone, @password, @courseid)











---- Insert data into the Departments table
INSERT INTO  departments( department_id ,department_name)
values
  (1, 'Sales'),
  (2, 'Marketing'),
  (3, 'Finance'),
  (4, 'Human Resources'),
  (5, 'Research and Development'),
  (6, 'Information Technology'),
  (7, 'Customer Service'),
  (8, 'Operations'),
  (9, 'Supply Chain'),
  (10, 'Quality Assurance'),
  (11, 'Legal'),
  (12, 'Product Management'),
  (13, 'Engineering'),
  (14, 'Public Relations'),
  (15, 'Training and Development'),
  (16, 'Purchasing'),
  (17, 'Business Development'),
  (18, 'Accounting'),
  (19, 'Administrative'),
  (20, 'Project Management');
  
-- Insert data into the instructors table
INSERT INTO instructors (instructor_id, instructor_Fname, instructor_Lname, instructor_address, instructor_phone, department_id)
VALUES
  (1, 'John', 'Smith', '123 Main Street', 1234567890, 1),
  (2, 'Emily', 'Johnson', '456 Elm Street', 9876543210, 2),
  (3, 'Michael', 'Williams', '789 Oak Avenue', 5555555555, 3),
  (4, 'Sarah', 'Davis', '987 Pine Road', 1111111111, 4),
  (5, 'David', 'Brown', '654 Cedar Lane', 9999999999, 5),
  (6, 'Jessica', 'Taylor', '321 Birch Drive', 8888888888, 6),
  (7, 'Daniel', 'Wilson', '111 Willow Court', 7777777777, 7),
  (8, 'Olivia', 'Miller', '222 Maple Avenue', 6666666666, 8),
  (9, 'Andrew', 'Anderson', '333 Oak Lane', 4444444444, 9),
  (10, 'Sophia', 'Garcia', '444 Pine Street', 3333333333, 10),
  (11, 'Ethan', 'Lopez', '555 Elm Court', 2222222222, 11),
  (12, 'Isabella', 'Martinez', '666 Oak Road', 7777777777, 12),
  (13, 'Miale', 'Robinson', '777 Pine Avenue', 9999999999, 13),
  (14, 'Helen', 'Thompson', '888 Cedar Lane', 1111111111, 14),
  (15, 'Blue', 'Aiva', '999 Birch Drive', 6666666666, 15),
  (16, 'Benjamin', 'Dube', '101 Willow Court', 5555555555, 16),
  (17, 'Liam', 'Clark', '222 Oak Avenue', 7777777777, 17),
  (18, 'Victoria', 'Lewis', '333 Elm Street', 8888888888, 18),
  (19, 'Henry', 'Hall', '444 Pine Road', 9999999999, 19),
  (20, 'Grace', 'Young', '555 Cedar Lane', 1111111111, 20)




-- Insert data into the courses table----
INSERT INTO courses (course_id, course_name, department_id, instructor_id, sections_id)
VALUES
  (1, 'Mathematics', 3, 1, 1),
  (2, 'Physics', 13, 2, 2),
  (3, 'Chemistry', 10, 3, 3),
  (4, 'Biology', 5, 4, 4),
  (5, 'Computer Science', 6, 5, 5),
  (6, 'English', 11, 6, 6),
  (7, 'History', 19, 7, 7),
  (8, 'Geography', 14, 8, 8),
  (9, 'Economics', 18, 9, 9),
  (10, 'Business Administration', 20, 10, 10),
  (11, 'Psychology', 4, 11, 11),
  (12, 'Sociology', 7, 12, 12),
  (13, 'Art', 1, 13, 13),
  (14, 'Music', 4, 14, 14),
  (15, 'Theater', 4, 15, 15),
  (16, 'Dance', 4, 16, 16),
  (17, 'Engineering', 13, 17, 17),
  (18, 'Architecture', 13, 18, 18),
  (19, 'Civil Engineering', 13, 19, 19),
  (20, 'Mechanical Engineering', 13, 20, 20)


  
-- Insert data into the sections table 
INSERT INTO sections (section_id, course_id, instructor_id, room_num, room_color)
VALUES
  (1, 1, 1, 101, 'Red'),
  (2, 2, 2, 102, 'Blue'),
  (3, 3, 3, 201, 'Green'),
  (4, 4, 4, 202, 'Yellow'),
  (5, 5, 5, 301, 'Purple'),
  (6, 6, 6, 302, 'Orange'),
  (7, 7, 7, 401, 'Pink'),
  (8, 8, 8, 402, 'Gray'),
  (9, 9, 9, 501, 'Brown'),
  (10, 10, 10, 502, 'Black'),
  (11, 11, 11, 601, 'White'),
  (12, 12, 12, 602, 'Red'),
  (13, 13, 13, 701, 'Blue'),
  (14, 14, 14, 702, 'Green'),
  (15, 15, 15, 801, 'Yellow'),
  (16, 16, 16, 802, 'Purple'),
  (17, 17, 17, 901, 'Orange'),
  (18, 18, 18, 902, 'Pink'),
  (19, 19, 19, 1001, 'Gray'),
  (20, 20, 20, 1002, 'Brown')


INSERT INTO enrollment (enrollment_id, section_id, grade)
VALUES
  (1, 1, 85),
  (2, 1, 90),
  (3, 2, 78),
  (4, 2, 92),
  (5, 3, 87),
  (6, 3, 81),
  (7, 4, 95),
  (8, 4, 88),
  (9, 5, 76),
  (10, 5, 93),
  (11, 6, 89),
  (12, 6, 84),
  (13, 7, 91),
  (14, 7, 82),
  (15, 8, 96),
  (16, 8, 77),
  (17, 9, 83),
  (18, 9, 90),
  (19, 10, 94),
  (20,10, 86)

  -- can use this table to check results

  ---------populate the tables-----------------------

SELECT * FROM DEPARTMENTS
SELECT * FROM INSTRUCTORS
SELECT * FROM COURSES
SELECT * FROM SECTIONS
SELECT * FROM ENROLLMENT





----------------------------------------
---------------------------------------






--THIS PROCEDURE CHECKS IF THE USER IS FOUND IN THE TABLE

CREATE PROCEDURE CHECK_STUDENT  -----DROPED THIS AGAIN TO CHECK STUDENTS
@id VARCHAR (10),
@password VARCHAR (50)
AS
BEGIN
SELECT * FROM STUDENTS
WHERE ID = @id AND Password = @password
END




SELECT * FROM STUDENTS

---admin table that stores the admins

CREATE TABLE REGISTERED_ADMIN(
ID VARCHAR (10) PRIMARY KEY NOT NULL,
First_Name VARCHAR (50),
Last_Name VARCHAR (50),
Email VARCHAR (50),
Phone VARCHAR (10),
Password VARCHAR (50)
)

INSERT INTO REGISTERED_ADMIN VALUES
(33, 'Sipho', 'Sikhosana', 'Sipho@gmail.com', '0761414059', 'sipho')

select * from REGISTERED_ADMIN


-------------INSERT TO ADMIN  ---COMENT THIS OUT SINCE I AM GONNA ADD ADMIN MANUALLY DROPED
--CREATE PROCEDURE INSERT_ADMIN
--@id VARCHAR (10),
--@Fname VARCHAR (50),
--@Lname VARCHAR (50),
--@email VARCHAR (50),
--@phone VARCHAR (10),
--@password VARCHAR (50),
--@usertype VARCHAR (50)
--AS
--INSERT INTO REGISTERED_ADMIN VALUES (@id, @Fname, @Lname, @email, @phone, @password, @usertype)


--THIS PROCEDURE CHECKS IF THE admin IS FOUND IN THE TABLE

CREATE PROCEDURE CHECK_ADMIN
@id VARCHAR (10),
@password VARCHAR (50)
AS
BEGIN
SELECT * FROM REGISTERED_ADMIN
WHERE ID = @id AND Password = @password
END

SELECT * FROM STUDENTS
SELECT * FROM REGISTERED_ADMIN


--THIS IS THE VIEW I USE TO DISPLAY USERS INFO ABOUT THE COURSE THAT THEY ARE ENROLLED IN 
CREATE VIEW StudentCourseInfo AS
select DISTINCT r.ID, r.First_Name, r.Last_Name, c.COURSE_NAME, d.DEPARTMENT_NAME, i.instructor_Fname, s.room_num, s.room_color
from STUDENTS r
join COURSES c ON c.COURSE_ID = r.CourseId
join DEPARTMENTS d on c.DEPARTMENT_ID = d.DEPARTMENT_ID
join INSTRUCTORS i on d.DEPARTMENT_ID = i.DEPARTMENT_ID
JOIN SECTIONS s ON c.COURSE_ID = s.COURSE_ID

SELECT * FROM StudentCourseInfo

------------------------------------------------------
----------------------------------------------------------

--TRIGGERS
--THIS TRIGGER AUTOMATICALLY STORES THE DETALIS OF THE STUDENTS THAT WERE DE REGISTERED OF DELETED
CREATE TABLE DELETED_STUDENTS(
ID VARCHAR (10) PRIMARY KEY NOT NULL,
First_Name VARCHAR (50),
Last_Name VARCHAR (50),
Email VARCHAR (50),
Phone VARCHAR (10),
Password VARCHAR (50),
UserType VARCHAR(15),
CourseId INT,
FOREIGN KEY (CourseId) REFERENCES COURSES(COURSE_ID)
)

CREATE TRIGGER AFTER_DELETE
ON STUDENTS
AFTER DELETE
AS
BEGIN
	DECLARE @id varchar(10),
			@fname varchar(50),
			@lname varchar(50),
			@email varchar(50),
			@phone varchar(10),
			@password varchar(50),
			@usertype varchar(15),
			@courseid int

	--checks if any records exist in the 'deleted table'
	IF EXISTS (SELECT * FROM deleted)
	BEGIN
		SELECT @id = deleted.ID,
				@fname = deleted.First_Name,
				@lname = deleted.Last_Name,
				@email = deleted.Email,
				@phone = deleted.Phone,
				@password = deleted.Password,
				@usertype = deleted.UserType,
				@courseid = deleted.Courseid
		FROM deleted

		INSERT INTO DELETED_STUDENTS VALUES (@id, @fname, @lname, @email, @phone, @password, @usertype, @courseid)
	END
END



SELECT * FROM DELETED_STUDENTS




--------QUESTION 6-------------------------------------------------------------------------------
----NO.1    find a total number of students in each department----------------------------------

SELECT departments.department_name, COUNT(*) AS TOTAL_STUDENTS
FROM departments
JOIN courses ON departments.department_id = courses.department_id
JOIN students ON courses.course_id = students.CourseId
GROUP BY departments.department_name

-----NO.2   Find the course with the highest average grade-----------

SELECT TOP 1 courses.course_name, AVG (enrollment.grade)AS Average_grade
FROM enrollment
JOIN sections ON enrollment.section_id = sections.section_id
JOIN courses ON sections.course_id = courses.course_id
GROUP BY courses.course_name
ORDER BY Average_grade DESC;

----NO.3 Retrieve all departments and their respective instructors:----
SELECT departments.department_name, instructors.instructor_Fname,instructors.instructor_Lname
FROM departments 
JOIN instructors  ON departments.department_id = instructors.department_id

----NO.4 Retrieve the course names along with the department name and instructor full name:
SELECT courses.course_name, departments.department_name, CONCAT(instructors.instructor_Fname, ' ', instructors.instructor_Lname) AS instructor_name
FROM courses 
JOIN departments  ON courses.department_id = departments.department_id
JOIN instructors  ON courses.instructor_id = instructors.instructor_id;


----NO.5 Retrieve the department and instructor for a given section:-----
SELECT d.department_name, CONCAT(i.instructor_Fname, ' ', i.instructor_Lname) AS instructor_name
FROM sections sec
JOIN courses C ON sec.course_id = c.course_id
JOIN departments d ON c.department_id = d.department_id
JOIN instructors i ON sec.instructor_id = i.instructor_id

----NO.6 Retrieve all courses taught by a specific instructor:
SELECT c.course_name
FROM instructors i
JOIN courses c ON i.instructor_id = c.instructor_id
WHERE CONCAT(i.instructor_Fname, ' ', i.instructor_Lname) = 'John Smith';

----N0.7 Retrieve the average grade for each course:
SELECT c.course_name, AVG(e.grade) AS average_grade
FROM courses c
LEFT JOIN sections sec ON c.course_id = sec.course_id
LEFT JOIN enrollment e ON sec.section_id = e.section_id
GROUP BY c.course_name;

----N0.8 Retrieve the number of students enrolled in each section:
SELECT sec.section_id, COUNT(e.enrollment_id) AS num_students
FROM sections sec
LEFT JOIN enrollment e ON sec.section_id = e.section_id
GROUP BY sec.section_id;

----N0.9 Retrieve all the registered students
SELECT * FROM STUDENTS

----NO.10 Retrive all the deregistered  students
SELECT * FROM DELETED_STUDENTS









