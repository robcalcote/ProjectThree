using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject circle;
    public Sprite towerOneSprite;
    public GameObject mapPfb;
    public List<Sprite> mapSprites;
    
    void Start() {
        mapPfb.GetComponent<SpriteRenderer>().sprite = mapSprites[0];
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
