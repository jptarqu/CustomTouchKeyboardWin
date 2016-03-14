using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTouchKeyboard
{
    public class KeyboardLayout
    {
        public IEnumerable<UserKey> Keys { get; set; }
        public string Name { get; set; }
    }
}
