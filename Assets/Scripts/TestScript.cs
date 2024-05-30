using UnityEngine;

public class TestScript : MonoBehaviour
{
    string playerName = "Lateli";
  //  int energy = 100;
    float speed = 0.0f;
   // bool isJumping = false;

    void Start()
    {
        Debug.Log(playerName + " " + speed);

        playerName = "James Sunderland";
        speed = 100.0f;

        Debug.Log(playerName + " " + speed);

        //Debug.Log("Kaikki variaabelit:");

        //Debug.Log(energy);
        //Debug.Log(speed);
        //Debug.Log(isJumping);
        // Yhteen pötköön:
        // CTRL + K + C: saat kaikki kommentoitua
        // CTRL + K + U: saat poistettua kommentit
        // Toinen tapa:
        /* kommentti */
        //Debug.Log($"{playerName}\n ja sitten energy: {energy}");   

    }



    void Update()
    {

        if (speed <= 110)
        {
            speed += 2f; // lisätään 2 niin kauan kuin
                         // speed on pienempi tai yhtä suuri kuin 200
            if (speed == 112)
            {
                Debug.Log(speed + " DONE!");
            }
         

        }

        //energy -= 1;


        // Debug.Log("UPDATE");


    }
}
