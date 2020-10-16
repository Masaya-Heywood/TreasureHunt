using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector2 worldPos;
    public int gridX;
    public int gridY;

    public int gCost;
    public int hCost;
    public Node parent;

    public Node(bool assignWalkable, Vector2 assignWorldPos)
    {
        walkable = assignWalkable;
        worldPos = assignWorldPos;
    }

    public int fCost { 
        get
        {
            return gCost + hCost;
        }
    }
}