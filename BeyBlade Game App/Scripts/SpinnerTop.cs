using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerTop : MonoBehaviour
{
    public float spinSpeed = 3600;
    public bool doSpin = false;

    private Rigidbody rb;
    public GameObject playerGraphics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (doSpin)
        {
            playerGraphics.transform.Rotate(new Vector3(0, spinSpeed*Time.deltaTime, 0));
        }
    }
}
