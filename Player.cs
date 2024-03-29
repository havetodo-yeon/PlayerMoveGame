﻿class Player : GameObject
{
    public Player()
    {
        shape = 'P';
    }

    public Player(int newX, int newY) // 오버로드 
    {
        shape = 'P';
        x = newX;
        y = newY;
    }

    ~Player()
    {

    }

    public override void Start()
    {

    }

    public override void Update()
    {
        if (Input.GetButton("Left"))
        {
            x--;
        }
        if (Input.GetButton("Right"))
        {
            x++;
        }
        if (Input.GetButton("Up"))
        {
            y--;
        }
        if (Input.GetButton("Down"))
        {
            y++;
        }

/*        if (Input.GetButton("Quit"))
        {
            // singleton pattern
            // engine.Stop();
        }
*/
        x = Math.Clamp (x, 1, 8);
        y = Math.Clamp (y, 1, 8);
    }
    /*
        public override void Render()
        {
            base.Render();

        }
    */
}
