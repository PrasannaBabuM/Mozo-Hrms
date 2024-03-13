using SmartH2RCore.Core.EFContext;

namespace SmartH2RCore.Core.Factory
{
    public interface IContextFactory
    {
        IDatabaseContext DbContext { get; }
    }
}