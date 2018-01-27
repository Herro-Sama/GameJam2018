using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostCounter : MonoBehaviour {

    public GameObject ObjectRef;

    public bool isLab;


    private void Update()
    {
        if (isLab)
        {
            gameObject.GetComponent<Text>().text = "Cost: " + ObjectRef.GetComponent<IncreaseClickPower>().ReturnBuildingCost().ToString();
        }

        else
        {
            gameObject.GetComponent<Text>().text = "Cost: " + ObjectRef.GetComponent<PurchaseBuilding>().ReturnCost().ToString();
        }

    }

}
