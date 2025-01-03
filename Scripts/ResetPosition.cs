using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AEROPLANEWALL"))
        {
            transform.localPosition = originalPos;
        }

        else if (other.gameObject.CompareTag("CLOUDWALL"))
        {
            transform.localPosition = originalPos;
        }
    }
}
