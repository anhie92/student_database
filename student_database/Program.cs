string[] studentNames = new string[] { "anh", "brad", "britney", "chad", "christina", "craig" };
string[] studentHomeTowns = new string[] { "Detroit", "WestLand", "Los Angeles", "Chicago", "Kansas City", "Orlando" };
string[] favoriteFood = new string[] { "steak", "spaghetti", "ice cream", "chicken parmasean", "chicken alfredo", "sushi" };


//MAIN PROGRAM
void StudentDataBase()
{
    bool tryAgain;
    while (true)
    {
        DisplayStudentNames();
        Console.WriteLine("Please enter Y or Yes to search for a student by name");
        string byName = Console.ReadLine().ToLower();
        if (byName == "y" || byName == "yes")
        {
            KnowNameOfStudent();
        }
        else
        {
            StudentByNumber();
        }
        tryAgain = BreakLoop();
        if (!tryAgain)
        { break; }
    }
}
//METHOD TO DISPLAY STUDENT NAMES
void DisplayStudentNames()
{
    int studentCount = 0;
    Console.WriteLine("Please enter Y or Yes to see the students in class");
    string seeStudents = Console.ReadLine().ToLower();
    if (seeStudents == "y" || seeStudents == "yes")
    {
        for (int i = 0; i < studentNames.Length; i++)
        {
            studentCount++;
            Console.WriteLine($"{studentCount}. {studentNames[i]}");
        }
    }
}

//METHOD TO CHECK IF RANGE IS WITHIN ARRAY
bool WithinRange(int index, string[] array)
{
    return (index >= 0) && (index < array.Length);
}


//METHOD TO BREAK LOOP
bool BreakLoop()
{
    Console.WriteLine("Would you like to learn about another student? please enter Yes or Y continue");
    string tryAgain = Console.ReadLine();
    if (tryAgain.ToLower() != "yes" && tryAgain.ToLower() != "y")
    {
        Console.WriteLine("Goodbye!");
        return false;
    }
    else
    {
        return true;
    }
}

//METHOD TO SEARCH FOR STUDENT BY NAME
void KnowNameOfStudent()
{
    while (true)
    {
        Console.WriteLine("Please enter the name of the student you would like to know about");
        string nameOfStudent = Console.ReadLine();
        int studentNumber = Array.FindIndex(studentNames, row => row.Contains(nameOfStudent));
        bool withinRange = WithinRange(studentNumber, studentNames);

        if (withinRange)
        {
            Console.WriteLine($"Would you like to know {studentNames[studentNumber]}'s favorite food or hometown?");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "favorite food" || userInput == "food")
            {
                Console.WriteLine($"{studentNames[studentNumber]}'s favorite food is {favoriteFood[studentNumber]}.");
            }
            else if (userInput == "hometown" || userInput == "home")
            {
                Console.WriteLine($"{studentNames[studentNumber]}'s hometown is {studentHomeTowns[studentNumber]}.");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("invalid input please try again");
                    Console.WriteLine("please enter either food or home");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "favorite food" || userInput == "food")
                    {
                        Console.WriteLine($"{studentNames[studentNumber]}'s favorite food is {favoriteFood[studentNumber]}.");
                        { break; }

                    }
                    else if (userInput == "hometown" || userInput == "home")
                    {
                        Console.WriteLine($"{studentNames[studentNumber]}'s home town is {studentHomeTowns[studentNumber]}.");
                        { break; }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("That student is not in this class.");
        }
    }
}


//METHOD TO DISPLAY STUDENT BY INDEX
void StudentByNumber()
{
    while (true)
    {
        Console.WriteLine("Please enter a number between 1 and 6 to learn about a student");
        int studentNumber;
        bool isValid = int.TryParse(Console.ReadLine(), out studentNumber);
        studentNumber = studentNumber - 1;
        bool withinRange = WithinRange(studentNumber, studentNames);

        if (isValid && withinRange)
        {
            Console.WriteLine($"the student you selected is {studentNames[studentNumber]}.");
            Console.WriteLine($"Would you like to know {studentNames[studentNumber]}'s favorite food or hometown?");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "favorite food" || userInput == "food")
            {
                Console.WriteLine($"{studentNames[studentNumber]}'s favorite food is {favoriteFood[studentNumber]}.");
            }
            else if (userInput == "hometown" || userInput == "home")
            {
                Console.WriteLine($"{studentNames[studentNumber]}'s hometown is {studentHomeTowns[studentNumber]}.");

            }
            else
            {
                while (true)
                {
                    Console.WriteLine("invalid input please try again");
                    Console.WriteLine("please enter either food or home");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "favorite food" || userInput == "food")
                    {
                        Console.WriteLine($"{studentNames[studentNumber]}'s favorite food is {favoriteFood[studentNumber]}.");
                        { break; }

                    }
                    else if (userInput == "hometown" || userInput == "home")
                    {
                        Console.WriteLine($"{studentNames[studentNumber]}'s home town is {studentHomeTowns[studentNumber]}.");

                        { break; }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("You had a Invalid entry please try again");
        }
    }
}


StudentDataBase();
