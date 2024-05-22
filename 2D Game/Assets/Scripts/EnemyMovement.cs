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

}
