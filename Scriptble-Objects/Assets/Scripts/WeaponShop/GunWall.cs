using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunWall : MonoBehaviour
{
    [SerializeField]
    private Text _gunName;
    [SerializeField]
    private Text _gunDescription;
    [SerializeField]
    private Text _gunCost;
    [SerializeField]
    private Text _gunDamage;
    [SerializeField]
    private Image _gunImage;


    [SerializeField]
    private GunData lastGunData;


    private void Start()
    {
        lastGunData = Resources.Load<GunData>("SavedGunData");
        LoadLastGunData();
    }

    public void UpdateDisplayUI(GunData gunData)
    {
        _gunName.text = gunData.name;
        _gunDescription.text = gunData.Description;
        _gunCost.text = gunData.Cost.ToString();
        _gunDamage.text = gunData.Damage.ToString();
        _gunImage.sprite = gunData.Icon;

    }
    public void SaveLastGunData()
    {
        lastGunData.name = _gunName.text;
        lastGunData.Description = _gunDescription.text;
        lastGunData.Cost = int.Parse(_gunCost.text);
        lastGunData.Damage = int.Parse(_gunDamage.text);
        lastGunData.Icon = _gunImage.sprite;
       

    }
    public void LoadLastGunData()
    {
        _gunName.text = lastGunData.name;
        _gunDescription.text = lastGunData.Description;
        _gunCost.text = lastGunData.Cost.ToString();
        _gunDamage.text = lastGunData.Damage.ToString();
        _gunImage.sprite = lastGunData.Icon;
        UpdateDisplayUI(lastGunData);
    }
  
    public void ClearSave()
    {
        lastGunData.name = "no data";
        lastGunData.Description = "no data";
        lastGunData.Cost = 0;
        lastGunData.Damage = 0;
        lastGunData.Icon = null;

    }

}
