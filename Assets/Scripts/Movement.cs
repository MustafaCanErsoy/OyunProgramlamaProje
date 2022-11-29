using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float atesleme = 1000f;
    [SerializeField] float donus = 100f;

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        Atesle();
        DonusHesapla();
    }

    void Atesle()
    {
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            rb.AddRelativeForce(Vector3.up * atesleme * Time.deltaTime);
            
        }
        
    }

    void DonusHesapla()
    {
       if (Input.GetAxis("Horizontal") < 0.0f)
        {
            DonusYap(donus);
        }
        else if(Input.GetAxis("Horizontal") > 0.0f)
        {
            DonusYap(-donus);
        }
    }

    private void DonusYap(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}