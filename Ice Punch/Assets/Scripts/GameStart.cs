using UnityEngine;
 using System.Collections;
 
 public class WaitForPlayer : MonoBehaviour {
     public GameObject waitScreen;
     public GameObject mainPlayer;
     // Use this for initialization
     void Start () {
         waitScreen.SetActive = (true);
         mainPlayer.SetActive = (false);
     }
 
     void Update (){
 
         function Start () {
             while (true) {
                 while (!Input.GetKeyDown(KeyCode.Space)) yield;
                 waitScreen.SetActive = (false); yield;
                 mainPlayer.SetActive = (true); yield;
            }
        }
    }
}