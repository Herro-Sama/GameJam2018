using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour {

    public bool changeHappening;

    public GameObject ButtonRef;

    private Color OceanColour;

    public Color BloodSea;

    public float fillPercent;

    private void Awake()
    {
        OceanColour = gameObject.GetComponent<Image>().color;
        fillPercent = 0;
    }

    private void Update()
    {
        if (changeHappening == true)
        {
            fillPercent += Time.deltaTime / 100;
            Mathf.Clamp(fillPercent, 0, 1);
            gameObject.GetComponent<Image>().color = Color.Lerp(OceanColour, Color.red, fillPercent);
        }
    }

    public void StartChange()
    {
        if (ButtonRef.GetComponent<PurchaseBuilding>().ReturnBuildings() >= 2)
        {
            changeHappening = true;
        }
    }

}
