using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    float enemySpeed = 2;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-(enemySpeed * Time.deltaTime), 0, 0); // changes the X position in the Transform component
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // CONDITION:
        // "If the object we collided with is called..."
        //if (collision.gameObject.name == "Kill Box")
        //{
            //Destroy(this.gameObject); // removes the game object from the game after it goes off screen
        //}
    }
}
