using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionData)
    {
        Debug.Log(collisionData.collider.name);

        if (collisionData.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

        }
    }
    
}
