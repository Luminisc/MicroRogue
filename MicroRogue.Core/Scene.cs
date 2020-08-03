namespace MicroRogue.Core
{
    public class Scene
    {
        public int Width;
        public int Height;

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool CanMove(int newX, int newY)
        {
            if (newX >= Width || newX < 0)
                return false;
            if (newY >= Height || newY < 0)
                return false;

            return true;
        }
    }
}