

using Domain.Entity;
using Web.DTO;

namespace Web.Converters
{
    public class codeDtoToCrypto : cryptData
    {
        public static cryptData toCrypto(CryptDataDto cryptoDto)
        {
            cryptData cryptData = new cryptData();
            cryptData.data = cryptoDto.word;
            cryptData.crept();
            return cryptData;
        }
    }
}
