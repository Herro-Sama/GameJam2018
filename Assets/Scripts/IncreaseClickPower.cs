using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseClickPower : MonoBehaviour {

    public GameObject fundManager;

    public long buildingCost;

    public float modifierValue;

    private long currentCost;

    private long numberOfBuildings = 1;

    private void Awake()
    {
        currentCost = buildingCost;
    }

    public void ImproveResearch()
    {

        if (fundManager.GetComponent<FundsGenerator>().CanPlayerPower(currentCost) == true)
        {
            numberOfBuildings++;
            currentCost = Mathf.FloorToInt((Mathf.Pow(buildingCost * numberOfBuildings, modifierValue)));
        }
    }

    public long ReturnBuildingCost()
    {
        return currentCost;
    }
}
