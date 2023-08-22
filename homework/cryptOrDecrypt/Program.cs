using System;

namespace homework.cryptOrDecrypt;

public class XOR
{
    private string reptKey(string str, int length)
    {
        string tempStr = str;
        while (tempStr.Length < length)
        {
            tempStr += tempStr;
        }
        return tempStr.Substring(0, length);
    }

    public string crypter(string word, string secKey)
    {
        string curKey = reptKey(secKey, word.Length);
        string result = string.Empty;
        for (int i = 0; i < word.Length; i++)
        {
            result += ((char)(word[i] ^ curKey[i])).ToString();
        }
        return result;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        var XOR = new XOR();
        Console.WriteLine("текст");
        string? word = Console.ReadLine();
        Console.WriteLine("пароль: ");
        string? password = Console.ReadLine();
        string? cryptedWord = XOR.crypter(word, password);
        Console.WriteLine(cryptedWord);
        Console.WriteLine(XOR.crypter(cryptedWord, password));
    }
}