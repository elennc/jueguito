using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class coinManager : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private int monedas_recolectadas;

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
        monedas_recolectadas++;

        if(monedas_recolectadas == 4)
        {
            Debug.Log("Abrir Puerta");
        }
    }
}
