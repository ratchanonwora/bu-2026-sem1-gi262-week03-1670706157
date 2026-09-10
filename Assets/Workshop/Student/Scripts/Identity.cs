using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Identity class เป็น base class (คลาสแม่) ของทุก object ที่ถูกสร้างขึ้นในเกม
public class Identity : MonoBehaviour
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