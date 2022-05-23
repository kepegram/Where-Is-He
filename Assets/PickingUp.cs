using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public GameObject Item;
    public bool canPickUp;
    public int items;
    public GameObject pickUpText;

    // Start is called before the first frame update
    void Start()
    {
        items = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(canPickUp == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Destroy(Item);
                Item = null;
                items += 1;
                canPickUp = false;
            }
        }

        if(canPickUp == true)
        {
            pickUpText.SetActive(true);
        }
        else
        {
            pickUpText.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "item")
        {
            Item = col.gameObject;
            canPickUp = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.tag == "item")
        {
            Item = null;
            canPickUp = false;
        }
    }
}
