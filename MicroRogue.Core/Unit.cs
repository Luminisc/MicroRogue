namespace MicroRogue.Core
{
    public class Unit
    {
        public string Icon;
        public int X;
        public int Y;

        public Unit(int x = 0, int y = 0, string icon = "◯")
        {
            X = x;
            Y = y;
            Icon = icon;
        }

        public void MoveUp(Scene scene)
        {
            if (scene.CanMove(X, Y - 1))
                Y--;
        }

        public void MoveDown(Scene scene)
        {
            if (scene.CanMove(X, Y + 1))
                Y++;
        }

        public void MoveLeft(Scene scene)
        {
            if (scene.CanMove(X - 1, Y))
                X--;
        }

        public void MoveRight(Scene scene)
        {
            if (scene.CanMove(X + 1, Y))
                X++;
        }
    }
}