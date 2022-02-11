using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] switches;

    [SerializeField]
    GameObject exitDoor;

    public bool exitPlate1 = false;
    public bool exitPlate2 = false;

    int noOfSwitches = 0;
    [SerializeField]
    Text Description;

    [SerializeField]
    Text switchCount;
    public int x = 0;

    private void Start()
    {
        GetNoOfSwitches();
    }

    private int GetNoOfSwitches()
    {
          x = 0;
        for (int i=0;i<switches.Length;i++)
        {
            if (switches[i].GetComponent<SpriteRenderer>().color == Color.red)
            {
                x++;
            }
            else if (switches[i].GetComponent<SpriteRenderer>().color == Color.green)
            {
                noOfSwitches--;
            }
        }
        noOfSwitches = x;
        return noOfSwitches;
    }

    public void GetExitDoorState()
    {
        if(noOfSwitches <= 0 )
        {
            exitDoor.SetActive(false);
        }
    }

    private void Update()
    {
        switchCount.text = GetNoOfSwitches().ToString();
        GetExitDoorState();
        CheckExitPlates();
    }

    private void CheckExitPlates()
    {
       if(exitPlate1 && exitPlate2)
        {
            Description.text = "Congrats! You won. Quit game and restart to try again.";
        }
    }
}
