using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class NavMeshController: MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;
    public GameObject DragonTarget;

    bool isWalking = true;
    private Animator animator;
    public float speed = 3f;

    //Start is called before the first frame
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        animator.speed = agent.speed / speed;
        if (isWalking)
        {
            agent.destination = Target.transform.position;
        }
        else
        {
            transform.LookAt(DragonTarget.transform);
            agent.destination = transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.name == "Dragon")
        {
            isWalking = false;
            animator.SetTrigger("ATTACK");
        }
        else if (other.gameObject.name == "Emerald" || other.gameObject.name == "Coin" || other.gameObject.name == "Ruby")
        {
            Debug.Log("hit1");
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Dragon")
        {
            isWalking = true;
            animator.SetTrigger("WALK");
        }
    }

    private void OnCollisionEnter(Collision col)
    {


    }

}
