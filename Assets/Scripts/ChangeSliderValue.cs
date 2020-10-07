using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _duration;
    public void ChangeValue(float healthValue)
    {
        _slider.DOValue(_slider.value + healthValue, _duration);
    }
}
