using WebApplication1.DomainServices;

namespace WebApplication1.Infrastructure
{
    public class DummyValuesRepository : IValuesRepository
    {
        public int GetValue()
        {
            return 56;
        }
    }
}
