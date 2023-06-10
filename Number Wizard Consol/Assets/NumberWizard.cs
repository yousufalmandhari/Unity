using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Global variables 
    int max = 1000;
    int min = 1;
    int guss = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is Number Wizard Game");
        Debug.Log("Choose a number between " + max + " and  " + min);
        Debug.Log("Tell me if your number is " + guss);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        Debug.Log("Press Enter if your number is " + ((min + max) / 2) + " or Push Up = Higher, Push Down = Lower");

        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guss;
            guss = (max + min) / 2;
            Debug.Log("Press Enter if your number is " + guss + " or Push Up = Higher, Push Down = Lower");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guss;
            guss = (max + min) / 2;
            Debug.Log("Press Enter if your number is " + guss + " or Push Up = Higher, Push Down = Lower");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The number is " + guss);
            Debug.Log("I'm a smart ;)");
        }
        
    }
}
