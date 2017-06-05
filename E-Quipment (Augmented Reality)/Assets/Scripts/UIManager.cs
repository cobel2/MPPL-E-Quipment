using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public void DisableAnimasi(Animator anim)
    {
        anim.SetBool("isDisplayed", false);
    }

    public void EnableAnimasi(Animator anim)
    {
        anim.SetBool("isDisplayed", true);
    }
}
