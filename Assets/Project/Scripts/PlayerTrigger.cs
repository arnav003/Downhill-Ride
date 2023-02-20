using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public RollableGround rollableGround;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "End Trigger")
        {
            rollableGround.rollTheGround(int.Parse(other.GetComponent<Transform>().parent.gameObject.name));
        }
        gameManager.checkpointTriggered();
    }

}
