using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Sprite towerOne;
    public GameObject circle;
    
    void Start()
    {
        SpriteRenderer circleRenderer = circle.GetComponent<SpriteRenderer>();
        if (circleRenderer != null && towerOne != null)
        {
            circleRenderer.sprite = towerOne;
        }
        else
        {
            Debug.LogError("Missing references! Ensure towerOne and circle are set up correctly.");
        }
    }
}
