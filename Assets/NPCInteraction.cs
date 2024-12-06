using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public string questMessage = "Take bomb";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(questMessage);
        }
    }
}
