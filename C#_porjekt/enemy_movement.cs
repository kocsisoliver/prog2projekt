using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour 
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex= 0;
    //public int waypoint.points.Length;
    //public int number = waypoint.points.Length;

    private void Start()
    {
        target = waypoint.points[0];
    }


    private void Update()
    {
        //mozgat�s waypoint-ra
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //tov�bb menjen a k�vetkez� waypoint-ra
        //0.2 egys�ggel k�zel�be �r akkor v�ltson a k�vetkez� targetre(waypoint) 
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNewWaypoint();

        }
    }

        void GetNewWaypoint()

        {
            if (wavepointIndex >= waypoint.points.Length - 1)
            {
                Destroy(gameObject);
                return;
            }
            
            //n�veli az indexet ami meg adja hanyadik az �j target
            wavepointIndex++;
            target = waypoint.points[wavepointIndex];
        
        }








    









}