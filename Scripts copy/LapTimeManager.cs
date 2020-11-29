using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public GameObject MinuteObject;
    public GameObject SecondObject;
    public GameObject MillObject;

    public static int MinuteSum;
    public static int SecoundSum;
    public static float MillSum;
    public static string MillTime;
    //sets veriables 
    

    
    void Update()
    {
        MillSum += Time.deltaTime * 10;
        MillTime = MillSum.ToString ("F0");
        MillObject.GetComponent<Text> ().text = "" + MillTime;
        //puts new value into text box and also for the rest. 
        //gets delattime and multiples it by 10

        if(MillSum >= 10){
            MillSum = 0;
            SecoundSum +=1;
        }
        //every time millisecounds hits 10 add 1 to sec counter 

        if(SecoundSum <= 9){
            SecondObject.GetComponent<Text> ().text = "0" + SecoundSum + ".";
        }
        else{
            SecondObject.GetComponent<Text> ().text = "" + SecoundSum + ".";
        }

        if(SecoundSum >= 60){
            SecoundSum = 0;
            MinuteSum += 1; 
        }
        //everytime sec hits 60 add 1 to min 
         if(SecoundSum <=9){
             MinuteObject.GetComponent<Text> ().text = "0" + MinuteSum + ":";
         }
         else{
             MinuteObject.GetComponent<Text> ().text = "" + MinuteSum + ":";
         }

    }
}
