# _Hair Salon_

#### _A Webapp that allows user to store names of clients and stylists in a database, July 13, 2018_

#### By _**Nick Rogers**_

## Description

_This webapp was created to allow users to store names of clients and stylists in a database._
_Specs:_
1. _Let user store names of stylists and retrieve the list from the database._
  - _Example Input: "Jack"_
  - _Example Output: [id 0, "Jack"]_
2. _Let user view details on the stylist in a separate page._
  - _Example Input: user clicks on details page for Jack_
  - _Example Output: user redirected to a uniquely generated page on Jack._
3. _Let user store names of clients for each stylist that are linked by an id._
  - _Example Input: user stores "Nancy" as a client under "Jack"._
  - _Example Output: Nancy saved as a client under stylist id 0._
4. _Let user view a list of clients under the details page of each stylist._
  - _Example Input: user navigates to Jack details page._
  - _Example Output: user sees Nancy and only other clients of Jack._
5. _Let user view a list of specialties that a stylist can perform.
  - _Example Input: user enters "buzz cut" as a specialty.
  - _Example Output: user sees "buzz cut" in the list of specialties.
6. _Let user add specialties to many stylists._
  - _Example Input: user links "buzz cut" to Jack._
  - _Example Output: user sees that Jack in the list of stylists under "buzz cut"._
7. _Let user add stylists to many specialties._
  - _Example Input: user links Jack to "mullet".
  - _Example Output: user sees Jack can do "mullet" hairstyles.
## Setup/Installation Requirements

* _Clone repository and open with mono_
* _To create the database:_

  _In MySQL:_

  \> CREATE DATABASE `nick_rogers`;  
  \> USE `nick_rogers`;  
  \> CREATE TABLE `stylists` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255));  
  \> CREATE TABLE `clients` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255), `Stylist_Id` INT);
  \> CREATE TABLE `specialties` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255));
  \> CREATE TABLE `stylists_specialties` ( `Id` serial PRIMARY KEY, `stylists_id` INT, `specialties_id` INT);
  \> CREATE DATABASE `nick_rogers_test`;  
  \> USE `nick_rogers_test`;  
  \> CREATE TABLE `stylists` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255));  
  \> CREATE TABLE `clients` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255), `Stylist_Id` INT);
  \> CREATE TABLE `specialties` ( `Id` serial PRIMARY KEY, `Name` VARCHAR(255));
  \> CREATE TABLE `stylists_specialties` ( `Id` serial PRIMARY KEY, `stylists_id` INT, `specialties_id` INT);

## Known Bugs

_No known bugs._

## Support and contact details

_Nick Rogers email: amellocello@msn.com_

## Technologies Used

_Created with Atom editor.  Use mono to view. Use PHPMyAdmin Database to store information._

### License

*No license required*

Copyright (c) 2018 **_Nick Rogers_**
