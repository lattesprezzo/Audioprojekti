using UnityEngine;
using UnityEngine.Rendering.Universal;

public class HeartBulletLife : MonoBehaviour
{
    public float heartBulletLifetime;
    public Light2D light2d;
    void Start()
    {
 //   light.GetComponent<Light>().enabled = false;
    }

    void Update()
    {
        if (transform.localScale.x <= 0.1f)
        {
            light2d.intensity = 0.5f;
          //  light2d.enabled = false;
            Destroy(gameObject);
        }

        transform.localScale -= heartBulletLifetime * Time.deltaTime * new Vector3(transform.localScale.x,
            transform.localScale.y, 0);



    }
}