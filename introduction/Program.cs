string[] username = { "max", "glezel", "barben" };
string[] password = { "xam", "power1", "power2" };

Console.WriteLine("Login:");
string login = Console.ReadLine();
Console.WriteLine("password:");
string passwords = Console.ReadLine();

bool isFound = false;

for (int i = 0; i < username.Length; i++)
{
    if (login == username[i] && passwords == password[i])
    {
        isFound = true;
        Console.WriteLine("Login: " + username[i]);
        break;
    }
}
if (!isFound) Console.WriteLine("No account match found!");




