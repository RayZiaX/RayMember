DROP DATABASE IF EXISTS `RayMember_data`;
CREATE DATABASE IF NOT EXISTS `RayMember_data`;

USE `RayMember_data`;


DROP TABLE IF EXISTS `Customers`;
CREATE TABLE `Customers`(
   customer_id INT AUTO_INCREMENT ,
   customer_userName VARCHAR(50) NOT NULL UNIQUE,
   customer_password VARCHAR (200) NOT NULL UNIQUE,
   customer_email VARCHAR(50) NOT NULL UNIQUE,
   customer_nationality VARCHAR(50) NOT NULL,
   customer_gender VARCHAR(50) NOT NULL,
   PRIMARY KEY(customer_id)
);
DROP TABLE IF EXISTS `Accounts`;
CREATE TABLE `Accounts`(
   account_id INT AUTO_INCREMENT,
   account_type VARCHAR(50) NOT NULL,
   account_userName VARCHAR(50) NOT NULL,
   account_password VARCHAR (255) NOT NULL,
   account_email VARCHAR(50) NOT NULL,
   account_tag VARCHAR(5),
   account_Q1 VARCHAR(255),
   account_Q2 VARCHAR(255),
   account_Q3 VARCHAR(255),
   account_answer1 VARCHAR(50),
   account_answer2 VARCHAR(50),
   account_answer3 VARCHAR(50),
   customer_id INT NOT NULL,
   PRIMARY KEY(account_id),
   FOREIGN KEY(customer_id) REFERENCES Customers(customer_id)
);
