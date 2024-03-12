using System.Data;
class Engine
{
    public Engine()
    {
        gameObjects = new List<GameObject>();
        isRunning = true;
    }

    ~Engine()
    {

    }

    public List<GameObject> gameObjects;
    public bool isRunning;

    public void Init()  // file load
    {
        Input.Init();
    }
    public void LoadScene(string SceneName)
    {
        // data file 이 bin\Debug\net8.0에 있으면 이렇게 써도 됨 그러나 git으로 관리 못함
        // string[] map = File.ReadAllLines("./data/level01.map"); 
#if DEBUG
        string Dir = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
        string[] map = File.ReadAllLines(Dir + "/data/" + SceneName);    // string을 배열로 불러옴
#else
        string Dir = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
        string[] map = File.ReadAllLines(Dir + "/data/" + SceneName);    // string을 배열로 불러옴
#endif

        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
            {
                if (map[y][x] == '*')
                {
                    Instantiate(new Wall(x, y));    // GameObject newGameObject = Instantiate(new Wall(x, y));
                    Instantiate(new Floor(x, y));
                    //newGameObject.x = x;
                    //newGameObject.y = y;
                }
                else if (map[y][x] == ' ')
                {
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == 'P')
                {
                    Instantiate(new Player(x, y)); 
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == 'G')
                {
                    Instantiate(new Goal(x, y));
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == 'M')
                {
                    Instantiate(new Monster(x, y));
                    Instantiate(new Floor(x, y));
                }
            }
        }

        // Load();
        // gameObjects.Sort();  // Objects sorting
    }


    public void Run()
    {
        while (isRunning)
        {
            ProcessInput();
            Update();
            Render();
        }   // frame
    }

    public void Term()
    {
        gameObjects.Clear();
    }

    public GameObject Instantiate(GameObject newGameObject)
    {
        gameObjects.Add(newGameObject);
        return newGameObject;
    }

    protected void ProcessInput()
    {
        Input.keyInfo = Console.ReadKey();
    }

    protected void Update() // All of GameObject Update
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.Update();
        }
    }

    protected void Render()
    {
/*        // all game object
        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].Render();
        }
*/
        Console.Clear();
        foreach (GameObject gameObject in gameObjects)   // Generic Collections
        {
            gameObject.Render();
        }
    }

}