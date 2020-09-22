using System.Threading.Tasks;

namespace TddTraining.Users
{
    public interface IUserPersister
    {
        Task UserPersister(ExternalServiceUser externalServiceUser);
    }
}
