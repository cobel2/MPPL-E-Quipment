using UnityEngine;
using System.Collections;

public class TampilPopup : MonoBehaviour {

    public Canvas namaCanvas;
    public bool tampil = false;

    public void Tampil()
    {
        if (tampil == false)
        {
            tampil = false;
            namaCanvas.enabled = true;
        }
        else if (tampil == true)
        {
            tampil = false;
            namaCanvas.enabled = false;
        }
    }
}
