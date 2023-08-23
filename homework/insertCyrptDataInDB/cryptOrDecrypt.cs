using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace homework.insertCryptDataInDB;

public class XOR
{
    public string crypter(string word)
    {
        char pass = 'a';
        string result = string.Empty;
        for (int i = 0; i < word.Length; i++)
        {
            result += ((char)(word[i] ^ pass)).ToString();
        }
        return result;
    }
}