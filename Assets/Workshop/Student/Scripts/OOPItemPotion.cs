using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healPoint;
    public bool isBouns;

    public void Start()
    {
        isBonus = Random.Range(0, 100) < 20;
        if (isBonus)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
    public override void Hit()
    {
        if (isBonus)
        {
            mapGenerator.player.Heal(healPoint, isBonus);
            Debug.Log("You got " + Name + " Bonus : " + (healPoint * 2));
        }
        else
        {
            mapGenerator.player.Heal(healPoint);
            Debug.Log("You got " + Name + " : " + healPoint);
        }
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);
    }
}