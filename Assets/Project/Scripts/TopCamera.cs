using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 25, 7.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}