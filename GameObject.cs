class GameObject
{
    public int x;
    public int y;

    public GameObject()
    {
        x = 0;
        y = 0;
    }

    public GameObject(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    ~GameObject()
    {

    }

    public virtual void Start()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void Render()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(shape);
    }

    public char shape;

}

/*class GameObject
{
    public int x;
    public int y;

    public GameObject()
    {
        x = 0;
        y = 0;
    }
    public GameObject(int newX, int newY) // 오버로드 
    {
        x = newX;
        y = newY;
    }


    ~GameObject()
    {

    }

    public virtual void Start()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void Render()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(shape);
    }

    public char shape;

}
*/
/*class GameObject
{
    public int x;
    public int y;
    public char shape;

    GameObject()
    {
        x = 0; 
        y = 0;
    }

    ~GameObject()   // 객체지향에 필요한 것
    {

    }

    public virtual void Start() // 자식이 재정의 할 수 있으니 설계 단계에서 virtuals
    {

    }

    public virtual void Update()
    {

    }

    public virtual void Render()
    {

    }

    public void Input()
    {

    }


}
*/