using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Repositories;
public interface CryptRepository
{
    void AddData( cryptData Data );
    List<cryptData> GetData();


}
