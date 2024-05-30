using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    // Unity editor variable
    public GameObject attackPrefab;
    private GameObject weapon;
    [SerializeField]
    Image battleGauge;
    [SerializeField]
    float gauge, MaxGauge;
    [SerializeField]
    float depleteSpeed = 5;


    private void Start()
    {
        StartCoroutine(Countdown()); // Run this function on start
    }

    // Update is called once per frame
    void Update()
    {
        gauge -= depleteSpeed * Time.deltaTime;
        battleGauge.fillAmount = gauge / MaxGauge;

        if (gauge <= 0)
        {
            // lose condition here
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        weapon = GameObject.Find("Projectile(Clone)"); // searches for a specific game object

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // CONDITION:
        // If the Enemy tag has collided with the player
        if (collision.gameObject.tag == ("Enemy"))
        {
            gauge = gauge - 5;
        }


    }
    // ACTION: Swing Weapon
    public void Attack()
    {
        // Clone the object
        // Declare a variable to hold the cloned object
        GameObject clonedAttack;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedAttack = Instantiate(attackPrefab);

        // Position the projectile next to the player
        clonedAttack.transform.Translate(3, 2, 0);        

           

    }
    private IEnumerator Countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1); //wait 1 seconds
            Destroy(weapon);
        }
    }

}
