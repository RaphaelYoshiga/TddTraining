using System.Threading.Tasks;

namespace TddTraining.Users
{
    public interface IUserRetriever
    {
        Task<ExternalServiceUser> GetBy(int id);
    }
}
