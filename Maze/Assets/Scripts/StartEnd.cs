using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEnd : MonoBehaviour
{
    public GameObject Trigger;
    public Text textElement;
    public string TextValue;

    public float Timer;
 


    
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(Trigger);
        Timer = Time.time;
        TextValue = ("Game Over, Your Time : " + Timer);
        textElement.text = TextValue;  
        Application.Quit();     
 
    }

   
}
