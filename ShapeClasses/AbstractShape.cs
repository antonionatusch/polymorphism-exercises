namespace ShapeClasses
{
    public abstract class AbstractShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copiar la forma al portapapeles.");
        }

        public void Select()
        {
            Console.WriteLine("Seleccionar la forma.");
        }
    }
}
