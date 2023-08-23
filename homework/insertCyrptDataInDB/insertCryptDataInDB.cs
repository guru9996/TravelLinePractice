using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace homework.insertCryptDataInDB;



internal class insertCryptDataInDB
{
    static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var XOR = new XOR();

            cryptData cryptData = new cryptData();

            Console.WriteLine("Write data, that you want to crypt");
            string? word = Console.ReadLine();
            string? cryptdata = XOR.crypter(word);
            cryptData.data = cryptdata;

            db.Data.Add(cryptData);
            db.SaveChanges();

            Console.WriteLine("Objects succesfully saved!");
            List<cryptData> data = db.Data.ToList();

            foreach (cryptData u in data)
            {
                Console.WriteLine($"{u.Id}.{u.data}");
            }

            Console.WriteLine("Write data id, that you want to get");
            int id = int.Parse(Console.ReadLine());

            if (id > 0 && id <= cryptData.Id)
            {
                cryptData element = db.Data.Single(x => x.Id == id);
                Console.WriteLine($"Crypted Data : {XOR.crypter(element.data)}");;
            }
            else
            {
                Console.WriteLine("There is n");
            }
        }

    }
}