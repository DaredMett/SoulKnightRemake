using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFollower : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1, 0);
    private RectTransform sliderRect;
    void Start()
    {
        sliderRect = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 worldPosition = target.position + offset;
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);
            sliderRect.position = screenPosition;
        }
    }
}

