using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    [Range(0, 1)] public float percent;
    private long m_Cont = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        m_Cont++;
        gameObject.transform.localScale = new Vector3(percent, 1, 1);
    }
}