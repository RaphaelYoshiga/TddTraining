using System.Threading.Tasks;

namespace TddTraining.Users
{
    public interface ILocalUserRetriever
    {
        Task<UserResponse> GetBy(int id);
    }
}
