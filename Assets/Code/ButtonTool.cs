using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTool : MonoBehaviour
{
    public GameObject nextB;
    public void Start()
    {
        nextB.SetActive(false);
    }


    public void End()
    {
        Destroy(gameObject);
        nextB.SetActive(true);
    }
}
