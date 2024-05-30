using UnityEngine;

public class NPCtrigger : MonoBehaviour
{

    // NPCcontrol fetchedData;
    void Start()
    {
        //fetchedData = GetComponent<NPCcontrol>();
        //fetchedData.canGrow = false; 
    }
    //----------------------------------
    // Törmäyksen tunnistus 1.vaihtoehto:
    // isTrigger pitää olla aktivoituna törmättävän GameObjectin Colliderissa + Tag oltava tässä Player
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision != null)
    //    {
    //        if(collision.gameObject.CompareTag("Player"))
    //        {
    //            gameObject.SetActive(false);    
    //        }

    //    }
    //}
    //----------------------------------
    // Törmäyksen tunnistus 2.vaihtoehto:
    // isTrigger:iä ei tarvita tässä mutta Tag oltava Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //gameObject.SetActive(false);    // Kevyempi vaihtoehto piilottaa gameObject.GameObject, missä tämä koodi on.
                                                // SetActive(true) palauttaa sen, jos koodi luetaan muualta.
            Destroy(gameObject);                // Raskaampi, GameObject poistetaan muistista eikä ole enää käytössä
                                                // ellei sitä luoda uudelleen pelisession aikana Instantiate-käskyllä
        }
    }


}
