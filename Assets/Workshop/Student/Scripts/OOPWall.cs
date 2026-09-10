using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// OOPWall aka "Demon Wall"
public class OOPWall : Identity
{
    public int Damage;
    public bool IsIceWall;

    private void Start()
    {
        IsIceWall = Random.Range(0, 100) < 20;
        if (IsIceWall)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    public override void Hit()
    {
        if (IsIceWall)
        {
            mapGenerator.player.TakeDamage(Damage, IsIceWall);
        }
        else
        {
            mapGenerator.player.TakeDamage(Damage);
        }
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);
    }

}