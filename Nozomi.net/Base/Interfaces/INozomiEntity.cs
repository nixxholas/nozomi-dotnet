namespace Nozomi.net.Base.Interfaces
{
    /// <summary>
    /// Interface that identifies all entities returned by Nozomi.
    /// </summary>
    public interface INozomiEntity
    {
        NozomiResponse NozomiResponse { get; set; }
    }
}