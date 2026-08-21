using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 startPoint;
    public Transform endPoint;
    public float speed = 2.0f;
    private Vector3 targetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = transform.position;
        targetPosition = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Bevæger platformen mod dens target med en hastighed der hedder speed*Time.deltaTime.
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed*Time.deltaTime);
        
        //Vi tjekker om platformen har nået målet og koden nedenunder kører kun, hvis vi når vores mål
        if(Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == endPoint.position) //Hvis vores mål er at nå endPoint.position - så ændrer vi nu vores nye mål til vores startposition. 
            {
                targetPosition = startPoint;
            }
            else //Hvis vores mål IKKE var endPoint.position og dermed altså at nå startposition - så ændrer vi nu vores nye mål til vores endPoint.position..
            {
                targetPosition = endPoint.position;
            }

        }

    }
}
