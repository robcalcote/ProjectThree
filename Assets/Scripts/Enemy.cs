using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public int speed = 2;

    public Sprite enemySprite;
    public SpriteRenderer enemySpriteRenderer;
    
    void Start()
    {
        enemySpriteRenderer.sprite = enemySprite;
    }

    void Update()
    {
        
    }

    void Move()
    {
        
    }
}
