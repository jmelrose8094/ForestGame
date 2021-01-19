using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CodeMonkey.Utils;

public class Enemy : MonoBehaviour
{
    public int health, damage;
    public float moveSpeed;
    

    private Vector3 startingPosition;
    private Vector3 roamPosition;

    //private EnemyPathfindingMovement pathfindingMovement;
    private enum State
    {
        Roaming,
        ChaseTarget,
        Locked
    }
    private State state = State.Locked;

    public Enemy()
    {
    }

    public Enemy(int h, int d, float s)
    {
        health = h;
        damage = d;
        moveSpeed = s;
        state = State.Locked;
    }

    private void Start()
    {
        startingPosition = transform.position;
        roamPosition = GetRoamingPosition();
    }

    private Vector3 GetRoamingPosition()
    {
        return startingPosition + UtilsClass.GetRandomDir() * Random.Range(10f, 70f);
    }

    private void Update()
    {
        
        switch (state)
        {
            case State.Locked:
                RunLocked();
                break;
            case State.ChaseTarget:
                RunChaseTarget();
                break;
            case State.Roaming:
                RunRoaming();
                break;

        }
    }

    public int GetHealth()
    {
        return health;
    }
    public int GetDamage()
    {
        return damage;
    }

    private void RunLocked()
    {

    }
    private void RunChaseTarget()
    {
       // pathfindingMovement.MoveToTimer(Player.Instance.GetPosition());
        
    }

    private void FindTarget()
    {
        /*float targetRnage = 50f;
        if (Vector3.Distance(transform.position, Player.Instance.GetPosition()) < targetRange)
        {
            state = State.ChaseTarget();
        }
		*/
    }
    private void RunRoaming()
    {
        /*pathfindingMovement.MoveTo(roamPosition);
        float reachedPositionDistance = 1f;
        if (Vector3.Distance(transform.position, roamPosition) < reachedPositionDistance)
        {
            roamPosition = GetRoamingPosition();
        }
        FindTarget();
		*/
    }

    public void SubtractFromHealth(int dmg)
    {
        health = health - dmg;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
