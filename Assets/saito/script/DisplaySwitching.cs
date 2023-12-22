using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DisplaySwitching : MonoBehaviour
{

    public GameObject canvas;  // 変数名はアタッチする [Object] で変更する



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Penguin")
        {
            canvas.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Penguin")
        {
            canvas.SetActive(false);
        }
    }

}
