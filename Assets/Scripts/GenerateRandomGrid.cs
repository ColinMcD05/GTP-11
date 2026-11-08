using UnityEngine;

public class GenerateGrid : MonoBehaviour
{
    [SerializeField] private int height, width;
    [SerializeField]
    [Range(0, 1)] private float obstacleProbability;
    [SerializeField] private Vector2Int obstaclePosition;

    int[,] grid;

    [SerializeField] Pathfinding pathfinding;

    public void Start()
    {
        GenerateRandomGrid(width, height, obstacleProbability);
    }

    public void GenerateRandomGrid(int width, int height, float obstacleProbability)
    {
        //Creates the grid based on height and width
        grid = new int[height, width];

        //Randomly spawn in obstacles
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                float random = Random.Range(0f, 1f);
                print(random);
                if (random < obstacleProbability)
                    AddObstacle(new Vector2Int(i, j));
            }
        }

        pathfinding.SetGrid(grid);
    }
    public void AddObstacle(Vector2Int position)
    {
        if (position.y >= width || position.x >= height)
            return;
        grid[position.x, position.y] = 1;
        pathfinding.SetGrid(grid);
    }

#if UNITY_EDITOR
    [ContextMenu("Add Obstacle")]
    //AddObstacle
    private void AddObstacleMenu()
    {
        AddObstacle(obstaclePosition);
    }

    [ContextMenu("Regenerate Grid")]
    //Regenerate Grid
    private void RegenerateGrid()
    {
        GenerateRandomGrid(width, height, obstacleProbability);
        pathfinding.RefindPath();
    }
#endif
}
