using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPosition;

    public Node(bool _walkable, Vector3 _worldPosition)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
    }

}