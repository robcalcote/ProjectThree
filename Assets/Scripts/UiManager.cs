using UnityEngine;

public class UiManager : MonoBehaviour
{
    GameData gameData;
    public GameObject selectedTower;
    
    public void SelectTower(int towerIndex)
    {
        selectedTower = gameData.towers[towerIndex];
        Debug.Log(selectedTower);
    }

    void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }
}