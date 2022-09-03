Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
    Console.WriteLine ("Ура это Masha");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}