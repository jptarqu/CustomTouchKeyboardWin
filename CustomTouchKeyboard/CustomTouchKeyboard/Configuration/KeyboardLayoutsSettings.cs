using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTouchKeyboard.Configuration
{
    public class KeyboardLayoutsSettings
    {
        public IEnumerable<KeyboardLayout> MainKeyboards { get; set; }
        public IEnumerable<KeyboardLayout> SnippetsKeyboards { get; set; }
    }
}
