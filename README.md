# C# Object-Oriented Programming Project – JSON & XML Data Handling

##  Student: Aayusha Kattel  
## Lecturer: Donatas Dervinis  
##  Vilnius University – Šiauliai Academy  

---

## Project Overview

This project demonstrates working with **Object-Oriented Programming in C#** using:
- JSON file handling
- XML file reading
- Inheritance and polymorphism
- Data deserialization
- Console output
- Version control with Git

## Implemented Features

###  Version 1: Manual JSON File Creation
- Created a basic JSON file manually containing a sample `User` object.

###  Version 2: Deserialization of Single Object
- Read the JSON file and deserialized a single object using `Newtonsoft.Json`.

### Version 3: Creating Specialized `user_types`
- Created `Admin` and `GeneralUser` classes inheriting from the `User` class.
- Demonstrated polymorphic behavior.

### Version 4: Adding Multiple Entries to JSON
- Created a list of users (of different types).
- Saved them to a JSON file.

###  Version 5: Deserializing All Entries
- Read all entries from the JSON file using a loop.
- Printed each user's data to the console.

###  Version 6: New JSON File with `user_types`
- Created a separate JSON file for objects using inherited classes (`Admin`, `GeneralUser`).
- Deserialized and displayed them on the console.

###  Version 7: XML Reader (Theory & Example)
- Added a brief explanation of `XmlReader`.
- Included example code for parsing XML elements.

---

## Sample Output (Screenshots)

> _Include screenshots in the test report PDF_

---

##  Testing

See [Test Report PDF](./TestReport.pdf) for:
- Features tested
- Screenshots

---

## Technologies Used

- C# (.NET Core Console App)
- Newtonsoft.Json (JSON.NET)
- System.Xml (for XML parsing)
- Visual Studio
- Git bash & GitHub

---
