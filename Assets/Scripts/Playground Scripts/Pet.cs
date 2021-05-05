using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Pet : MonoBehaviour
{
    private int hunger;
    private int happiness;
    private int cleansliness;
    private float moveSpeed = 0.25f;
    private bool isReadyToMove = false;

    public GameObject LeftBounds;
    public GameObject RightBounds;
    public GameObject TopBounds;
    public GameObject BottomBounds;

    private BoxCollider2D boxCollider;

    private void Start() {
        SetCleansliness(100);
        SetHappiness(100);
        SetHunger(100);
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        GetStats();
        StartCoroutine(RunRandomMove());
        
    }

    private void Update() {
        
    }

    // Get stats using unity's way of storing concurrent data
    private void GetStats() {
        
    }

    /**
     * BEGIN GETTERS / SETTERS
     */

    public int GetHunger() {
        return hunger;
    }

    public int GetHappiness() {
        return happiness;
    }

    public int GetCleansliness() {
        return cleansliness;
    }

    public void SetHunger(int hunger) {
        this.hunger = hunger;
    }

    public void SetHappiness(int happiness) {
        this.happiness = happiness;
    }

    public void SetCleansliness(int cleansliness) {
        this.cleansliness = cleansliness;
    }

    /**
     * END GETTERS / SETTERS
     */

    /**
     * BEGIN PET FUNCTIONS
     */

    IEnumerator RunRandomMove() {
        Random rng = new Random();
        while (true) {
            RandomMove();
            yield return new WaitUntil(IsReadyToMove);
            yield return new WaitForSeconds(rng.Next(10, 15));
        }
    }

    public void RandomMove() {
        Random rng = new Random();
        Vector2 randomDirection = new Vector2((float) rng.NextDouble(), (float) rng.NextDouble());

        Vector2 randomMovement = randomDirection * rng.Next(1, 8);

        MoveBy(randomMovement);

    }

    public void MoveBy(Vector3 position) {
        StartCoroutine(LerpBy(position));
    }

    public IEnumerator LerpBy(Vector3 position) {
        isReadyToMove = false;

        gameObject.GetComponent<Rigidbody2D>().velocity = position * moveSpeed;
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = originalPosition + position;

        float distance = (originalPosition - newPosition).sqrMagnitude;
        float moveDuration = distance * moveSpeed;

        Debug.Log(moveDuration);

        float timeElapsed = 0;

        while (timeElapsed < moveDuration) {
            
            if (boxCollider.IsTouching(LeftBounds.GetComponent<BoxCollider2D>())) {
                Debug.Log(newPosition);
                newPosition.x += (LeftBounds.transform.position.x - newPosition.x) * 2;
                Debug.Log(newPosition);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (boxCollider.IsTouching(RightBounds.GetComponent<BoxCollider2D>())) {
                newPosition.x += (RightBounds.transform.position.x - newPosition.x) * 2;

                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y);

            }

            if (boxCollider.IsTouching(TopBounds.GetComponent<BoxCollider2D>())) {
                newPosition.y += (TopBounds.transform.position.y - newPosition.y) * 2;

                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, -gameObject.GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (boxCollider.IsTouching(BottomBounds.GetComponent<BoxCollider2D>())) {
                newPosition.y += (BottomBounds.transform.position.y - newPosition.y) * 2;

                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, -gameObject.GetComponent<Rigidbody2D>().velocity.y);
            }

            timeElapsed += Time.deltaTime;

            yield return null;
        }

        isReadyToMove = true;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Touched");
    }

    public bool IsReadyToMove() {
        return isReadyToMove;
    }

    public static GameObject ObjectAt(Vector3 position) {
        Collider[] colliders;
        if ((colliders = Physics.OverlapSphere(position, 0.25f)).Length > 0) //Presuming the object you are testing also has a collider 0 otherwise
        {
            return colliders[0].gameObject;
        }
        else {
            return null;
        }
    }



    /**
     * END PET FUNCTIONS
     */
}
