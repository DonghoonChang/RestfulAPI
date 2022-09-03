namespace RestfulAPI.Domain.Common;

/*
 * https://programmingwithmosh.com/net/why-i-dont-like-ientity-interfaces/
 * This interface unused in the project and only left as an bad example with known symptoms
 */
public interface IEntity<T>
{
    public T Id { get; set; }
}
