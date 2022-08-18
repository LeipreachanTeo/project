Console.Write("ВВедите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}