using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class aleatorio : MonoBehaviour
{
    int usoAleatorio;

    void Start()
    {
        usoAleatorio = Random.Range(0, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (usoAleatorio)
        {
            default:
            case 0:
                case0();
                break;
            case 1:
                case1();
                break;
            case 2:
                case2();
                break;
            case 3:
                case3();
                break;
            case 4:
                case4();
                break;
            
        }
    }


    private void case0()
    {
        Destroy(this);
    }
    private void case1()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    private void case2()
    {
        this.transform.localScale -= Vector3.one*0.2f;
    }

    private void case3()
    {
        this.transform.position -= Vector3.up * 0.2f;
    }

    private void case4()
    {
        this.transform.rotation = Quaternion.Euler(Vector3.up * 0.2f);
    }
}
