using Encapsulation;

User user = new User();
Console.WriteLine(user.HasDigit(Console.ReadLine()));

User user0 = new User();
Console.WriteLine(user0.HasUpper(Console.ReadLine()));

User user1 = new User();
Console.WriteLine(user1.HasLower(Console.ReadLine()));

User user2 = new()
{
    username = "nicatorucovbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb",
    password = "nicat223"
};
Console.WriteLine($"{user2.username}  {user2.password}");