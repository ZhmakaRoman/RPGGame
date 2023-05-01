using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    private Outline _outline;
    [SerializeField]
    private int _highlightIntensity = 2;    

    private void Awake()
    {
        _outline = gameObject.GetComponent<Outline>();
    }
    
    public void SetFocus()
    {
        _outline.OutlineWidth = _highlightIntensity;
    }
    
    


    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Potion"))
        {
            other.gameObject.SetActive(false);
            SetFocus();
        }
    }
}
