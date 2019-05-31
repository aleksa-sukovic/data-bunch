# Data Bunch
Data bunch is data warehouse management system. It provides basic utilities for creating and managing files, which are organized in collections. This project was done as an assignment task for my "Programming Lanugages" college course.

## Features
Main idea is managing and organizing documents

* Documents are represented by using a structure called Collection
* Documents that belong to a certain Collection must be of same type

Given a Collection we can do the following operations:

1. Add document (s)
2. Delete document (s)
3. Merge (given another Collection merge all of its content to existing and create new merged Collection)
4. Export (creating RAR file from given Collection)
5. A particular Collection can be initialliy empty, can be loaded from RAR file or specific folder on disk

Collection is hiearhically ordered and can be collection of other Collections (of same type)

In system there are users which can be:

1. Administrators
2. Regular Users

All users have the following:

* Username
* Name
* Password
* Age
* List of Collections that particular user has at his disposal to work with

Administrators have the following privileges:

* Managing of all users (CRUD)
* Managing of all Collections (CRUD)
* According to user type we have permissions. Only administrators have unguarded permissions to the entre system.

A particular user who is not administrator, has permission to every Collection he created. Additionally a permission can be granted by administrator to regular user on any particular Collection.

* If permission is granted for particular Collection for given user, than that user has permissions for all nested Collection (childrens of main Collection)

## Images

![Collections List](https://api.pcloud.com/getpubthumb?code=XZ2CGU7ZC9VxtlrSHE7ICQWgc83N0msG0jkX&linkpassword=undefined&size=550x450&crop=0&type=auto)

![Collection Details](https://api.pcloud.com/getpubthumb?code=XZlCGU7Z7ilk1D17vRLPn1h7IyLhbyoTHAI7&linkpassword=undefined&size=550x450&crop=0&type=auto)

![File Details](https://api.pcloud.com/getpubthumb?code=XZcCGU7ZS8Ux1fA56lQ1qR43it7ty8bOKwLV&linkpassword=undefined&size=550x450&crop=0&type=auto)

![Profile Details](https://api.pcloud.com/getpubthumb?code=XZFxGU7ZnhRzIViWogyJLu914KTwj5ioQQHk&linkpassword=undefined&size=550x450&crop=0&type=auto)

![Profile Edit](https://api.pcloud.com/getpubthumb?code=XZfxGU7ZTfOdIP6RL1QQ57uie7klt5Qdg6xy&linkpassword=undefined&size=550x450&crop=0&type=auto)

![Login](https://api.pcloud.com/getpubthumb?code=XZ1xGU7ZVl0qOfafJlJmcVadPt8BIFwS5Sv7&linkpassword=undefined&size=550x450&crop=0&type=auto)
