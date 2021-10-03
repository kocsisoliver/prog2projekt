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
        //mozgatás waypoint-ra
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //tovább menjen a következõ waypoint-ra
        //0.2 egységgel közelébe ér akkor váltson a következõ targetre(waypoint) 
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
            
            //növeli az indexet ami meg adja hanyadik az új target
            wavepointIndex++;
            target = waypoint.points[wavepointIndex];
        
        }








    









}