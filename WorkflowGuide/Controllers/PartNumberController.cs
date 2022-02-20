using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PartNumberController : ControllerBase
{
    private IPartNumberService _partNumberService;

    public PartNumberController(IPartNumberService partNumberService)
    {
        this._partNumberService = partNumberService;
    }

    [HttpPost]
    public async Task<PartNumberDto> CreatePartNumber(PartNumberDto pn)
    {
        var dto = await _partNumberService.StartPartNumberApplyAsync(pn);

        return dto;
    }
}
