using UnityEngine;
using UnityEngine.EventSystems;

public class GameTile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
    public GameManager gameManager;
    public UiManager uiManager;
    
    public bool hovered = false;
    public bool selected = false;
    public bool isPathTile = false;
    public GameObject tower;

    public SpriteRenderer hoverSprite;

    public void ToggleHoverImage() {
        if (!uiManager.towerPlacementMode) return;
        if(isPathTile) return;
        hoverSprite.enabled = !hoverSprite.enabled;
        hovered = true;
    }

    public void OnPointerEnter(PointerEventData eventData) {
        ToggleHoverImage();
        gameManager.hoveredTile = gameObject;
    }

    public void OnPointerExit(PointerEventData eventData) {
        ToggleHoverImage();
        gameManager.hoveredTile = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        gameManager.PlaceTower(gameObject);
    }

    public bool IsPath() {
        return isPathTile;
    }
}
