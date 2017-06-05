using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

    public Canvas namaCanvas;
    public bool tampil = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            tampil = true;
            namaCanvas.enabled = true;
        }
    }
}
