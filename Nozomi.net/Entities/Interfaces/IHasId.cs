namespace Nozomi.net.Entities.Interfaces
{
    /// <summary>
    /// Interface that identifies entities returned by Nozomi that have an `id` attribute.
    /// </summary>
    public interface IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        string Id { get; set; }
    }
}