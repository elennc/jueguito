using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class Inmunidad : MonoBehaviour, MMEventListener<MMGameEvent>
{

    [SerializeField]
    private float tiempo_inmunidad;
    private GameObject _fadeObject;
    private Health salud_personaje;

    [Header("Inmunidad")]
    [MMInspectorButton("Control inmunidad")]
    private bool ControlInmunidadaButton;

   
    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();

    }

    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();

    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
        
        if(e.EventName  == "Inmunidad")
        {
            ControlInmunidad();
        }
    }

    public Health getHealth()
    {
        _fadeObject = LevelManager.Instance.Players[0].gameObject;
        return _fadeObject.GetComponent<Health>();

    }

    public void ControlInmunidad()
    {
        salud_personaje = getHealth();
        salud_personaje.Invulnerable = true;
        StartCoroutine(DesactivarInmunidad());

    }

    public IEnumerator DesactivarInmunidad()
    {
        yield return new WaitForSeconds(tiempo_inmunidad);
        salud_personaje.Invulnerable = false;
    }
}
