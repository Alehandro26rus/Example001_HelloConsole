Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + username);
}
