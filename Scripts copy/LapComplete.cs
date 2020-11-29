using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfwayPointTrigger;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MillDisplay;

    //creategame objects and made them public 
    //used to save times on best time!



    void OnTriggerEnter () {
        if(LapTimeManager.SecoundSum <=9){
            SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecoundSum +".";
        }
        else
        {
            SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecoundSum +".";
        }
        //impoted veriables from laptime manager so that it gets the current time. 
        

        if(LapTimeManager.MinuteSum <=9){
            MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteSum +".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteSum +".";
        }

        MillDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MillSum +".";

        LapTimeManager.MinuteSum = 0;
        LapTimeManager.SecoundSum = 0;
        LapTimeManager.MillSum = 0;
        
        

        HalfwayPointTrigger.SetActive (true);
        LapCompleteTrigger.SetActive (false);
        //triggers to see when the car has passed a certin point on the track. 

    }
    
}
