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

    public void Initialize()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        targetPosition = new Vector3(gameManager.currentMap.directions[currentDirectionIndex].x, gameManager.currentMap.directions[currentDirectionIndex].y, 0);
    }
    
    void Update() {
        if (currentDirectionIndex == gameManager.currentMap.directions.Count) {
            Attack();
            return;
        }
        Move();
    }

    void Move()
    {
        if (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else {
            currentDirectionIndex++;
            if (currentDirectionIndex >= gameManager.currentMap.directions.Count) {
                return;
            }
            targetPosition = gameManager.currentMap.directions[currentDirectionIndex];
        }
    }

    void Attack() {
        gameManager.player.TakeDamage(damage);
        Destroy(gameObject);
    }
}