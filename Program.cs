// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "    Maria";

firstFriend = firstFriend.Trim();

string secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";  // This is called string interpolation

Console.WriteLine(friends.StartsWith("My "));
