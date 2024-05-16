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
    }
}
