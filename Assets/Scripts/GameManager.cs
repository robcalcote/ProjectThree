using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject circle;
    public Sprite towerOneSprite;
    public GameObject mapPfb;
    public List<Sprite> mapSprites;
    public float mapSize = 10;
    
    void Start() { 
        mapPfb.GetComponent<SpriteRenderer>().sprite = mapSprites[0];
        GameObject newMapObj = Instantiate(mapPfb, new Vector2(mapSize / 2, -mapSize / 2), Quaternion.identity);
        Map newMap = newMapObj.GetComponent<Map>();

        newMap.setStartPoint(new Vector2(3, 0));

        SpriteRenderer circleRenderer = circle.GetComponent<SpriteRenderer>();
        if (circleRenderer != null && towerOneSprite != null)
        {
            circleRenderer.sprite = towerOneSprite;
        }
        else
        {
            Debug.LogError("Missing references! Ensure towerOne and circle are set up correctly.");
        }
    }
}
