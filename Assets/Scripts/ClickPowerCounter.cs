using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPowerCounter : MonoBehaviour {

    public GameObject fundManager;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Power: " + fundManager.GetComponent<FundsGenerator>().GetClickPower().ToString();
    }
}
