using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForgeMeter : MonoBehaviour
{
    public Slider heatSlider;
    public float maxHeatValue;

    public bool isHeating;
    public float heatSpeed;
    public float coolSpeed;

    public Slider forgeSlider;
    public float maxForgeValue;
    public int strikeValue = 1;

    public void Start() {
        forgeSlider.maxValue = maxForgeValue;
        heatSlider.maxValue = maxHeatValue;
    }

    public void Update() {
        if (isHeating)
        {
            heatSlider.value += heatSpeed * Time.deltaTime;
        }
        else
        {
            heatSlider.value -= coolSpeed * Time.deltaTime;
        }
    }

    public void Strike()
    {
        if (heatSlider.value > 0f) forgeSlider.value += strikeValue;
    }
}
