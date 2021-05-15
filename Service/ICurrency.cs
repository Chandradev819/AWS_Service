using System.Threading.Tasks;

namespace AWS_Service.Service
{
    public interface ICurrency
    {
        public Task<object> GetConveryValue(string fsym, string tsyms);
    }
}
