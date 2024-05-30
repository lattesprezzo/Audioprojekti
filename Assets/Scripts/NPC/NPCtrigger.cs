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
    // T�rm�yksen tunnistus 1.vaihtoehto:
    // isTrigger pit�� olla aktivoituna t�rm�tt�v�n GameObjectin Colliderissa + Tag oltava t�ss� Player
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
    // T�rm�yksen tunnistus 2.vaihtoehto:
    // isTrigger:i� ei tarvita t�ss� mutta Tag oltava Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //gameObject.SetActive(false);    // Kevyempi vaihtoehto piilottaa gameObject.GameObject, miss� t�m� koodi on.
                                                // SetActive(true) palauttaa sen, jos koodi luetaan muualta.
            Destroy(gameObject);                // Raskaampi, GameObject poistetaan muistista eik� ole en�� k�yt�ss�
                                                // ellei sit� luoda uudelleen pelisession aikana Instantiate-k�skyll�
        }
    }


}
