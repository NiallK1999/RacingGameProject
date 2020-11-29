using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayPointTrigger : MonoBehaviour
{
   public GameObject LapCompleteTrig;
   public GameObject HalfLapTrig;
   
   void OnTriggerEnter (){
      LapCompleteTrig.SetActive (true);
      HalfLapTrig.SetActive (false);
      //sets bool to the triggers 

    }
   
   
    }
