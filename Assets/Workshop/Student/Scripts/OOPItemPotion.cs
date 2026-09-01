using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healPoint;
    public bool isBouns;

    public void Start()
    {

    }

    public override void Hit()
    {
        mapGenerator.player.Heal(healPoint, isBouns);
        Destroy(gameObject);
        mapGenerator.mapData[positionX, positionY] = mapGenerator.empty;
    }
}