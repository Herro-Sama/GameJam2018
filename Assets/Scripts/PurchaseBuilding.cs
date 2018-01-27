using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseBuilding : MonoBehaviour {

    public GameObject fundManager;

    public long buildingCost;

    public long fundsPerSecondvalue;

    public float modifierValue;

    private long currentCost;

    private long numberOfBuildings = 1;

    private void Awake()
    {
        currentCost = buildingCost;
    }

    public void BuyBuilding()
    {
        if (fundManager.GetComponent<FundsGenerator>().CanPlayerPurchase(currentCost, fundsPerSecondvalue) == true)
        {
            numberOfBuildings++;
            currentCost = Mathf.FloorToInt((Mathf.Pow(buildingCost * numberOfBuildings, modifierValue)));
        }
    }

    public long ReturnCost()
    {
        return currentCost;
    }

    public long ReturnBuildings()
    {
        return numberOfBuildings;
    }

}
