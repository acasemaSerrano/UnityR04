using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatedManaget : MonoBehaviour
{
    public int NumObj = 5;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; i<= NumObj; i++)
        {
            Instantiate(obj, new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
