namespace CSharpChallenges.LeetCode.Medium.WalkingRobotSimulation2
{
    /// <summary>
    /// Task: Walking Robot Simulation II (LeetCode #2069)
    /// URL: https://leetcode.com/problems/walking-robot-simulation-ii/description/?envType=daily-question&envId=2026-04-07
    /// Complexity: Time O(1) for all methods. Space O(1).
    /// </summary>
    public class Robot // WalkingRobotSimulation2Solution
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int _perimeter;

        private int _currentPos;

        public Robot(int width, int height)
        {
            _width = width;
            _height = height;
            // Roboot porusza się po obwodzie: 2*szerokość + 2*wysokość - 4 rogi
            _perimeter = 2 * (width - 1) + 2 * (height - 1);
            _currentPos = 0;
        }

        public void Step(int num)
        {
            _currentPos = (_currentPos + num) % _perimeter;

            if (_currentPos == 0 && num > 0)
            {
                _currentPos = _perimeter;
            }
        }

        public int[] GetPos()
        {
            int p = _currentPos;

            if (p == 0 || p == _perimeter) return [0, 0];

            // Dolna krawędź
            if (p <= _width - 1) return [p, 0];
            p -= (_width - 1);

            // Prawa krawędź
            if (p <= _height - 1) return [_width - 1, p];
            p -= (_height - 1);

            // Górna krawędź
            if (p <= _width - 1) return [_width - 1 - p, _height - 1];
            p -= (_width - 1);

            // Lewa krawędź
            return [0, _height - 1 - p];
        }

        public string GetDir()
        {
            if (_currentPos == 0) return "East"; // Stan początkowy

            // Jeśli jesteśmy na dolnej krawędzi
            if (_currentPos <= _width - 1) return "East";
            // Jeśli jesteśmy na prawej krawędzi
            if (_currentPos <= (_width - 1) + (_height - 1)) return "North";
            // Jeśli jesteśmy na górnej krawędzi
            if (_currentPos <= 2 * (_width - 1) + (_height - 1)) return "West";
            // Jeśli jesteśmy na lewej krawędzi (lub wróciliśmy na start)
            return "South";
        }
    }

    /// <summary>
    /// Task: Walking Robot Simulation II (LeetCode #2069)
    /// URL: https://leetcode.com/problems/walking-robot-simulation-ii/description/?envType=daily-question&envId=2026-04-07
    /// Complexity: Time O(n) for Step(), O(1) for other methods. Space O(1).
    /// </summary>
    public class Robot1 // WalkingRobotSimulation2Solution
    {
        private int _positionX;
        private int _positionY;
        private int _direction;

        private (int x, int y) _plane;
        readonly (int x, int y)[] _directions = [
            (0, 1),     // North 
            (1, 0),     // East
            (0, -1),    // South
            (-1, 0)     // West
        ];

        public Robot1(int width, int height)
        {
            _plane = (width - 1, height - 1);
            _positionX = 0;
            _positionY = 0;
            _direction = 1;
        }

        public void Step(int num)
        {
            for (int step = 0; step < num; step++)
            {
                int nextX = _positionX + _directions[_direction].x;
                int nextY = _positionY + _directions[_direction].y;

                // Sprawdzamy czy nowa pozycja wyjdzie poza plansze
                if (nextX > _plane.x || nextX < 0 || nextY > _plane.y || nextY < 0)
                {
                    _direction = (_direction + 3) % 4;
                    step--;
                    continue;
                }

                _positionX = nextX;
                _positionY = nextY;
            }
        }

        public int[] GetPos()
        {
            return [_positionX, _positionY];
        }

        public string GetDir()
        {
            return _direction switch
            {
                0 => "North",
                1 => "East",
                2 => "South",
                3 => "West",
                _ => string.Empty,
            };
        }
    }
}
