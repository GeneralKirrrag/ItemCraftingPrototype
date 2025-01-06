using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForgeMeter : MonoBehaviour
{
    public Slider heatSlider;
    public float heatValue;
    public float maxHeatValue;

    public Slider forgeSlider;
    public float forgeValue;
    public float maxForgeValue;

    public void Start() {
        forgeSlider.maxValue = maxForgeValue;
        heatSlider.maxValue = maxHeatValue;
    }

    public void Update() {
        LowerValueOverTime(heatValue, maxHeatValue, 1.5f);
    }

    public void LowerValueOverTime(float value, float maxValue, float speed) {
        value -= Time.deltaTime * speed;
        //Mathf.Clamp(value, 0, maxValue);
    }
}
