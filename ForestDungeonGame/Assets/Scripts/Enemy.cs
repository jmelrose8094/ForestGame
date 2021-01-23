using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CodeMonkey.Utils;

public class Enemy : MonoBehaviour
{
    public int health, damage;
    public float moveSpeed;
    public RectTransform Player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float targetRange = 5;


    private enum State
    {
        Roaming,
        ChaseTarget,
        Locked,
        Shoot
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
        state = State.ChaseTarget;
    }

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        state = State.ChaseTarget;
        Player = GameObject.Find("Player").GetComponent<RectTransform>();
    }


    private void Update()
    {

        if (targetRange >= Vector3.Distance(Player.position, transform.position))
        {
            state = State.Shoot;
        }
        else
        {
            state = State.ChaseTarget;
        }
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
            case State.Shoot:
                ShootPlayer();
                break;

        }
    }

    private void FixedUpdate()
    {
        switch (state)
        {
            case State.ChaseTarget:
                MoveCharacter(movement);
                break;
        }
        //MoveCharacter(movement);
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
        Vector3 direction = Player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        MoveCharacter(movement);
    }

    private void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    private void FindTarget()
    {
        /*float targetRnage = 50f;
        if (Vector3.Distance(transform.position, Player.Instance.GetPosition()) < targetRange)
        {
            state = State.ChaseTarget();
        }*/
    }
    private void RunRoaming()
    {
        
    }
    private void ShootPlayer()
    {

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
