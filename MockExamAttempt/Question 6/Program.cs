string solutionPath = @"C:\Users\796433.ADIR\Source\Repos\MMukhtar1885\Lab-Work\MockExamAttempt\Question 6\dogOwners.txt";

string[] fileContent = File.ReadAllLines(solutionPath);

char[] delimiterChars = { '[', ']', ':', ','};


for (int i = 0; i < fileContent.Length - 1; i++)
{

 string[] words = fileContent[i].Split(delimiterChars);

    for (int j = 3; j <= words.Length - 1 ; j = j+2 )
     {
        Console.WriteLine(words[j]);
    }


}

