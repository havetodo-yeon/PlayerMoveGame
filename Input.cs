class Input
{
    public Input()
    {

    }

    ~Input() 
    {
        
    }

    public struct KeyList
    {
        public KeyList(ConsoleKey newButton, ConsoleKey newAltButton)
        {
            button = newButton;
            altButton = newAltButton;
        }
        public ConsoleKey button;
        public ConsoleKey altButton;
    }


    public static void Init()
    {
        //editor 설정
        InputMapping["Up"] = ConsoleKey.W;
        InputMapping["Down"] = ConsoleKey.S;
        InputMapping["Left"] = ConsoleKey.A;
        InputMapping["Right"] = ConsoleKey.D;
    }

    public static Dictionary<string, ConsoleKey> InputMapping = new Dictionary<string, ConsoleKey>();

    public static ConsoleKeyInfo keyInfo;  // key input

    public static bool GetKey(ConsoleKey CheckKeyCode)
    {
        return (keyInfo.Key == CheckKeyCode);
    }
    public static bool GetButton(string buttonName)
    {
        return (InputMapping[buttonName] == keyInfo.Key);
    }
}
