using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollableGround : MonoBehaviour
{
    public List<GameObject> groundObjects;

    public void rollTheGround(int identifier)
    {
        groundObjects[identifier - 1].transform.position = groundObjects[identifier % 2].transform.position + new Vector3(0, 0, 60);
    }
}
