using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Enemy>();

        StartCoroutine("Move");
        
    }

    // Update is called once per frame
    void Update()
    {
        // Simplemente el enemigo irá avanzando hacia adelante a velocidad constante. 
        // Mediante la función Move, éste irá rotando.
        transform.Translate(Vector3.forward * enemy.currentMovementSpeed * Time.deltaTime);
        
        //transform.Translate(randomizeMovement() * enemy.currentMovementSpeed * Time.deltaTime);
    }

    // La funcion Move hará que cada 3.5 segundos el enemigo rote 180 grados.
    IEnumerator Move(){
        while (true){
            yield return new WaitForSeconds (3.5f);
            transform.eulerAngles += new Vector3 (0, 90f, 0);
        }
    }


    
    private Vector3 randomizeMovement(){
        float randomX;
        float randomY;
        float randomZ;

        randomX = Random.Range(-10, 10);
        randomY = Random.Range(-10, 10);
        randomZ = Random.Range(-10, 10);

        Vector3 vector3 = new Vector3(randomX, randomY, randomZ);
        
        new WaitForSeconds(3);

        return vector3;
    }

}
