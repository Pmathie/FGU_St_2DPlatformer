using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //Vi tjekker om vi bliver ramt af et objekt med "Player" tag
        {
            collision.gameObject.GetComponent<PlayerMovement>().Respawn(); //Vi får fat i vores playerMovement script og kører Respawn-funktionen
        }
    }

}
