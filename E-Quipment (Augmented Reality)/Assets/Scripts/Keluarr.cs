using UnityEngine;
using System.Collections;

public class Keluarr : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("SubMenu");
    }
}