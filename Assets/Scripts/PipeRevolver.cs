using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRevolver : MonoBehaviour
{
    // Screen width
    private float width;
    private Vector3 movePosition;
    public float revolveSpeed;
    private void Awake()
    {
        width = (float) Screen.width / 2.0f;
    }

    public void RevolveInput(Transform pipeTransformVal)
    {
        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);
            Vector3 pos = touch.position;
            pos.x = (pos.x - width) / width;
            movePosition= new Vector3(pos.x, 0.0f, 0.0f);
            pipeTransformVal.transform.Rotate(0,0,-movePosition.x*revolveSpeed,Space.World);
           
        }
        
    }
}
