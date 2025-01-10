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




