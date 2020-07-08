using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameEvent hitGround;
    public GameEvent hitGoal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hitGround.Raise();

            Destroy(this.gameObject, 1);
        }
        if (collision.gameObject.CompareTag("Goal"))
        {
            hitGoal.Raise();
            Destroy(this.gameObject, 1);

        }
    }


}
