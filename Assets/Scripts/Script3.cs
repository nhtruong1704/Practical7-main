using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public GameObject prefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
         MeshRenderer m = Instantiate(prefab, transform.position, Quaternion.identity).GetComponent<MeshRenderer>();
            m.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
