using UnityEngine;

public class PlayerMovementSimple : MonoBehaviour
{

    //[SerializeField]
    //private bool InputX;
    //[SerializeField]
    //private bool InputY;

    public Transform playerPosition;
    public float moveMultiplier; // liikkeen vauhtikerroin
    float horizontal;
    float vertical;

    int Calculator(int number, int number2)
    {


        return number + number2;
    }
    string Speaker(string word)
    {
        return word + " on päivän sana";
    }

    void Looper(int counter)
    {
        for (int i = 0; i < 100; i++)
        {
            counter += i;
            Debug.Log(counter);
        }

        // Kasvattaa lukua yhdellä. Sama kuin counter+=1;

        Debug.Log(counter);

        if (counter > 100)
        {
            Debug.Log(counter + " DONE");
        }
        // return counter;
    }

    void PlayerMoveControl()
    {
        // InputX = Input.GetKey(KeyCode.A); // Sivulle
        // InputY = Input.GetKey(KeyCode.W); // Ylös
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        playerPosition.position += new Vector3(
            horizontal * moveMultiplier * Time.deltaTime,
            vertical * moveMultiplier * Time.deltaTime, 0);
        // X:lle ja Y:lle annetaan päivittyvä arvo. Z:aa ei tarvita, joten on 0.
    }
    void Start()
    {
        Looper(0);
        // Ekassa framessa ajetaan nämä vain kerran:
        // Debug.Log(Calculator(1000, 3000));
        // Debug.Log(Speaker("Yippiyaiyee"));
    }
    void Update()
    {

        PlayerMoveControl();

    }
}
