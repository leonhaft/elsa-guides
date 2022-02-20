
public interface IPartNumberService
{
    Task<List<Category>> CategoriesAsync();

    Task<PartNumberDto> StartPartNumberApplyAsync(PartNumberDto partNumberDto);
}

