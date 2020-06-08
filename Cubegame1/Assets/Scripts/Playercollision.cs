using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Movement movement;
    

    // the function is running when we hit an object
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Barrier") // We check if the object we collied with has a tag called "Barrier".
        {
            movement.enabled = false; // Disable the player movement
            FindObjectOfType<Gamemanager>().EndGame();
        }

    }
}
