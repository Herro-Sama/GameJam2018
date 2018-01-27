using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewPanel : MonoBehaviour {

    public GameObject thisLevelPan;
    public GameObject nextLevelPan;

    public GameObject fundManager;


    public void LoadFinalPanel()
    {
        if (fundManager.GetComponent<FundsGenerator>().CanPlayerPurchase(500000000, 0) == true)
        {
            thisLevelPan.SetActive(false);
            nextLevelPan.SetActive(true);
        }
    }

public void LoadNextPanel()
    {
        thisLevelPan.SetActive(false);
        nextLevelPan.SetActive(true);
    }
}
