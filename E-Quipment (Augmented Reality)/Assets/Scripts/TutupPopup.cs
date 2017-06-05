using UnityEngine;
using System.Collections;

public class TutupPopup : MonoBehaviour {

    public Canvas namaCanvas;
    public bool tampil = false;

    public void Tutup()
    {
        if (tampil == false)
        {
            tampil = false;
            namaCanvas.enabled = false;
        }
    }
}
