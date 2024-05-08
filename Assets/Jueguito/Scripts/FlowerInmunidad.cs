using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class FlowerInmunidad : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        //MMEventManager.TriggerEvent(new PickableItemEvent(this));
        MMEventManager.TriggerEvent(new MMGameEvent("Inmunidad"));
    }
}
