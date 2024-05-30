using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform enemyPosition;
    public float enemyMove;

    void ControlEnemyMovement()
    {
        enemyPosition.position += new Vector3(enemyMove * Time.deltaTime, 0, 0);
    }

    void Start()
    {

    }


    void Update()
    {
      ControlEnemyMovement(); 


    }

}
