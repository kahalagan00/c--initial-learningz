// Switch Statement LEARNING
/*
var preHistoricFish = "Cockerelitte";

var result = preHistoricFish switch {
  "Heliobatis" => "Heliobatis found!",
  "Cockerelitte" => "Cockerelitte found!",
  _ => "Nothing found!"
};

Console.WriteLine(result);

// Old school way of using a switch statement
// switch (preHistoricFish) { 
//   case "Heliobatis":
//     Console.WriteLine("Heliobatis found!");
//     break;
  
//   case "Cockerelitte":
//     Console.WriteLine("Cockerelitte found!");
//     break;

//   default:
//     Console.WriteLine("Nothing found!");
//     break;
// }

*/


// While Loop LEARNING
/*
using System.Net.NetworkInformation;

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

// Re pings 8.8.8.8 every 10 seconds
while (PR.Status.ToString() == "Success") {
  Console.WriteLine(PR.Status.ToString() + "!");
  PR = p1.Send("8.8.8.8");
  Console.WriteLine("Waiting ten seconds for next request");
  Thread.Sleep(10000); // ms
}

Console.WriteLine("God please help me!");
*/

// Class LEARNINGS
/*
using ConsoleApp;

Rat wolfRat = new Rat();
Rat fancyRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioActive = false;

fancyRat.Name = "Fancy Rat";
fancyRat.Number = 500;
fancyRat.IsRadioActive = false;

// READ
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// UPDATE
wolfRat.Name = "WOLFY RATO";
fancyRat.Name = "FANCY RATA";
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// DELETE
wolfRat.Name = "";
fancyRat.Name = "";
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

*/

// Methods LEARNING
/*
using ConsoleApp;
RealEstate elmStreet = new("Elm Street");
elmStreet.Address = "Main Street";
*/


// Tuple LEARNINGS
/*
var values = ("t", 2, "p");
var valuesWithName = (First: "t", Second: 2, Third: "p");
Console.WriteLine(valuesWithName.Second);
*/

// Null LEARNINGS
/*
int? value = null;
string? value2 = null;

if (value2 is not null) {
  Console.WriteLine(value2.Length);
}

Console.WriteLine(value2 ?? "No value(x)");
Console.WriteLine(value2 is not null ? "Has Value(y)" : "No Value(y)");
*/

// Static LEARNINGS
/*
SavingsAccount savingsAccount = new();
TimeUtility.PrintTime();
*/


// List LEARNINGS
/*
// Create
List<int> nums = [1, 2, 3, 4, 5, 6];

// Read
// foreach (int x in nums) {
//   Console.WriteLine(x);
// }

// Update
nums.Add(0);
nums.Insert(2, 69);
// foreach (int x in nums) {
//   Console.WriteLine(x);
// }

// Delete
nums.RemoveAt(0);
foreach (int x in nums) {
  Console.WriteLine(x);
}
*/

// Record LEARNINGS 
/*
Person person1 = new("Teddy", "Smith");
Person person2 = new("Teddy", "Smith");

// Shallow Immutability
// person1.LastName = "smith";
// person1.PhoneNumbers[0] = "222-2222";

// Equality
// Value: Type, Contents
// Referential: By memory (hex code)
Console.WriteLine(person1 == person2);

// Non-destructive mutation 
Person person3 = person2 with { LastName = "Brewskie"};
Console.WriteLine(person3.ToString());

public record Person(string FirstName, string LastName);
*/


// Delegates LEARNINGS
var loggerAction = () => {
  System.Console.WriteLine("This is a simple");
};

Func<int,int> loggerFunc = (int x) => {
  return x + 2;
};

var list = Enumerable.Range(1, 10).Select(i => i * 3).ToList();

public delegate int SuperCustom(int x);
















