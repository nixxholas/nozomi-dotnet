namespace Nozomi.net.Entities.Interfaces
{
    /// <summary>
    /// Interface that identifies entities returned by Nozomi that have an `object` attribute.
    /// </summary>
    public interface IHasObject
    {
        /// <summary>
        /// Stri1ng representing the object's type. Objects of the same type share the same value.
        /// </summary>
        string Object { get; set; }
    }
    
}