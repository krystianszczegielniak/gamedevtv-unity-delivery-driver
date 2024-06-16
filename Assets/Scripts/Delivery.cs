using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private float packageRemovalDelay = 0.5f;
    private bool hasPackage;

    private SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked up");
            Destroy(other.gameObject, packageRemovalDelay);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
        }
        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
