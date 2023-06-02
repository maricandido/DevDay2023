namespace DevDay23.Domain.Interfaces
{
    public interface IStudent
    {
        void Add(Aluno aluno);
        void Update(Aluno aluno);
        void Delete(Aluno aluno);
        IEnumerable<Aluno> GetAll();
    }
}
