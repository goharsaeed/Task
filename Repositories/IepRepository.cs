using NewHireTask.Entities;

namespace NewHireTask.Repositories
{
    
    public class IepRepository : IIepRepository
    {
        private readonly List<Iep> ieps = new()
        {
            new Iep { Id= Guid.NewGuid(), Active= true, StartDate= DateTimeOffset.UtcNow, StudentNumber= 12121},
            new Iep { Id= Guid.NewGuid(), Active= false, StartDate= DateTimeOffset.UtcNow, StudentNumber= 12121},
            new Iep { Id= Guid.NewGuid(), Active= true, StartDate= DateTimeOffset.UtcNow, StudentNumber= 21212},

        };

        public IEnumerable<Iep> GetIeps()
        {
            return ieps;
        }

        public Iep GetIep(Guid id)
        {
            return ieps.Where(iep => iep.Id == id).SingleOrDefault();
        }
        //for delete
        public void DeleteIep(Guid id)
        {
             var iep = GetIep(id);
             ieps.Remove(iep);
        }

    }
}