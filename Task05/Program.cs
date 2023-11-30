Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "meri") //не читает русские букы, только английские
{
    Console.WriteLine("Ура! Это же MERI!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}