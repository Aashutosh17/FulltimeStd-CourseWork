# Full-Time Student Application

## Overview
This project is a simple application that models a full-time student system. It demonstrates object-oriented programming concepts such as inheritance and polymorphism by creating classes for undergraduate students, graduate students, and PhD students. The goal of this application is to loop through a collection of `FullTimeStudent` objects and perform specific actions based on the type of student (e.g., calculating grades for undergraduates and displaying thesis titles for graduate students).

## Classes

### FullTimeStudent
- This is the base class for all student types (undergraduate, graduate, and PhD).
- It contains common properties and methods shared across all student types.

### UGStudent
- A subclass of `FullTimeStudent` that represents an undergraduate student.
- This class implements a method called `ComputeGrade` to calculate and return the final grade.

### GradStudent
- A subclass of `FullTimeStudent` that represents a graduate student.
- This class includes a property called `Thesis` which stores the title of the student's thesis.

### PhDStudent
- A subclass of `FullTimeStudent` (not explicitly mentioned in the task, but can be added for completeness).
- This class may contain properties specific to PhD students, such as research topics or dissertation titles.

## Functionality
The application stores `UGStudent` and `GradStudent` objects in an `ArrayList`. It then loops through the list and checks the type of each student. If the student is an undergraduate, the application will compute and display the grade using the `ComputeGrade` method. If the student is a graduate, the thesis title will be displayed.

## Code Example

### Button Handler or Load Form Code

```csharp
FullTimeStudent ft = new GStudent();  // Example of initializing a FullTimeStudent object as a Graduate Student

ArrayList AList = new ArrayList();    // Creating an ArrayList to store FullTimeStudent objects

UGStudent ug1 = new UGStudent();     // Create an undergraduate student object
AList.Add(ug1);                      // Add undergraduate student to the list

GStudent gt = new GStudent();        // Create a graduate student object
AList.Add(gt);                       // Add graduate student to the list

// Loop through the ArrayList and perform actions based on the student type
foreach (FullTimeStudent ft in AList)
{
    if (ft is UGStudent)             // If the student is an undergraduate
    {
        MBox.Show(ft.ComputeGrade());  // Show the final grade of the undergraduate student
    }
    else if (ft is GStudent)         // If the student is a graduate student
    {
        GStudent gs = (GStudent)ft;  // Cast the object to GStudent
        MBox.Show(gs.Thesis);        // Show the thesis title of the graduate student
    }
}
