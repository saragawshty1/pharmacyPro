using DataAccess ;
using Models;
using DataAccess.Repository.IRepository;
 

namespace DataAccess.Repository
{
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        private readonly ApplicationDBContext context;

        public DeviceRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
