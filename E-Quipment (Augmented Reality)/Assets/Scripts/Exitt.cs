using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Exitt : MonoBehaviour {

    public Canvas namaCanvas;
    public bool tampil = false;

    public void Keluar()
    {
        Application.Quit();
    }

    public void TutupPopup()
    {
        tampil = false;
        namaCanvas.enabled = false;
    }
}
