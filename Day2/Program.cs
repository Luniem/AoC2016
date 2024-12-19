string day = "Day2";
string input = @"/home/nico/projects/AoC2016/" + day + "/input.txt";

string[] instructions = File.ReadAllLines(input);

List<List<int>> keyPad = new List<List<int>> {
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 },
};

int x = 1;
int y = 1;

string firstSolution = "";

foreach(string inst in instructions) {
    foreach(char c in inst) {
        switch(c) {
            case 'U':
                if(y > 0) y--;
                break;
            case 'D':
                if(y < 2) y++;
                break;
            case 'L':
                if(x > 0) x--;
                break;
            case 'R':
                if(x < 2) x++;
                break;
        }
    }

    firstSolution += keyPad[y][x];
}

Console.WriteLine("First solution: " + firstSolution);

// Part 2
List<List<char>> keyPad2 = new List<List<char>> {
    new List<char> { ' ', ' ', '1', ' ', ' ' },
    new List<char> { ' ', '2', '3', '4', ' ' },
    new List<char> { '5', '6', '7', '8', '9' },
    new List<char> { ' ', 'A', 'B', 'C', ' ' },
    new List<char> { ' ', ' ', 'D', ' ', ' ' },
};

x = 0;
y = 2;

string secondSolution = "";

foreach(string inst in instructions) {
    foreach(char c in inst) {
        switch(c) {
            case 'U':
                if(y > 0 && keyPad2[y - 1][x] != ' ') y--;
                break;
            case 'D':
                if(y < 4 && keyPad2[y + 1][x] != ' ') y++;
                break;
            case 'L':
                if(x > 0 && keyPad2[y][x - 1] != ' ') x--;
                break;
            case 'R':
                if(x < 4 && keyPad2[y][x + 1] != ' ') x++;
                break;
        }
    }

    secondSolution += keyPad2[y][x];
}

Console.WriteLine("Second solution: " + secondSolution);