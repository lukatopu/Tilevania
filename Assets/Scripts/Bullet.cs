using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerMovement player;

    float bulletSpeed = 20f;
    float xSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindFirstObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }


    void Update()
    {
        bulletLogic();
    }


    void bulletLogic()
    {
        rb.linearVelocity = new Vector2(xSpeed, 0);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0.5f);
    }

}