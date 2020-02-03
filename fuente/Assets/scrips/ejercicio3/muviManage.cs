using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muviManage : MonoBehaviour
{
    public float Fuerza = 1;
    public float FuerzaSalto = 1;
    Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") && this.transform.position.y <= 2.6)
        _rb.AddForce(0, FuerzaSalto, 0, ForceMode.Impulse);
        _rb.AddForce(0, 0, Fuerza * Input.GetAxis("Horizontal"));
        _rb.AddForce(-1*Fuerza * Input.GetAxis("Vertical"), 0, 0);
    }
}
