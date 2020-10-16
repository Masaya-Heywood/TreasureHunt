﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Transform playerChar;
    public LayerMask unwalkableMask;
    public Vector2 gridWorldSize;
    public float nodeRadius;
    Node[,] grid;

    float nodeDiameter;
    int gridSizeX, gridSizeY;

    void Start()
    {
        nodeDiameter = nodeRadius * 2;
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
        CreateGrid();
    }

    void CreateGrid()
    {
        grid = new Node[gridSizeX, gridSizeY];
        Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.up * gridWorldSize.y / 2;

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 worldPoint = worldBottomLeft + Vector3.right * (x * nodeDiameter + nodeRadius) + Vector3.up * (y * nodeDiameter + nodeRadius);
                bool walkable = !(Physics2D.OverlapCircle(worldPoint, nodeRadius, unwalkableMask));
                grid[x, y] = new Node(walkable, worldPoint);
            }
        }
    }

    public List<Node> GetNeighbours(Node node)
    {
        List<Node> neighbours = new List<Node>();

        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                if (x == 0 && y == 0)
                    continue;

                int checkX = node.gridX + x;
                int checkY = node.gridY + y;

                if (checkX >= 0 && checkX < gridSizeX && checkY >= 0 && checkY < gridSizeY)
                {
                    neighbours.Add(grid[checkX, checkY]);
                }
            }
        }

        return neighbours;
    }
    public Node NodeFromWorldPoint(Vector3 worldPosition)
    {
        float percentX = (worldPosition.x + gridWorldSize.x / 2) / gridWorldSize.x;
        float percentY = (worldPosition.y + gridWorldSize.y / 2) / gridWorldSize.y;
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);

        int x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
        int y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
        return grid[x, y];
    }

    public List<Node> path;
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));


        if (grid != null)
        {
            foreach (Node n in grid)
            {
                Node playerNode = NodeFromWorldPoint(playerChar.position);
                Gizmos.color = (n.walkable) ? Color.white : Color.red;
                if (playerNode.worldPos == n.worldPos) 
                {
                    Gizmos.color = Color.green;
                }
                Gizmos.DrawCube(n.worldPos, Vector3.one * (nodeDiameter - .1f));
            }
        }
    }
}




//public class Grid : MonoBehaviour
//{
//    public LayerMask unwalkableMask;
//    public Vector2 gridWorldSize;
//    public float nodeRadius;
//    Node[,] grid;

//    float nodeDiameter;
//    int gridSizeX, gridSizeY;

//    void Start()
//    {
//        nodeDiameter = nodeRadius * 2;
//        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
//        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
//        CreateGrid();
//    }

//    void CreateGrid()
//    {
//        grid = new Node[gridSizeX, gridSizeY];
//        Vector2 worldBottomLeft = new Vector2(transform.position.x, transform.position.y) - (Vector2.right * gridWorldSize.x / 2) - (Vector2.up * gridWorldSize.y / 2);

//        for (int x = 0; x < gridSizeX; x++)
//        {
//            for (int y = 0; y < gridSizeY; x++)
//            {
//                Vector2 worldPoint = worldBottomLeft + Vector2.right * (x * nodeDiameter + nodeRadius) + Vector2.up * (y * nodeDiameter + nodeRadius);
//                bool walkable = !(Physics2D.OverlapCircle(worldPoint, nodeRadius, unwalkableMask));

//                grid[x, y] = new Node(walkable, worldPoint);

//            }
//        }
//    }
//    public void OnDrawGizmos()
//    {
//        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, gridWorldSize.y, 0));

//        if (grid != null)
//        {
//            foreach (Node n in grid)
//            {
//                Gizmos.color = (n.walkable) ? Color.white : Color.red;
//                Gizmos.DrawCube(n.worldPos, Vector3.one * (nodeDiameter - .1f));
//            }
//        }
//    }
//}