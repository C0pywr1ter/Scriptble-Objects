using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnGunSelected;

    private void OnMouseDown()
    {
        OnGunSelected.Raise();


    }
}
