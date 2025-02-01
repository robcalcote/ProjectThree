using UnityEngine;
using UnityEngine.UI;

public class GameTile : MonoBehaviour
{
    public bool hovered = false;
    public bool selected = false;
    public GameObject tower;

    public Image hoverImage;


    public void toggleHoverImage()
    {
        hoverImage.enabled = !hoverImage.enabled;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
