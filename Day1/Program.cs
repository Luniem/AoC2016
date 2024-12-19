string input = @"/home/nico/projects/AoC2016/Day1/input.txt";

string[] instructions = File.ReadAllText(input).Split(", ");

Direction direction = Direction.North;
int x = 0;
int y = 0;

HashSet<(int, int)> visited = new HashSet<(int, int)>();
visited.Add((x,y));

int secondSolution = 0;


foreach(string inst in instructions) {
    char turn = inst[0];
    int distance = int.Parse(inst.Substring(1));

    if(turn == 'R') {
        direction = (Direction)(((int)direction + 1) % 4);
    } else {
        direction = (Direction)(((int)direction + 3) % 4);
    }

    for (int i = 0; i < distance; i++) {
        switch (direction) {
            case Direction.North:
                y++;
                break;
            case Direction.East:
                x++;
                break;
            case Direction.South:
                y--;
                break;
            case Direction.West:
                x--;
                break;
        }

        if(visited.Contains((x, y)) && secondSolution == 0) {
            secondSolution = Math.Abs(x) + Math.Abs(y);
        } else {
            visited.Add((x, y));
        }
    }
}

Console.WriteLine("First Solution " + (Math.Abs(x) + Math.Abs(y)));
Console.WriteLine("Second Solution " + secondSolution);

enum Direction {
    North,
    East,
    South,
    West
}