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

        }
    }
}
