using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    float indexScale = 1.5f;
    float rotateSpeed = 35f;
    Quaternion originRotation; 
    Vector3 originScale;
    bool isSelected = false;
    
    void Start()
    {
        originScale = transform.localScale;
        originRotation = transform.rotation;
    }

    void Update()
    {
        if (isSelected)
            transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
    }

    public void Select()
    {
        transform.localScale *= indexScale;
        isSelected = true;
    }

    public void Deselect()
    {
        transform.localScale = originScale;
        transform.rotation = originRotation;
        isSelected = false;
    }
}
