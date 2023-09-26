using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
    Breakfast GetBreakfast(Guid id);

    Breakfast UpsertBreakfast(Guid id,UpsertBreakfastRequest request);
}
