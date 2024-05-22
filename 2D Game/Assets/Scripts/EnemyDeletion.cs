using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeletion : MonoBehaviour
{
    private GameObject enemy;
    private void Update()
    {
        enemy = GameObject.Find("Enemy(Clone)"); // searches for a specific game object
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        // CONDITION:
        // "If the object we collided with is called..."
        if (collision.gameObject.name == "Enemy(Clone)")
        {
            Destroy(enemy); // removes the game object from the game after it goes off screen
        }

    }
}
