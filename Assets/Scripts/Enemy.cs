using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public int speed = 5;
    public int damage = 1;
    
    public GameManager gameManager;
    public int currentDirectionIndex = 0;
    public Vector3 targetPosition;

    public Sprite enemySprite;
    // public SpriteRenderer enemySpriteRenderer;

    // public IEnumerable MoveAfter()
    // {
    //     while (transform.position.x != targetPosition.x && 
    //            transform.position.y != targetPosition.y)
    //     {
    //         // not sure yet
    //     }
    //     
    //     
    // }
    
    
    
    void Start()
    {
        
    }

    public void Initialize()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        targetPosition = new Vector3(gameManager.currentMap.directions[currentDirectionIndex].x, gameManager.currentMap.directions[currentDirectionIndex].y, 0);
    }
    
    void Update()
    {
        // Debug.Log("current position is: " + transform.position);
        // Debug.Log("target position is: " + targetPosition);
        if (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            // transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            currentDirectionIndex++;
            targetPosition = gameManager.currentMap.directions[currentDirectionIndex];
        }
    }

    void Move()
    {
        
    }
}
