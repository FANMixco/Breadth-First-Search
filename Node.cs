namespace Algorithms
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int DistanceFromSource { get; set; }

        public Node(int x, int y, int dis)
        {
            X = x;
            Y = y;
            DistanceFromSource = dis;
        }
    }
}