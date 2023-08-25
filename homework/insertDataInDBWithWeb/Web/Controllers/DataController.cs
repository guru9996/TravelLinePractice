using Domain;
using Domain.Entity;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.Converters;
using Web.DTO;

namespace Web.Controllers;
[ApiController]
[Route( "[controller]" )]
public class DataController : ControllerBase
{

    private readonly CryptRepository _dataRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DataController(CryptRepository dataRepository, IUnitOfWork unitOfWork)
    {
        _dataRepository = dataRepository;
        _unitOfWork = unitOfWork;
    }


    [HttpGet(Name = "GetCrypto")]
    public IEnumerable<cryptData> Get()
    {
        return _dataRepository.GetData();

    }


    [HttpPost("GetCrypto")]
    public string GetByID(DTOtoDecrypt dectyptDTO)
    {
        return _dataRepository.GetData().Single(x => x.Id == dectyptDTO.Id).data;
    }


    [HttpPost( Name = "SaveData" )]
    public IActionResult SaveData( CryptDataDto dataDto )
    {
        cryptData cryptData = codeDtoToCrypto.toCrypto(dataDto);
        _dataRepository.AddData(cryptData);
        _unitOfWork.Commit();

        return new OkResult();
    }
}
