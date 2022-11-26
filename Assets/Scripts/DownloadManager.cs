using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Application.internetReachability");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}