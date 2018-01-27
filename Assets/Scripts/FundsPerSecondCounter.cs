using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundsPerSecondCounter : MonoBehaviour {

    public GameObject fundManager;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "DPS: " + fundManager.GetComponent<FundsGenerator>().GetFundsPerSecond().ToString();
    }
}
