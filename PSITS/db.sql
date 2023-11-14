create database DBSYS

use DBSYS

--changes 3/11/2023

--added events table
--added misc table
--added payment form
--edit the UI for students
--displayed events and misc table using datagrid

--changes 4/11/2023

--started design in PSITS form
--added event add form
--added misc add form
--added check student status form
--start design in admin form

--Creates the Event Table
CREATE TABLE [Events] (
eventId integer IDENTITY(1,1) primary key,
eventName varchar (50) not null,
);

--Creates the user account table
CREATE TABLE UserAccount (
userId integer IDENTITY(1,1) primary key,
userName varchar (50) not null,
userPassword varchar (50) not null,
roleId int,
userStatus varchar (10) not NULL default 'ACTIVE',
);
--To view the user account table

--Creates the user information table
CREATE TABLE UserInformation (
userInfoId integer IDENTITY(1,1) primary key,
userInfLname varchar (50) not null,
userInfFname varchar (50) not null,
userInfAddress varchar (50) not null default 'No Address',
userInfEmail varchar not null,
userId integer,
FOREIGN KEY (userId) REFERENCES UserAccount(userId)
);

CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [DBSYS]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Student', N'Student ')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Teacher', N'Teacher')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
