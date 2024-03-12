class Wall : GameObject
{
/*    public Wall()   // 디폴트생성자
    {
        shape = '*';
    }

*/
    public Wall(int newX = 0, int newY = 0) // 오버로드 
    {
        shape = '*';
        x = newX;
        y = newY;
    }

    ~Wall()
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
        base.Render();
    }


}
