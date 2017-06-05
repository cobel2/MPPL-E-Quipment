using UnityEngine;
using System.Collections;

public class Keluar : MonoBehaviour {
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("MainMenu");
    }
}
