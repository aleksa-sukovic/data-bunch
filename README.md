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

<img src="https://drive.google.com/uc?export=view&id=189YH20KauxopnRp3hxO_nFyeEw7Q2o-8" width="600">

<img src="https://drive.google.com/uc?export=view&id=1dY4Cf4C3DxkmQnBWr4O8mZIDKhEyRESY" width="600">

<img src="https://drive.google.com/uc?export=view&id=1zaCRzx_qw-B0j5OYgj0kvAkN1WgQAVjW" width="600">

<img src="https://drive.google.com/uc?export=view&id=1bmTXipg38cffkaWFwai6EbEBlq7bRFFc" width="600">

<img src="https://drive.google.com/uc?export=view&id=1jexaarM70qAWVWcVq9FWYhNojU1z92RC" width="600">

<img src="https://drive.google.com/uc?export=view&id=1OzeX_eKiTR_QxnPHCTJY39F0i0kI8G0o" width="600">
