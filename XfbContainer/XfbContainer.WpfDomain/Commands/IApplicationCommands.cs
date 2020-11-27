using Prism.Commands;

namespace XfbContainer.WpfDomain.Commands
{
    public interface IApplicationCommands
    {
        CompositeCommand GetSaveCommandByKey(string key);
        void CreateSaveCommand(string key);
    }
}
