using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorPrefabs : MonoBehaviour
{
    public GameObject prefabGameObject; // объект для клонирования
    public Material prefabMaterialA; // Материал А
    public Material prefabMaterialB; // Материал Б
    void Update()
    {
        if(Input.GetMouseButton(0))
        {

            GameObject newGameObject = Instantiate(prefabGameObject, transform.position, transform.rotation);
            newGameObject.transform.localScale = Vector3.one * Random.Range(0.5f,1f);

            if (Random.Range(0, 2) == 0)
            {
                newGameObject.GetComponent<Renderer>().material = prefabMaterialA;
            }
            else
            {
                newGameObject.GetComponent<Renderer>().material = prefabMaterialB;
            }
            //Instantiate(prefabGameObject, transform.position, transform.rotation, transform);

            //for (int i = 0; i < 500; i++)
            //{
            //    Instantiate(prefabGameObject);
            //}
        }
    }
}
