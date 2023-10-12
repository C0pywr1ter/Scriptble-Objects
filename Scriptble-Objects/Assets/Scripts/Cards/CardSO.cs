using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card", menuName ="CardSO", order = 51)]
public class CardSO : ScriptableObject
{

    public Sprite portraitSprite;
    public string thisName;
    public string description;


    public int attack;
    public int hp;
    public int mana;

}
