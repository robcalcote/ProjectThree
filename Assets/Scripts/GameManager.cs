using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject circle;
    public Sprite towerOneSprite;
    public GameObject mapPfb;
    public List<Sprite> mapSprites;
    public float mapSize = 10;
    public GameObject speedyEnemyPfb;
    public GameObject tankyEnemyPfb;
    
    public Camera mainCamera;

    public Map currentMap;

    public Player player;


    void SpawnEnemy()
    {
        Vector3 newSpeedyStartPoint = new Vector3(currentMap.mapStartPoint.x, currentMap.mapStartPoint.y, 0);
        GameObject newSpeedy = Instantiate(speedyEnemyPfb, newSpeedyStartPoint, Quaternion.identity);

        newSpeedy.GetComponent<Enemy>().Initialize();
    }
    
    void Start() { 
        currentMap = mapPfb.GetComponent<Map>();
        
        Vector2 mapCenter = new Vector3((mapSize / 2) - .5f, (mapSize / 2) - .5f, 0);
        mainCamera.transform.position = new Vector3(mapCenter.x, mapCenter.y, -3);
        
        mapPfb.GetComponent<SpriteRenderer>().sprite = mapSprites[0];
        GameObject newMapObj = Instantiate(mapPfb, mapCenter, Quaternion.identity);
        Map newMap = newMapObj.GetComponent<Map>();

        
        
        SpawnEnemy();
    }
}
