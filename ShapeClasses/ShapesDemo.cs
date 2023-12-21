namespace ShapeClasses
{
    public class ShapesDemo
    {
        public static void Execute()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Triangle());
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            var rectangle = new Rectangle();
            rectangle.Draw();
        }

    }
}
