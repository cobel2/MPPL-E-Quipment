#pragma strict

var panelInfoCanvas : Canvas;
var infoOpen = false;

function InfoPanel ()
{
    if (infoOpen == false)
    {
        infoOpen = true;
        panelInfoCanvas.enabled = true;
    }
    else if (infoOpen == true)
    {
        infoOpen = false;
        panelInfoCanvas.enabled = false;
    }
}