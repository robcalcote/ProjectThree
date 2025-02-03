using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameManager gameManager;
    GameData gameData;
    public GameObject selectedTower;
    public bool towerPlacementMode = false;
    public GameObject placementGrid;
    
    public void enterTowerPlacementMode()
    {
        towerPlacementMode = true;
        placementGrid.SetActive(true);
    }    
    
    public void exitTowerPlacementMode()
    {
        if (gameManager.hoveredTile != null) {
            gameManager.hoveredTile.GetComponent<GameTile>().ToggleHoverImage();
        }
        placementGrid.SetActive(false);
        towerPlacementMode = false;
    }
    
    public void SelectTower(int towerIndex)
    {
        selectedTower = gameData.towers[towerIndex];
        enterTowerPlacementMode();
    }

    void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) exitTowerPlacementMode();
    }
}