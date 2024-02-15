using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("HealthBar", slider.value);
    }
    public void TakeDamage(float Damage)
    {
        slider.value -= Damage;

        HealthBarNew();

    }

    public void HealthBarNew()
    {
        PlayerPrefs.SetFloat("HealthBar", slider.value);
    }
}
