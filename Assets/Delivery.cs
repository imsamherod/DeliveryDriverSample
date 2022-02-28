using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;
    private void Start() {
        Debug.Log(hasPackage);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Get Collision from Element
    //private void OnCollisionEnter2D(Collision2D other) {
    //    Debug.Log("Watch out men!!!, you just crash on something!!!");
    //}

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("You just pick a package");
        } else if(other.tag == "Customer" && hasPackage) {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("You just deliver a package");
        }
        
    }


}
