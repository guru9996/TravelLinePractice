using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace Domain.Entity;


public class cryptData
{
    public int Id { get; set; }

    public string? data { get; set; }
    public string? cryptedWord { get; set; }


    public string crypter(string data)
    {
        char pass = 'a';
        string res = string.Empty;
        for (int i = 0; i < data.Length; i++)
        {
            res += ((char)(data[i] ^ pass)).ToString();
        }
        if(cryptedWord == null)
        {
            cryptedWord = res;
        }
        return res;

    }

    public string crept()
    {
        return crypter(data);
    }

}