using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using Unity.XR.CoreUtils;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{

    XROrigin m_XROrigin;

    public Slider scaleSlider;


    private void Awake()
    {
        m_XROrigin = GetComponent<XROrigin>();
    }


    // Start is called before the first frame update
    void Start()
    {
        scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }



    public void OnSliderValueChanged(float value)
    {
        if (scaleSlider != null)
        {
            m_XROrigin.transform.localScale = Vector3.one / value;

        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
