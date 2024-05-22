using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGauge : MonoBehaviour
{
    [SerializeField]
    private Image battleGauge;
    [SerializeField]
    private float gauge, MaxGauge;
    [SerializeField]
    float depleteSpeed = 5;



    // Update is called once per frame
    void Update()
    {
        gauge -= depleteSpeed * Time.deltaTime;
        battleGauge.fillAmount = gauge / MaxGauge;

        if (gauge <= 0)
        {
            // lose condition here
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // CONDITION:
        // "If the object we collided with is on the layer..."
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            gauge = gauge - 5;
        }
    }

    
    
}
