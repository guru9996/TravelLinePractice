using Domain.Entity;
using Domain.Repositories;


namespace Infrastucture;
internal class cryptDataRepository: CryptRepository
{
    private readonly ApplicationContext _context;

    public cryptDataRepository( ApplicationContext context )
    {
        _context = context;
    }

    public void AddData(cryptData data)
    {
        _context.Data.Add(data);
    }

    public List<cryptData> GetData()
    {
        return _context.Data.ToList();
    }
}
