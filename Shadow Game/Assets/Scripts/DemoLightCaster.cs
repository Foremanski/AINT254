using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoLightCaster : MonoBehaviour
{
    //any object that will be affected by the light
    public GameObject[] sceneObjects;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sets the location of the light
        Vector3 myloc = this.transform.position;

        //goes through each affected object
        for(int i = 0; i < sceneObjects.Length; i++)
        {
            //set the mesh for the current scene object
            Vector3[] mesh = sceneObjects[i].GetComponent<MeshFilter>().mesh.vertices;

            for (int j = 0; j <mesh.Length; j++)
            {

                Vector3 vertloc = sceneObjects[i].transform.localToWorldMatrix.MultiplyPoint3x4(mesh[j]);
                RaycastHit hit;

                //determines where raycast will be shot from
                Physics.Raycast(myloc, vertloc - myloc, out hit, 100);
                
                //draws raycast
                Debug.DrawLine(myloc, hit.point, Color.red);
            }
        }
    }
}
