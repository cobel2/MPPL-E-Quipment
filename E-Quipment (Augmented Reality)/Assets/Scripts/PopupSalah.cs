﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopupSalah : MonoBehaviour
{
    public Canvas namaCanvas;
    public bool tampil = false;

    public void TampilPopup()
    {
        if (tampil == false)
        {
            tampil = true;
            namaCanvas.enabled = true;
        }
    }
}
