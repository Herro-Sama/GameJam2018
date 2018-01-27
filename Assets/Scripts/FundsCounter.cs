using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundsCounter : MonoBehaviour {

	public GameObject fundManager; 

	// Update is called once per frame
	void Update () 
	{
        gameObject.GetComponent<Text>().text = "Deaths: " + fundManager.GetComponent<FundsGenerator>().GetCurrentFunds().ToString();
	}
}
