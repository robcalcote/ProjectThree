using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEditor.Searcher;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameData gameData;
    public UiManager uiManager;
    
    public Sprite towerOneSprite;
    public GameObject mapPfb;
    public GameObject mainCanvas;
    public List<Sprite> mapSprites;
    public float mapSize = 10;
    public GameObject speedyEnemyPfb;
    public GameObject tankyEnemyPfb;
    
    // Tiles
    public GameObject tilePfb;
    public GameObject tileContainer;
    public GameObject placementGrid;
    
    public Camera mainCamera;

    public Map currentMap;

    public Player player;
    
    void Start() { 
        currentMap = mapPfb.GetComponent<Map>();
        
        Vector2 mapCenter = new Vector3((mapSize / 2) - .5f, (mapSize / 2) - .5f, 0);
        mainCamera.transform.position = new Vector3(mapCenter.x, mapCenter.y, -3);
        placementGrid.transform.position = new Vector3(mapCenter.x, mapCenter.y, 0);
        
        mapPfb.GetComponent<SpriteRenderer>().sprite = mapSprites[0];
        GameObject newMapObj = Instantiate(mapPfb, mapCenter, Quaternion.identity);
        Map newMap = newMapObj.GetComponent<Map>();
        mainCanvas.transform.position = new Vector3(mapCenter.x, mapCenter.y, 0);
        
        InitializeTiles();
        SpawnEnemy();
    }
    
    
    void SpawnEnemy()
    {
        Vector3 newSpeedyStartPoint = new Vector3(currentMap.mapStartPoint.x, currentMap.mapStartPoint.y, 0);
        GameObject newSpeedy = Instantiate(speedyEnemyPfb, newSpeedyStartPoint, Quaternion.identity);

        newSpeedy.GetComponent<Enemy>().Initialize();
    }

    private void InitializeTiles() {
        for (int x = 0; x < mapSize; x++) {
            for (int y = 0; y < mapSize; y++) {
                GameObject newTile = Instantiate(tilePfb, new Vector3(x, y, 0),
                    Quaternion.identity, tileContainer.transform);
                GameTile newGameTile = newTile.GetComponent<GameTile>();
                newGameTile.uiManager = uiManager;
                newTile.name = $"Tile({x}, {y})";
                if (currentMap.directions.Any(v => v.x == x && v.y == y)) {
                    newGameTile.isPathTile = true;
                }
            }
        }
    }
}
