-------------------------------------------------------------------------------------------------------------------------------------------------------------
COMPANY TRADING DATABASE
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Created by Irfan Hanafi, 17098640
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Executable can be found in bin/Release
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Completed:
-------------------------------------------------------------------------------------------------------------------------------------------------------------
File Browser through GUI
1. Load Text Data File
2. Manually Edit Company Information
3. Display the Number of Companies within the three and the depth
4. Remove a Company 
5. Display all Companies in Alphabetic Order
6. a)Search for a Company
6. b)Partial Keyword Search
7. Search for and Display Trading Partners
8. Display the Company with biggest Potential for Trade

-------------------------------------------------------------------------------------------------------------------------------------------------------------
Evidence:
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Object-Oriented Design:
- Companies, Trees and CSVReader

Working Implementation:
- 1-8 fully functional with minor bugs(listed below in Known Bugs)

Usability of GUI:
- Can be used to do 1-8
- Will prompt the user on certain invalid actions (Edit cannot be made, File Could not be Read, Company not found)

Efficiency of Search Algorithms:
AVLTree:
- CompanyTree is initalized with AVLTree and are balanced (Tree Height is 12 with BS and 6 with AVL)
- Results for fast searching when using Search and Partial Search(Due to the balancing of the trees)

BSTree:
- Added GetNode : Gets specific node
- Added EditNode : Edits Nodes and replaces with a similar node with adjusted properties
- Added GetAll : Gets All Nodes within a tree

Refactored Code:
- Changes to Companies, CSVReader and Trees should not majorly affect the program's functionality due to OO-Design

-------------------------------------------------------------------------------------------------------------------------------------------------------------
Extra Features:
-------------------------------------------------------------------------------------------------------------------------------------------------------------
1. Companies and Buyers can be selected by clicking on them
2. Can select CSV files through a File Browser

Known Bugs:
-------------------------------------------------------------------------------------------------------------------------------------------------------------
1. For removing a company, specific companies will continue to stay in the ListView used to display the companies.
- However, the companies are actually removed the trees.

Notes:
-------------------------------------------------------------------------------------------------------------------------------------------------------------
1. Companies can be displayed alphabetically by using InOrder method but due to me using a ListView, 
   I've used ListView's sorting methods to sort the companies
