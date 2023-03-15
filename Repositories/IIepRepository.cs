using NewHireTask.Entities;

    public interface IIepRepository
    {
        Iep GetIep(Guid id);
        IEnumerable<Iep> GetIeps();
    }

void DeleteIep(Guid id);
