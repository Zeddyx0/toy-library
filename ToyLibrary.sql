use amha2_TL

create table Librarian
(
	librarianID int not null IDENTITY PRIMARY KEY,
	fName varchar(32),
	lName varchar(32),
	DOB date,
	uName varchar(32),
	pWord varchar(32)
)


create table Membership 
(
	loginPassword varchar(32),
	loginName varchar(32),
	childID int FOREIGN KEY REFERENCES Child(childID),
	
	ALTER TABLE Membership
	ADD ID int not null IDENTITY PRIMARY KEY;

)

create table Lending 
(
	lendingID int not null IDENTITY PRIMARY KEY,
	lendingDate timestamp,
	deadline date,
	returnedOn date,
	lendingState varchar(32),
	rating numeric(5),
	childID int foreign key references Child(childID),
	toyID int foreign key references Toy(toyID),
	--foreign key (childID)references Child,
)

create table Child 
(
	childID int not null IDENTITY PRIMARY KEY,
	fname varchar(32),
	lname varchar(32),
	iwi varchar(32,
	DOB date,
	gender varchar(32,
	note varchar(32),
	childLanguage varchar(32),
	
	ALTER TABLE Child
	alter COLUMN gender varchar(32);
)

create table Disability 
(
	disabilityID int not null IDENTITY PRIMARY KEY,
	title varchar(32),
	disabilityDescription varchar(32),
)

create table Toy 
(
	toyID int not null IDENTITY PRIMARY KEY,
	name varchar(32),
	toyDescription varchar(32),
	purchasedOn timestamp,
	--photo
	replaceCost money,
	originalCost money,
	libraryLocation varchar(32),
	legacyID int,
	parts varchar(32),
	toyStatus bit,
	toyType varchar(32),
	
	select * from Toy
	
	ALTER TABLE Toy
	alter COLUMN toyDescription varchar(50);
)

create table Category 
(
	categoryID int not null IDENTITY PRIMARY KEY,
	title varchar(32),
	categoryDscription varchar(32),
)

create table ChildDisabilityRelate 
(
	childID int foreign key references Child(childID),
	disabilityID int foreign key references Disability(disabilityID),
	primary key(childID, disabilityID),
)

create table ToyInCategoryRelate  
(
	toyID int foreign key references Toy(toyID),
	categoryID int foreign key references Category(categoryID),
	primary key(toyID, categoryID),
)

drop TABLE Membership;
drop TABLE Lending;
drop TABLE Child;
drop TABLE Disability;
drop TABLE Toy;
drop TABLE Category;
drop TABLE ChildDisabilityRelate;
drop TABLE ToyInCategoryRelate;


insert into Librarian(fName, lName, DOB, uName, pWord) values ('Zeddy', 'Andijani', '1992-07-07', 'zeddyx0', '1234')
insert into Librarian(fName, lName, DOB, uName, pWord) values ('John', 'Cena', '1720-01-01', 'jhonnyD', 'cenabb')

select * from Librarian

insert into Category(title) values('Active Play') where categoryID ='1';
insert into Category(title) values('Animals')
insert into Category(title) values('Asking questions')
insert into Category(title) values('Babies')
insert into Category(title) values('Balance')
insert into Category(title) values('Books')
insert into Category(title) values('Cars')
insert into Category(title) values('CD music')
insert into Category(title) values('CD story')
insert into Category(title) values('CD')
insert into Category(title) values('Colour')
insert into Category(title) values('Communication')
insert into Category(title) values('Construction')
insert into Category(title) values('Construction')
insert into Category(title) values('Coordination')
insert into Category(title) values('Counting')
insert into Category(title) values('Dancing')
insert into Category(title) values('Dice')
insert into Category(title) values('Dinosaurs')
insert into Category(title) values('Dolls')
insert into Category(title) values('Dolls house')
insert into Category(title) values('Dress up')
insert into Category(title) values('DVD')
insert into Category(title) values('DVD - Film')
insert into Category(title) values('DVD - music')
insert into Category(title) values('Early child hood')
insert into Category(title) values('Fine Motor')
insert into Category(title) values('Fire engine ')
insert into Category(title) values('Firemen ')
insert into Category(title) values('Flash cards')
insert into Category(title) values('Floor play')
insert into Category(title) values('Floor puzzles ')
insert into Category(title) values('Games')
insert into Category(title) values('Gardening')
insert into Category(title) values('Gears')
insert into Category(title) values('Gross Motor')
insert into Category(title) values('Hammering')
insert into Category(title) values('House')
insert into Category(title) values('Imaginative play')
insert into Category(title) values('Jumping')
insert into Category(title) values('Kaleidoscopes ')
insert into Category(title) values('Kitchen')
insert into Category(title) values('Kits')
insert into Category(title) values('Light')
insert into Category(title) values('Literacy')
insert into Category(title) values('Loud sounds')
insert into Category(title) values('Machines')
insert into Category(title) values('Magnets')
insert into Category(title) values('Marble runs')
insert into Category(title) values('Maths')
insert into Category(title) values('Memory')
insert into Category(title) values('Music')
insert into Category(title) values('Nature')
insert into Category(title) values('Outdoor games')
insert into Category(title) values('Phonetics')
insert into Category(title) values('Police')
insert into Category(title) values('Posting')
insert into Category(title) values('Pretend play')
insert into Category(title) values('Prisms')
insert into Category(title) values('Puppets')
insert into Category(title) values('Puzzles')
insert into Category(title) values('Ride-on')
insert into Category(title) values('Role play')
insert into Category(title) values('Science')
insert into Category(title) values('Sensory')
insert into Category(title) values('Singing')
insert into Category(title) values('Soft sounds')
insert into Category(title) values('Space')
insert into Category(title) values('Stacking')
insert into Category(title) values('Taking turns')
insert into Category(title) values('Tents')
insert into Category(title) values('Texture')
insert into Category(title) values('Threading')
insert into Category(title) values('Trains')
insert into Category(title) values('Trucks')
insert into Category(title) values('Vehicles')
insert into Category(title) values('Walking')
insert into Category(title) values('Water play')
insert into Category(title) values('Water play')
insert into Category(title) values('Words')

SELECT * FROM Category

DBCC CHECKIDENT ('[Disability]', RESEED, 0);

delete from Disability
where title >'';


insert into Disability(title) values('ADHD')
insert into Disability(title) values('ASD - Autism spectrum disorder')
insert into Disability(title) values('Asthma ')
insert into Disability(title) values('Blind ')
insert into Disability(title) values('Cerebral palsy ')
insert into Disability(title) values('Cystic fibrosis')
insert into Disability(title) values('Deaf')
insert into Disability(title) values('Developmental delay')
insert into Disability(title) values('Down syndrome')
insert into Disability(title) values('Dyslexia')
insert into Disability(title) values('Epilepsy')
insert into Disability(title) values('Traumatic brain injury')
insert into Disability(title) values('Intellectual disability')
insert into Disability(title) values('Multiple Sclerosis (MS)')
insert into Disability(title) values('Muscular Dystrophy')
insert into Disability(title) values('Paraplegia')
insert into Disability(title) values('Parkinson disease, ')
insert into Disability(title) values('Physical disability')
insert into Disability(title) values('Quadriplegia ')

SELECT * FROM Disability


insert into Child(fname, lname, iwi, DOB, gender, note, childLanguage) VALUES('Thomas', 'Louden', 'yes', '2011-06-15', 'male', 'poor eye sight', 'Chinese')
insert into Child(fname, lname, iwi, DOB, gender, note, childLanguage) VALUES('Keith', 'Daxter', 'no', '2010-08-06', 'male', 'paraplegic', 'Arabic')
insert into Child(fname, lname, iwi, DOB, gender, note, childLanguage) VALUES('Hannah', 'Schmiere', 'no', '2009-03-29', 'female', 'anxiet disorder', 'English')
insert into Child(fname, lname, iwi, DOB, gender, note, childLanguage) VALUES('Gavin', 'Ward', 'yes', '2014-09-10', 'non-binary', 'has ADHD', 'English')
insert into Child(fname, lname, iwi, DOB, gender, note, childLanguage) VALUES('Emily', 'Schmiere', 'no', '2015-12-13', 'female', 'autistic', 'English')

SELECT * FROM Child


insert into Membership (loginPassword, loginName) values('20110615', 'thomasL')
insert into Membership (loginPassword, loginName) values('20100806', 'keithD')
insert into Membership (loginPassword, loginName) values('20090329', 'hannahS')
insert into Membership (loginPassword, loginName) values('1', '1')

select * from Membership

delete from Membership
where loginPassword ='hannahS';

insert into Toy(name, toyDescription, libraryLocation, parts, toyStatus, toyType)values('Beary', 'a stuffed teddy bear', 'Hamilton', 'whole toy', 'lended', 'Teddy Bear')
insert into Toy(name, toyDescription, libraryLocation, parts, toyStatus, toyType)values('Monstrum', 'a monster car that makes a sound when moved', 'Hamilton', 'whole toy', 'available','Monster Car')
insert into Toy(name, toyDescription, libraryLocation, parts, toyStatus, toyType)values('Dolly', 'a dolly that cries when a button is pushed', 'Hamilton', 'whole toy', 'lended','Crying Doll')
insert into Toy(name, toyDescription, libraryLocation, parts, toyStatus, toyType)values('T-Rex', 'a stuffed dinosour toy', 'Hamilton', 'whole toy', 'available','Dinosaur')
insert into Toy(name, toyDescription, libraryLocation, parts, toyStatus, toyType)values('Dumbo', 'a stuffed animal', 'Hamilton', 'whole toy', 'available','Elephant')

select * from Toy

delete from Toy
where libraryLocation ='Hamilton';

DBCC CHECKIDENT ('[Toy]', RESEED, 0);