using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBola : MonoBehaviour
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
        _rb.AddForce(0, FuerzaSalto * Input.GetAxis("Jump"), 0, ForceMode.Impulse);
        _rb.AddForce(0, 0, Fuerza * Input.GetAxis("Horizontal"), ForceMode.Impulse);
        _rb.AddForce(Fuerza * Input.GetAxis("Vertical"), 0, 0, ForceMode.Impulse);
    }
}
