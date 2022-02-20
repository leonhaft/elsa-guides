
using Microsoft.EntityFrameworkCore;

public class PartNumberService : IPartNumberService
{
    private WorkflowGuideDbContext _dbContext;

    public PartNumberService(WorkflowGuideDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Category>> CategoriesAsync()
    {
        var categories = await _dbContext.Categories.ToListAsync();

        return categories;
    }

    public async Task<PartNumberDto> StartPartNumberApplyAsync(PartNumberDto partNumberDto)
    {
        //throw new NotImplementedException();
        var categories = await _dbContext.Categories.ToListAsync();
        return partNumberDto;
    }
}

