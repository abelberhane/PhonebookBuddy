# Phonebook Buddy

Phonebook developed in C# to store Contact Information. It is simple so far and I have always wanted to make a phonebook so this is great practice working with databases. I have always read about CRUD Operations and have only had the opportunity to work with them once or twice. This was a project that was spent over a lot of different sessions and troubleshooting was actually exciting. 

Things that I have learned during this project
1) Working with Drop downs
2) Setting the Tab Index
3) How to determine which textbox you'd like the app to focus on at Runtime
4) A LOT about the SQL Server Configuration Manager and SQL connection troubleshooting
5) Error 40:  could not open a connection to sql server
6) Working with Services.msc
7) How to have a Data Grid populate at Run Time
8) How to have a Data Grid populate the text fields of the app
9) Deleting from a Database
10) Updating from a Database
11) Searching through a Database

Updated - 

I added the ability to search and look for your mobile contacts by number. This method followed the Display function and I manipulated the SQL query to search by using %. 

![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/NumberSH.png?raw=true)
![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/SearchSH.png?raw=true)

--------------------------------------------------------------------------------------------------------
Updated - 

I was able to get everything working and I am happy with the results. I have some ideas in regards to what I would love to add on to next. I am going to add a Search bar as well to allow easy sifting of searching through my Phonebook Buddy. 

![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/Screenshots/DoneSH.png?raw=true)
![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/Screenshots/GridSH.png?raw=true)
---------------------------------------------------------------------------------------------------------

Updated - 

Pulling up the code on my work computer I was able to test the project and do some digging a bit more. Once I opened it and went to the 
server explorer, I added the connection and created the new phonebook database with no problem. I have added a screenshot below. I will continue to work on this when I have the free time now that I now I can create the tables and continue. 

![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/Screenshots/WorkingSH.png?raw=true)

When I search services.msc on my computer, the recommended tip is to look for the instance of sql server, turn it off and then on. It actually does not show up for me and I will have to reinstall SQL Server entirely in my home computer and see if I can get the full suite installed this time around with all of the components. 

---------------------------------------------------------------------------------------------------------

Previous Bugs - 

Currently running into SQL connectivity error 40 which means
it cannot establish a connection. I have some screenshots below of the error message that pops up. 

![alt text](https://github.com/abelberhane/PhonebookBuddy/blob/master/Images/Screenshots/Error40SH.png?raw=true)
