using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    private int bulletLifeTime;
    public int maxBulletLifeTime;

    void Start()
    {
        bulletLifeTime = 0;
    }


    void Update()
    {
        bulletLifeTime++;
        if (bulletLifeTime > maxBulletLifeTime)
        {
            gameObject.SetActive(false);
            // Destroy(bullet);
        }
    }
}
