using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas canvas;
    public static UIManager Instance;
    public GameObject SliderPrefab;
    private void Awake()
    {
        Instance = this;
    }
    public void AskForSlider(GameObject owner)
    {
        GameObject Slider = Instantiate(SliderPrefab);
        Slider.transform.parent = canvas.transform;
        Slider.GetComponent<ScreenFollower>().target = owner.transform;
    }
}
