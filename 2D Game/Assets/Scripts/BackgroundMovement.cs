using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    float backgroundSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-(backgroundSpeed * Time.deltaTime), 0, 0); // changes the X position in the Transform component

        if (transform.position.x <= -16.89)
        {
            transform.Translate((float)17.6, 0, 0);
        }
    }
}
