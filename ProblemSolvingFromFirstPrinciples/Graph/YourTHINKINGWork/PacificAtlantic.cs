public class PacificAtlantic
{
    public IList<IList<int>> PacificAtlanticImpl(int[][] heights)
    {
        if (heights.Length == 0 || heights[0].Length == 0)
        {
            return new List<IList<int>>();
        }

        int row = heights.Length;
        int col = heights[0].Length;

        bool[][] pacificReachable = new bool[row][];
        bool[][] atlanticReachable = new bool[row][];

        for (int i = 0; i < row; i++)
        {
            pacificReachable[i] = new bool[col];
            atlanticReachable[i] = new bool[col];
        }

        // Pacific (top + left)
        for (int i = 0; i < row; i++)
        {
            dfs(i, 0, pacificReachable, heights);
            dfs(i, col - 1, atlanticReachable, heights);
        }

        for (int j = 0; j < col; j++)
        {
            dfs(0, j, pacificReachable, heights);
            dfs(row - 1, j, atlanticReachable, heights);
        }

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (pacificReachable[i][j] && atlanticReachable[i][j])
                {
                    result.Add(new List<int> { i, j });
                }
            }
        }

        return result;
    }

    public void dfs(int row, int col, bool[][] reachable, int[][] heights)
    {
        if (reachable[row][col]) return;

        reachable[row][col] = true;

        int[][] directions = new int[][]
        {
            new int[] {0,1},
            new int[] {1,0},
            new int[] {-1,0},
            new int[] {0,-1}
        };

        foreach (int[] dir in directions)
        {
            int newRow = row + dir[0];
            int newCol = col + dir[1];

            if (newRow < 0 || newRow >= heights.Length ||
                newCol < 0 || newCol >= heights[0].Length)
            {
                continue;
            }

            if (heights[newRow][newCol] >= heights[row][col])
            {
                dfs(newRow, newCol, reachable, heights);
            }
        }
    }
}