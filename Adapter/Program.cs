using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>() {
                                            new LineAdapter(new LegacyLine()),
                                            new RectangleAdapter(new LegacyRectangle())
                                            };
            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;
            shapes.ForEach(shape => shape.Draw(x1, y1, x2, y2));
        }
    }

    internal class LegacyRectangle
    {
        public void Draw(int x1, int y1, int w, int h)
        {
            Console.WriteLine($"Drawing rectangle {x1} {y1} {w} {h}");
        }
    }

    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle legacyRectangle;

        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            this.legacyRectangle = legacyRectangle;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);
            legacyRectangle.Draw(x1, y1, w, h);
        }
    }

    internal class LegacyLine
    {
        public void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Drawing Line {x1} {y1} {x2} {y2}");
        }
    }

    internal class LineAdapter : IShape
    {
        private readonly LegacyLine legacyLine;

        public LineAdapter(LegacyLine legacyLine)
        {
            this.legacyLine = legacyLine;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            legacyLine.Draw(x1, y1, x2, y2);
        }
    }

    internal interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }
}
