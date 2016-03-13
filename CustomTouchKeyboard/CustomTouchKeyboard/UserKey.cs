namespace CustomTouchKeyboard
{
    internal class UserKey
    {


        public UserKey(string label, string keys)
        {
            this.Label = label;
            this.Keys = keys;
        }

        public string Keys { get; internal set; }
        public string Label { get; internal set; }
    }
}