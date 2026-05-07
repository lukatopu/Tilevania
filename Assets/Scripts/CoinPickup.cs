using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSFX;

    bool wasCollected = false;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !wasCollected)
        {
            wasCollected = true;    
            AudioSource.PlayClipAtPoint(coinPickUpSFX, transform.position);
            Destroy(gameObject);
        }
    }
}
