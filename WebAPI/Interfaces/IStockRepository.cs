using WebAPI.Dtos.Stock;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock> UpdateAsync(int id, UpdateStockRequestDto updateDto);
        Task<Stock> DeleteAsync(int id);

    }
}
