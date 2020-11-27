using System;
using System.Collections.Generic;
using Prism.Commands;
using XfbContainer.CommonTypes.Extensions;

namespace XfbContainer.WpfDomain.Commands
{
    public class ApplicationCommands : IApplicationCommands
    {
        private readonly Dictionary<string, CompositeCommand> _saveCommands;

        public ApplicationCommands()
        {
            _saveCommands = new Dictionary<string, CompositeCommand>();
        }

        public CompositeCommand GetSaveCommandByKey(string key)
        {
            key.VerifyReference(nameof(key), nameof(ApplicationCommands));

            if (_saveCommands.ContainsKey(key))
            {
                return _saveCommands[key];
            }

            throw new InvalidOperationException("Command not found.");
        }

        public void CreateSaveCommand(string key)
        {
            key.VerifyReference(nameof(key), nameof(ApplicationCommands));

            if (!_saveCommands.ContainsKey(key))
            {
                _saveCommands.Add(key, new CompositeCommand());
            }
        }
    }
}
