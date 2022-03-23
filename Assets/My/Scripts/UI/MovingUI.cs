using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MovingUI : MonoBehaviour
{
    public TMP_Text message;
    public Slider slider;
    public Image fillImage;
    public Transform constraint;
    public Vector3 offset;
    new Camera camera;

    
    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }


    void Update()
    {
        transform.position = camera.WorldToScreenPoint(constraint.position + offset);

    }
}
