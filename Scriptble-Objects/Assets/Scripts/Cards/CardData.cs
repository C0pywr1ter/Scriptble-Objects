using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardData : MonoBehaviour
{
    public Image img;
    public Text name;
    public Text description;


    public Text attack;
    public Text hp;
    public Text mana;

    public CardSO card;
    private void Start()
    {
        img.sprite = card.portraitSprite;
        name.text = card.thisName;
        attack.text = card.attack.ToString();
        hp.text = card.hp.ToString(); 
        mana.text = card.mana.ToString();
        description.text = card.description.ToString();
    }
}
