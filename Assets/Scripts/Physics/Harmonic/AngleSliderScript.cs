using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleSliderScript : MonoBehaviour
{
    Slider sliderSettings;
    bool moving = true;
    
    // Start is called before the first frame update
    void Start()
    {
        sliderSettings = GetComponent<Slider>();   
        sliderSettings.interactable = false;
    }

    public void SetMoving()
    {
        if(moving)
            {
                moving = false;
                sliderSettings.interactable = true;
            } else {
                moving = true;
                sliderSettings.interactable = false;
            }
    }
}
