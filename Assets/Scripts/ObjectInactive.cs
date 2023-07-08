using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInactive : MonoBehaviour

{
    public GameObject objectToInActivate;

    void Start()
    {
    objectToInActivate.SetActive(false);
    
    }

}
