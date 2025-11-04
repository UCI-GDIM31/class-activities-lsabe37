using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Transform target;


    public void chasePlayer()
    {
        if (transform.position != target.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    public void stopChase()
    {
        this.enabled = false;
    }
}
