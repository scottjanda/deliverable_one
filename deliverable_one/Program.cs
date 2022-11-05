// See https://aka.ms/new-console-template for more information


int sandwich_slice = 2;
int sandwich_peanut_butter = 2;
int sandwich_jelly = 4;
int loaf = 28;
int jar_peanut_butter = 32;
int jar_jelly = 48;
string large_bread_unit;
string answer;

do { 

    Console.Write("How many people are we making PB and J sandwiches for? ");
    int people = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("You need:");
    Console.WriteLine();

    //need to output in additonal step here

    int total_sandwich_slice = (people * sandwich_slice);
    Console.WriteLine("\t" + total_sandwich_slice + " slices of bread!");

    int total_sandwich_peanut_butter = (people * sandwich_peanut_butter);
    Console.WriteLine("\t" + total_sandwich_peanut_butter + " table spoon(s) of peanut butter!");

    int total_sandwich_jelly = (people * sandwich_jelly);
    Console.WriteLine("\t" + total_sandwich_jelly + " tea spoons(s) of jelly!");

    Console.WriteLine();
    Console.WriteLine("\tWhich is...");
    Console.WriteLine();

    int total_loaf = (int)Math.Ceiling((double)total_sandwich_slice / loaf);
    if (total_loaf == 1) { large_bread_unit = "loaf"; } else large_bread_unit = "loves";
    Console.WriteLine("\t" + total_loaf + " " + large_bread_unit + " of bread!");

    int total_peanut_butter = (int)Math.Ceiling((double)total_sandwich_peanut_butter / jar_peanut_butter);
    Console.WriteLine("\t" + total_peanut_butter + " jar(s) of peanut butter!");

    int total_jelly = (int)Math.Ceiling((double)total_sandwich_jelly / jar_jelly);
    Console.WriteLine("\t" + total_jelly + " jar(s) of jelly!");

    Console.WriteLine();
    Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit. ");
    answer = Console.ReadLine();

}

while (answer == "yes" || answer == "y");

Console.WriteLine();
Console.Write("Goodbye!");
Console.WriteLine();