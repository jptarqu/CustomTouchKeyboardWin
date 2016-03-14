namespace CustomTouchKeyboard
{
    public class UserKey
    {


        public UserKey()
        {
        }

        public UserKey(string label, string keys, int x, int y, int width, int height)
        {
            Keys = keys;
            Label = label;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Keys { get; set; }
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsShift { get; set; }
        public bool IsCapsLock { get; set; }
    }
}