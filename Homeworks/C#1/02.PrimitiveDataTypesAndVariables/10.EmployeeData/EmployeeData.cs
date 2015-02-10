using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Adrian";
        string lastName = "Apostolov";
        byte age = 23;
        string gender = "Male";
        long personaIdNumber = 9102280000;
        int uniqueEmployeeNumber = 27568947;

        Console.WriteLine(@"
Employee:           {0} {1}
Age:                {2}
Gender:             {3}
Personal ID:        {4}
Employee Number:    {5}
", firstName, lastName, age, gender, personaIdNumber, uniqueEmployeeNumber );

    }
}

