using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletControl : MonoBehaviour
{

    private bool canShootLeft;

    public GameObject bullet;
    public float bulletSpeed;
    public Transform bulletSpawnLocation;
    public float bulletLifeTime;
    public float maxBulletLifeTime;

    void Start()
    {

    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            canShootLeft = GetComponent<PlayerMovementSideWay>().isFacingLeft;
            GameObject instance = Instantiate(bullet, bulletSpawnLocation.position + (new Vector3(canShootLeft ? -2 : 1, 0, 0)), bulletSpawnLocation.rotation);
            bullet.SetActive(true);

            if (canShootLeft)
            {
                instance.GetComponent<Rigidbody2D>().velocity -= new Vector2(bulletSpeed, 0);


            }
            else
            {
                instance.GetComponent<Rigidbody2D>().velocity += new Vector2(bulletSpeed, 0);

            }
        }

    }
}
