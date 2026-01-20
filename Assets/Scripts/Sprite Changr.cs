using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChangr : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        // {
        //    PickARandomColour();
        // }
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousPos) == true)
        {
            spriteRenderer.color = col;
        }
        else
        { spriteRenderer.color = Color.white; }
    }
    void PickARandomColour()
    {
        
        spriteRenderer.color = col;
    }
}
