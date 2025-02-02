using UnityEngine;
using UnityEngine.UI;

public class GameTile : MonoBehaviour
{
    public bool hovered = false;
    public bool selected = false;
    public GameObject tower;

    public SpriteRenderer hoverSprite;

    public void ToggleHoverImage() {
        hoverSprite.enabled = !hoverSprite.enabled;
    }
}
