using UnityEngine;

public class cases : MonoBehaviour
{
    private bool playerInside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = false;
    }

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            TriggerInteraction();
        }
    }

    void TriggerInteraction()
    {
        Debug.Log("Interaction triggered!");
        
    }
}
