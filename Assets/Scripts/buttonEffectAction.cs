using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.RendererUtils;
using Valve.VR.InteractionSystem;

public class buttonEffectAction : MonoBehaviour
{
    public GameObject BallSpawn;
    public GameObject Ball;
    private Transform BallTarget;

    public void Awake()
    {
        BallTarget = BallSpawn.GetComponent<Transform>();
    }
    public void OnButtonDown(Hand fromHand)
    {
        fromHand.TriggerHapticPulse(1000);
        GameManager.instance.resetBall();
        TextManager.textManagerIntance.updateBestRecord();
        TextManager.textManagerIntance.resetScore();
    }


    private void ColorSelf(Color newColor)
    {
        Renderer[] renderes = this.GetComponentsInChildren<Renderer>();
        for(int rendererIndex = 0; rendererIndex < renderes.Length; rendererIndex++)
        {
            renderes[rendererIndex].material.color = newColor;
        }
    }

}
