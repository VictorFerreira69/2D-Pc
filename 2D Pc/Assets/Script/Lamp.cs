using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Lamp : MonoBehaviour, IInteractable
{
    [SerializeField] Color disableColor;
    [SerializeField] Color activateColor;
    SpriteRenderer spriteRenderer;
    bool isActivate;
    public void Interact()
    {
       if(isActivate)
        {

            isActivate = false;
            spriteRenderer.color = disableColor;

        }
        else
        {
            isActivate = true;
            spriteRenderer.color = activateColor;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
