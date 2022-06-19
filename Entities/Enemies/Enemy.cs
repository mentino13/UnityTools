using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Starting Stats:

    // Static Stats:
    public string enemyName;
    public int enemyTimeToLive;

    //  Dynamic Stats:
    public int startHitPoints;
    public float startMovementSpeed;
    public int startDamage;
    public float startAttackSpeed;

        // Current Stats:
        public int currentHitPoints;
        public float currentMovementSpeed;
        public int currentDamage;
        public float currentAttackSpeed;



    void Start(){
        this.currentHitPoints = this.startHitPoints;
        this.currentMovementSpeed = this.startMovementSpeed;
        this.currentDamage = this.startDamage;
        this.currentAttackSpeed = this.startAttackSpeed;

        StartCoroutine(enemyLifeCountDown());
    }


    public void checkHitPoints(){
        if (currentHitPoints <= 0){
            Debug.Log("Enemy Destroyed!");
            Destroy(this.gameObject);
            Player player = GameObject.FindObjectOfType<Player>();
            
            player.currentScore += 1;
        }
    }

    IEnumerator enemyLifeCountDown(){
        yield return new WaitForSeconds(enemyTimeToLive);
        Destroy(this.gameObject);
    }


}
