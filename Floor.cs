class Floor : GameObject
{
    public Floor()
    {
        shape = ' ';
    }
    public Floor(int newX, int newY) // 오버로드 
    {
        shape = ' ';
        x = newX;
        y = newY;
    }

    ~Floor()
    {

    }

    public override void Start()
    {

    }

    public override void Update()
    {

    }

    public override void Render()
    {
        // base.Render();
    }


}
