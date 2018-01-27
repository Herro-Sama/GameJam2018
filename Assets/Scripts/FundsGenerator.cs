using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundsGenerator : MonoBehaviour {

	private long playerFunds = 0;
	private long clickPower = 1;

	private long playerFundsPerSecond = 0;

    private int timeDelay = 1;

    private float nextTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time >= nextTime)
        {
            nextTime += timeDelay;
            AddFundsPerSecond();
        }
    }

    private void AddFundsPerSecond()
    {
        playerFunds += playerFundsPerSecond;
    }

	public long GetCurrentFunds()
	{
		return playerFunds;
	}

	public long GetFundsPerSecond()
	{
		return playerFundsPerSecond;
	}

    public long GetClickPower()
    {
        return clickPower;
    }

    public void ClickFunds ()
	{
		playerFunds += clickPower;
	}

    public bool CanPlayerPurchase(long cost, long FPSGain)
    {
        if (playerFunds >= cost)
        {
            playerFunds -= cost;
            playerFundsPerSecond += FPSGain;
            return true;
        }
        return false;
    }

    public bool CanPlayerPower(long cost, long PowerGain)
    {
        if (playerFunds >= cost)
        {
            playerFunds -= cost;
            clickPower += PowerGain;
            return true;
        }
        return false;
    }


}
