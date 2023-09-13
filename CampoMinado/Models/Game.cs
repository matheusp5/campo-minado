namespace CampoMinado.Models
{
    public class Game
    {
        public Game(int height, int width)
        {
            Height = height;
            Width = width;
            Bombs = GenerateBombs(height, width);
            Flags = new List<Flag>();
            Points = new List<Point>();
            StartedTime = DateTime.Now;
        }
        public bool IsBomb(int x, int y) => Bombs.Any(b => b.x == x && b.y == y);
        public bool IsWinner() => Points.Count == Height * Width - Bombs.Count; 
        public int GetBombsAround(int x, int y)
        {
            int count = 0;
            if(IsBomb(x-1, y)) count++;
            if(IsBomb(x+ 1, y)) count++;
            if(IsBomb(x, y+1)) count++;
            if(IsBomb(x, y-1)) count++;
            if(IsBomb(x-1, y-1)) count++;
            if(IsBomb(x+1, y+1)) count++;
            if(IsBomb(x+1, y-1)) count++;
            if(IsBomb(x-1, y+1)) count++;
            return count;
        }
        public void SetPoint(int x, int y) {
            Points.Add(new Point() {x = x, y = y});
        }
        public void SetFlag(int x, int y)
        {
            if(!Points.Any(p => p.x == x - 1 && p.y == y - 1))
            Points.Add(new Point() { x = x, y = y });
        }
        public List<Bomb> GenerateBombs(int h, int w)
        {
            Random rand = new Random();
            List<Bomb> bombs = new List<Bomb>();

            int blocks = h * w;
            double multiplier = 1.3;
            int bombsNumber = (int)(blocks / 4 * multiplier);

            for(int i = 0; i < bombsNumber; i++)
            {
                int x = rand.Next(1, w);
                int y = rand.Next(1, h);
                bool bombExists = bombs.FirstOrDefault(b => b.x == y && b.y == y) == null;
                if(bombExists)
                {
                    Bomb bomb = new Bomb(x, y);
                    bombs.Add(bomb);
                }
            }

            return bombs;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public List<Bomb> Bombs { get; set; }
        public List<Point> Points { get; set; }
        public List<Flag> Flags { get; set; }
        public DateTime StartedTime { get; set; }
    }
}
