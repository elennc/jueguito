using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class ItemManager : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private GameObject puerta;
    private int item_recolectado;

    // Start is called before the first frame update
    void Start()
    {
        if(puerta != null)
        {
            puerta.SetActive(false);
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();

    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        //Debug.Log(e.PickableItem.name);
        //Debug.Log(e.PickableItem);
        if(e.PickedItem.tag == "door")
        {
            Debug.Log("holi");
            item_recolectado++;

        }

        if(item_recolectado == 1)
        {
            puerta.SetActive(true);
        }
    }
}
