using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public Transform leftLocation;
    public Transform middleLocation;
    public Transform rightLocation;
    public Button leftButton;
    public Button rightButton;
    public bool comesFromTheMiddle;
    private Transform[] locations;
    private int targetLocationIndex = 1; // Start at the middle location
    public float speed;
    private void Start()
    {
        locations = new Transform[] { leftLocation, middleLocation, rightLocation };

        leftButton.onClick.AddListener(MoveLeft);
        rightButton.onClick.AddListener(MoveRight);

        // Snap character to the middle location at the start
        transform.position = middleLocation.position;
        comesFromTheMiddle = true;
    }

    private void MoveLeft()
    {
        if (comesFromTheMiddle)
        {
            targetLocationIndex = 0; // move from middle to left

        }
        else
        {
            targetLocationIndex = 1; // go to middle from left

        }
        StartCoroutine(SlideToPosition(locations[targetLocationIndex].position));
    }

    private void MoveRight()
    {
        if (comesFromTheMiddle)
        {
            targetLocationIndex = 2; // move from middle to right

        }
        else
        {
            targetLocationIndex = 1; // move to middle from left

        }
        StartCoroutine(SlideToPosition(locations[targetLocationIndex].position));
    }

    private IEnumerator SlideToPosition(Vector3 targetPosition)
    {
        while ((transform.position - targetPosition).sqrMagnitude > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
            yield return null;
        }
        transform.position = targetPosition;

    }

    private void Update()
    {
        if (transform.position == middleLocation.position)
        {
            comesFromTheMiddle = true;
        }
        if (transform.position == leftLocation.position)
        {
            if (comesFromTheMiddle)
            {
                transform.position = rightLocation.position;
                comesFromTheMiddle = false;
                MoveLeft();

            }
        }
        if (transform.position == rightLocation.position)
        {
            if (comesFromTheMiddle)
            {
                transform.position = leftLocation.position;
                comesFromTheMiddle = false;
                MoveRight();

            }
        }
    }

}
