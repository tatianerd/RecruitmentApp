create table Questions(
	QuestionId int identity(1,1) not null primary key,
	QuestionDescription varchar(250) not null,
	Created date not null,
	ImageUrl varchar(150) not null,
	ThumbnailUrl varchar(150) not null
)

insert into Questions values ('Whats your favourite programming language?', GETDATE(), 'https://dummyimage.com/600x400/000/fff.png&text=question+1+image+', 'https://dummyimage.com/600x400/000/fff.png&text=question+1+image+')

insert into Questions values ('What programming language do you work with?', GETDATE(), 'https://dummyimage.com/600x400/000/fff.png&text=question+1+image+', 'https://dummyimage.com/600x400/000/fff.png&text=question+1+image+')

create table Choices(
	ChoiceId int identity (1,1) not null primary key,
	ChoiceDescription varchar (50) not null unique,
	Created date not null
)

insert into Choices values ('Swift', GETDATE())
insert into Choices values ('C#', GETDATE())
insert into Choices values ('JavaScript', GETDATE())
insert into Choices values ('Java', GETDATE())
insert into Choices values ('R', GETDATE())
insert into Choices values ('Golang', GETDATE())
insert into Choices values ('Objective-C', GETDATE())

create table Answers(
	AnswerId int identity(1,1) not null primary key,
	QuestionId int not null,
	ChoiceId int not null,
	VoteCount int not null,
	LastUpdated date not null,
	CONSTRAINT FK_QuestionId FOREIGN KEY (QuestionId)
    REFERENCES Questions(QuestionId),
	CONSTRAINT FK_ChoiceId FOREIGN KEY (ChoiceId)
    REFERENCES Choices(ChoiceId)
)

insert into Answers values (1, 1, 50, GETDATE())
insert into Answers values (2, 1, 92, GETDATE())
insert into Answers values (1, 3, 89, GETDATE())
insert into Answers values (2, 6, 105, GETDATE())


/*select q.QuestionDescription as Question, c.ChoiceDescription as Choice, a.VoteCount as Votes from Answers a
inner join Choices c on c.ChoiceId = a.ChoiceId
inner join Questions q on q.QuestionId = a.QuestionId*/

