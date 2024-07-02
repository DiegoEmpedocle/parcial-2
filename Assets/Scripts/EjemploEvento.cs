using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EjemploEvento : MonoBehaviour
{
    public UnityEvent spaceEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceEvent.Invoke();
        }
    }
}
