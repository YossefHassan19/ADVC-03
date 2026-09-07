namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager

            //Exercise 1: Student Grade Manager

            //1- Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new List<int>{ 85, 92, 78, 95, 88, 70, 100, 65 };

            //2- Print the collection, Count, first and last grade
            //Console.WriteLine("Grades:");
            //foreach (int grade in grades) 
            //    Console.WriteLine(grade);
            //Console.WriteLine();
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");

            //3- Sort the grades ascending, then print
            //grades.Sort();
            //Console.WriteLine("Grades (Sorted):");
            //foreach (int grade in grades)
            //    Console.WriteLine(grade);

            //4- Get the first grade above 90
            //int firstGradeAbove90 = grades.Find(grade => grade > 90);
            //Console.WriteLine($"First Grade Above 90: {firstGradeAbove90}");

            //5- Get all grades below 75(failing grades)
            //Console.WriteLine("all grades below 75(failing grades):");
            //List<int> gradeBelow75 = grades.FindAll(grades => grades < 75);
            //foreach (int grade in gradeBelow75)
            //    Console.WriteLine(grade);

            //6- Remove all failing grades (below 75)
            //grades.RemoveAll(grades => grades < 75);
            //foreach (int grade in grades)
            //    Console.WriteLine(grade);

            //7- Check if any grade equals 100
            //bool hasGrade100 = grades.Contains(100);
            //Console.WriteLine(hasGrade100);

            //8- Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeStrings = new List<string>();
            //foreach (int grade in grades)
            //    gradeStrings.Add($"Grade: {grade}");
            //foreach (string strings in gradeStrings)
            //    Console.WriteLine(strings);

            #endregion

            #region Exercise 2: Leaderboard

            //Exercise 2: Leaderboard

            //1- Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //Dictionary<int, string> entries = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};

            //2- Print all entries (they should be sorted by score automatically)
            //foreach (var entery in entries)
            //    Console.WriteLine($"{entery.Key} -> {entery.Value}");

            //3- Access the first key and first value 
            //var firstKey= entries.First().Key;
            //var firstValue = entries.First().Value;
            //Console.WriteLine($"First Key: {firstKey}, First Value: {firstValue}");

            //4- Check if score 500 exists
            //bool hasScore500 = entries.ContainsKey(500);
            //Console.WriteLine($"Has Score 500: {hasScore500}");

            //5- Safely get the player with score 999
            //entries.TryGetValue(999, out string? value);
            //Console.WriteLine(value);

            //6- Remove the player with score 200 and print the updated list
            //entries.Remove(200);
            //foreach (var entery in entries)
            //    Console.WriteLine(entery);

            #endregion

            #region Exercise 3: Phone Book

            //Exercise 3: Phone Book

            //Create a Collection  with 4 contacts (name → phone number)
            //Dictionary<string, int> phoneBook = new()
            //{
            //    ["Ahmed"] = 500,
            //    ["Sara"] = 200,
            //    ["Ali"] = 800,
            //    ["Mona"] = 350
            //};

            //2- Add a new contact using [] syntax (add or update)
            //phoneBook["Yossef"] = 900;

            //3- Try adding a duplicate using .Add() — catch the exception and print the error
            //phoneBook.Add("Yossef", 900);

            //4- Try adding a duplicate using .TryAdd() — print whether it succeeded
            //phoneBook.TryAdd("Yossef", 900);
            //foreach (var contact in phoneBook)
            //    Console.WriteLine($"{contact.Key} -> {contact.Value}");

            //5- Search for a contact that doesn’t exist
            //bool hasContact = phoneBook.ContainsKey("Osama");
            //Console.WriteLine(hasContact);

            //6- Get a contact with a fallback of "Not Found"
            //var contact = phoneBook.GetValueOrDefault("Not Found", 853);
            //Console.WriteLine($"\nGetValueOrDefault for 'Not Found' with fallback: {contact}");3

            //7- Print all Keys on one line, then all Values on another line
            //foreach (var contact in phoneBook)
            //{
            //    Console.Write($"{contact.Key} ");
            //}
            //Console.WriteLine();
            //foreach (var contact in phoneBook)
            //{
            //    Console.Write($"{contact.Value} ");
            //}

            #endregion

            #region Exercise 4: Unique Email Validator

            //Exercise 4: Unique Email Validator

            //1- Create a HashSet<string> with a case-insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //2- Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //3- Print Count — how many are actually stored? Explain why.
            //Console.WriteLine(emails.Count());
            //Count is 2 because HashSet is case-insensitive

            //4-Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //5-Print the result of: UnionWith, IntersectWith, ExceptWith

            //1. UnionWith
            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.Union(setB);
            //foreach (int union in unionSet)
            //    Console.WriteLine(union);

            //2. IntersectWith
            //HashSet<int> intersectSet = new HashSet<int>(setA);
            //intersectSet.IntersectWith(setB);
            //foreach (int intersect in intersectSet)
            //    Console.WriteLine(intersect);

            //3. ExceptWith
            //HashSet<int> exceptSet = new HashSet<int>(setA);
            //exceptSet.ExceptWith(setB);
            //foreach (int except in exceptSet)
            //    Console.WriteLine(except);

            //6- Use IsSubsetOf to check if {1,2} is a subset of Set A
            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //bool isSubset = subset.IsSubsetOf(setA);
            //Console.WriteLine(isSubset);

            #endregion

        }
    }
}
