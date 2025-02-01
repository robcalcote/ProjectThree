using UnityEngine;

public class UiManager : MonoBehaviour
{
    GameData gameData;
    public GameObject selectedTower;
    public bool towerPlacementMode = false;
    public GameObject placementGrid;
    
    public void toggleTowerPlacementMode()
    {
        towerPlacementMode = !towerPlacementMode;
        placementGrid.SetActive(towerPlacementMode);
    }
    
    public void SelectTower(int towerIndex)
    {
        selectedTower = gameData.towers[towerIndex];
        toggleTowerPlacementMode();
    }

    void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }
}