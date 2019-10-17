using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{

    IEnumerator Routine()
    {
        while (true)
        {

            //creates an array of rigidbodies to apply gravity to
            Rigidbody[] Rigidbodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

            for( int x = 0; x < Rigidbodies.Length;x++)
            {
                yield return new WaitForSeconds(0);
                for (int y = 0; y < Rigidbodies.Length; y++)
                {
                    if (x != y)
                    {
                        Rigidbodies[x].AddForce((Rigidbodies[y].gameObject.transform.position 
                        - Rigidbodies[x].transform.position) 
                        * (Rigidbodies[y].mass 
                        / Vector3.Distance(Rigidbodies[x].transform.position, Rigidbodies[y].transform.position)));
                        yield return new WaitForSeconds(0);
                    }
                    
                    //checks to see if the rigidbody is close to the planet 
                    //if(Rigidbodies[x] )
                }
            }
            yield return new WaitForSeconds(0);
        }
    }

    void Awake()
    {
        StartCoroutine(Routine());
    }
}
