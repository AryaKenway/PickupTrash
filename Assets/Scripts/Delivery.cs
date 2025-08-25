using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0x39,0x00,0xF3,0xFF);
    [SerializeField] Color32 hasNoPackageColor = new Color32(0xFF, 0x43, 0x26, 0xFF); 

    bool haspackage =false;
    [SerializeField] float destroydelay = 0.5f;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("Haha its collided and this message is witty");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Package" && !haspackage)
        {
            Debug.Log("Package picked up");
            haspackage = true;
            Destroy(collision.gameObject,destroydelay);
            spriteRenderer.color = hasPackageColor;

        }
       
        if (collision.tag == "Customer" && haspackage==true) 
        {
            Debug.Log("Package Delivered");
            haspackage = false;
            spriteRenderer.color = hasNoPackageColor;


        }
        if (collision.tag == "MapBorder")
        {
            Debug.Log("Map border");

        }
    }
}
