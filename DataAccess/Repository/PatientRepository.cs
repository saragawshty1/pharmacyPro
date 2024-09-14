using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class PatientRepository :Repository<Patient>, IPatientRepository
    {
        private readonly ApplicationDBContext context;
        public PatientRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
