using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class coinManager : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private GameObject puerta;
    private int monedas_recolectadas;

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
        if(e.PickedItem.tag == "star")
        {
            monedas_recolectadas++;
        }
           

        if(monedas_recolectadas == 4)
        {
            puerta.SetActive(true);
        }
    }
}
