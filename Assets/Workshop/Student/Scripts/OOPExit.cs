using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : MonoBehaviour
{
    public GameObject YouWin;

    public override void Hit()
    {
        mapGenerator.player.enabled = false;
        if (YouWin != null)
        {
            YouWin.SetActive(true);
        }
        Debug.Log("You win");
    }
}
