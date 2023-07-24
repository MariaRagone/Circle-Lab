//Package for using ArrayList
using System.Collections;
using System.Threading.Channels;

//Generics <3
//List
List<decimal> prices = new List<decimal>();
//adding stuff to the list
prices.Add(1.99m); //add m to let it know it is a decimal
                   //without the m c# thinks it is a double
prices.Add(2.99m);
prices.Add(5.00m);
prices.Insert(0,3.99m);//0 is the index to target, 3.99m is the value to insert

foreach(decimal p in prices) 
{
    Console.WriteLine(p);//prints the entire list
}
Console.WriteLine(prices[1]); //this works like a normal array - prints 2.99
Console.WriteLine(prices.Count); //prints how many objects are in the array

int index = prices.IndexOf(2.99m); //this looks for 2.99m in the list, if it doesn't find then it returns -1
prices[index] = 2.50m;//changes the first index variable to 2.50m
prices.Remove(5.00m);//removes the first instance of the object of 5.00m
prices.RemoveAt(0);//removes values based off of the index
foreach (decimal p in prices)
{
    Console.WriteLine(p);
}

//Create list with starting values
//another way to initialize a list
List<string> shows = new List<string>()
    {
    "Spongebob",
    "Breaking Bad",
    "The Price is Right"
    };
foreach (string s in shows)
{
Console.WriteLine(s);

}

//Dictionaries
Dictionary<string, bool> tasty = new Dictionary<string, bool>(); //tasty is a collection
tasty.Add("Chicken Curry", true);
tasty.Add("Asparagus", false);

Console.WriteLine(tasty["Chicken Curry"]); //inside [] is the key
foreach (KeyValuePair<string, bool> kvp in tasty)
{
    if (kvp.Value == true)
    { 
        Console.WriteLine($"{kvp.Key} is tasty!");
    }
    else 
    {
        Console.WriteLine($"{kvp.Key} is nasty!");
    }
}


//---------------------------------------------
//EXERCISES
//1. Create a list of strings
//  create loop after list
//  ask the user to enter text
//  add the input into the list
//  display all in list
//  ask if they want to add more

//create list

List<string> colors = new List<string>();
while (true)
{
    Console.WriteLine("Add a color.");
    string color = Console.ReadLine().ToLower().Trim();
    //adding stuff to the list
    colors.Add(color); 
    Console.WriteLine(); //add a blank return line
    Console.WriteLine($"Here is the list of colors:");//prints once before the list of colors
    foreach (string p in colors)
    {
        Console.WriteLine(p);//prints the entire list of colors
    }
    Console.WriteLine("Do you want to add more? y/n");
    string answer = Console.ReadLine().ToLower().Trim();
    if (answer == "n")
    {
        break;
    }
    
}


//2. Create a dictionary called translate
//  key = string (English)
// value = string (Spanish)
// add 5 or more words to translate
// ask the user for an english word
// display the translation (value)

//create a dictionary
Dictionary<string, string> translate = new Dictionary<string, string>();
translate.Add("grandmother", "abuela");
translate.Add("butterfly", "mariposa");
translate.Add("tiger", "tigre");
translate.Add("name", "nombre");
translate.Add("brother is", "hermano");

while (true)
{

    //ask user for an English word
    Console.WriteLine("Enter an English word.");
    string english = Console.ReadLine().ToLower().Trim();
    if (translate.ContainsKey(english)) 
    { 
        //translate the word to Spanish
        Console.WriteLine($"The Spanish translation is: {translate[english]}"); //inside [] is the key
    }
    else
    {
        Console.WriteLine("Word not found");
    }

    
    Console.WriteLine("Do you want to translate again? y/n");
    string answer = Console.ReadLine().ToLower().Trim();
    if (answer == "n")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if (answer == "y")
    {
        continue;
    }
}


























































//-----------------------------------------------------------
//Non-Generics
//Do not use or else Justin will fight
//allow anything to go in or out without any restrictions

//ArrayList

//ArrayList trashList = new ArrayList();
//trashList.Add(2);//pass in any type of object
//trashList.Add(9);
//trashList.Add(new Random());
//trashList.Add(new ArrayList());
//foreach (var x in trashList) //var = any data type
//{
//    Console.WriteLine(x);
//}

////Hashtable
//Hashtable trashTable = new Hashtable();
//trashTable.Add("Taco Bell", 123456789); //number
//trashTable.Add("McDonalds", "123456789"); //string
//Console.WriteLine(trashTable["Taco Bell"]);//supply with key, prints the value back (taco bell's number)