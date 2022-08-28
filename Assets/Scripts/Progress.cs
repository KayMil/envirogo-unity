using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
  
    private Slider Slider;
    public float targetProgress = 0.589f;
    
    [SerializeField]
    private float fillSpeed = 0.2f;
    
    public void Start()
    {
        void UpdateProgressFill(float value)
        {
            Slider.value = value;
        }
    }

    void Update()
    {
        if (Slider.value < targetProgress)
        {
            Slider.value += fillSpeed * Time.deltaTime;
        }
    }
}