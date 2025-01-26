using UnityEngine;

public class Map : MonoBehaviour
{
    public float mapSize;
    public Sprite mapSprite;
    public Vector2 mapStartPoint;
    
    public void setStartPoint(Vector2 startPoint)
    {
        mapStartPoint = startPoint;
    }
}
