using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTouchKeyboard.Configuration
{
    public class ConfigurationManager
    {
        private readonly string _confFilename;
        private KeyboardLayoutsSettings _settings;

        public ConfigurationManager(string confFilename)
        {
            _confFilename = confFilename;
            LoadSettings();
        }

        public KeyboardLayoutsSettings Settings
        {
            get
            {
                return _settings;
            }
            
        }

        public void LoadSettings()
        {
            var json = File.ReadAllText(_confFilename);
            _settings = JsonConvert.DeserializeObject<KeyboardLayoutsSettings>(json);

            
        }
    }
}
