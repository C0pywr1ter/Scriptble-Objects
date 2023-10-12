using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public Transform lightPtr;
    Interactable currentSelect;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            lightPtr.position = new Vector3(hit.point.x, hit.point.y, hit.point.z - 1);
            
            Interactable interactable = 
                hit.collider.gameObject.GetComponent<Interactable>();
            if (interactable && currentSelect != interactable)
            {
                if (currentSelect)
                    currentSelect.Deselect();
                currentSelect = interactable;
                interactable.Select();
            }
            else if (currentSelect != interactable)
            {
                currentSelect.Deselect();
                currentSelect = null;
            }
        }
        else if (currentSelect)
        {
            currentSelect.Deselect();
            currentSelect = null; 
        }
    }
}
