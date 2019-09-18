namespace Entities.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T Entity);
    }
}
