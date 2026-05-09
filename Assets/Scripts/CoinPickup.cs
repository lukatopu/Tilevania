using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSFX;
    bool wasCollected = false;
    int scoreAddAmount = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !wasCollected)
        {
            wasCollected = true;    
            AudioSource.PlayClipAtPoint(coinPickUpSFX, transform.position);
            FindAnyObjectByType<GameSession>().AddToScore(scoreAddAmount);
            Destroy(gameObject);
        }
    }
}
