using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    private int hunger;
    private int happiness;
    private int cleansliness;

    private void Start() {
        GetStats();
    }

    private void Update() {
        
    }

    // Get stats using unity's way of storing concurrent data
    private void GetStats() {
        throw new NotImplementedException();
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

    public void Bathe() {
        throw new NotImplementedException();
    }

    public void Feed() {
        throw new NotImplementedException();
    }

    /**
     * END PET FUNCTIONS
     */
}
