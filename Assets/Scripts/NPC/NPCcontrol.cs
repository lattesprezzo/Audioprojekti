using System.ComponentModel.Design;
using UnityEngine;

public class NPCcontrol : MonoBehaviour
{
    public float minValue;
    public float maxValue;
    public float breathValue;
    public bool canGrow;
    void Start()
    {
        canGrow = true;
    }

    void NPCbreath()
    {
        if (transform.localScale.x < maxValue && canGrow)
        {

            transform.localScale += new Vector3(breathValue * Time.deltaTime, 0, 0);

            if(transform.localScale.x >= maxValue)
            {
                canGrow = false;
            }

        }
        else
        {
            transform.localScale -= new Vector3(breathValue * Time.deltaTime, 0, 0);

            if(transform.localScale.x <= minValue)
            {
                canGrow = true;
            }

        }

    }

    void Update()
    {
        NPCbreath();
    }
}
