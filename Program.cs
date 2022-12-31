using System.Text;
List<string> alphabet = new List<string>();
var str = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя ";
for (int i = 0; i < str.Length; i++)
{
    alphabet.Add(str[i].ToString());
}
Console.WriteLine("Введите шифруемое слово");
var toEncrypt = Console.ReadLine().ToCharArray();
Console.WriteLine("Введите длину сдвига для шифра Цезаря");
var offset = int.Parse(Console.ReadLine());
string result = "";
for (int i = 0; i < toEncrypt.Length; i++)
{
    result += alphabet[(alphabet.IndexOf(toEncrypt[i].ToString()) + offset) % alphabet.Count].ToString();
}
Console.WriteLine("Зашифрованный результат:");
Console.WriteLine(result);
toEncrypt = result.ToCharArray();
result = "";
for (int i = 0; i < toEncrypt.Length; i++)
{
    result += alphabet[(alphabet.IndexOf(toEncrypt[i].ToString()) - offset + alphabet.Count) % alphabet.Count].ToString();
}
Console.WriteLine("Дешифрованный результат:");
Console.WriteLine(result);
Console.ReadKey();
