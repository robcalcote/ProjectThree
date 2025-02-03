using UnityEngine;
using UnityEngine.EventSystems;

public class GameTile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public GameManager gameManager;
    public UiManager uiManager;
    
    public bool hovered = false;
    public bool selected = false;
    public bool isPathTile = false;
    public GameObject tower;

    public SpriteRenderer hoverSprite;

    private void ToggleHoverImage() {
        if (!uiManager.towerPlacementMode) return;
        if(isPathTile) return;
        hoverSprite.enabled = !hoverSprite.enabled;
        hovered = true;
    }

    public void OnPointerEnter(PointerEventData eventData) {
        ToggleHoverImage();
    }

    public void OnPointerExit(PointerEventData eventData) {
        ToggleHoverImage();
    }
}
