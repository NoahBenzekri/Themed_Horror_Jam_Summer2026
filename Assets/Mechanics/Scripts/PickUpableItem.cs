using UnityEngine;

public class PickUpableItem : MonoBehaviour
{
    Item item;
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player")){
            collider.transform.GetComponent<ItemManager>().PickedUpItem(item);
            Destroy(gameObject);
        }
    }
}
