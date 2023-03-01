using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float WaitTime = 3f;
    public float Speed = 5f;
    public Vector3 PositionDelta = Vector3.zero;



    private Vector3 _closedPosition;
    private Vector3 _openPosition;
//thing

    // Start is called before the first frame update
    void Start()
    {
        _closedPosition = transform.position;
        _openPosition = _closedPosition + PositionDelta;

        StartCoroutine(OpenClose());
    }

    // Update is called once per frame
    //void Update()
    //{
     //   transform.position = Vector3.MoveTowards(transform.position,_openPosition,Speed * Time.deltaTime);
    //}

    IEnumerator OpenClose()
    {
        Vector3 goal = _openPosition;
        bool isOpen = false;

        //yield return new WaitForSeconds(WaitTime);

        while(true)
        {
            if(Vector3.Distance(transform.position, goal) < 0.1f)
            {
                isOpen = !isOpen;
                if(isOpen)
                {
                    goal = _closedPosition;
       
                }
                else
                {
                    goal = _openPosition;
                }   

                yield return new WaitForSeconds(WaitTime);
            }
            else
            {

                transform.position = Vector3.MoveTowards(transform.position,goal,Speed * Time.deltaTime);

                yield return null;//waits a single frame
            }
        }  
    }
      
    

     
    
}
