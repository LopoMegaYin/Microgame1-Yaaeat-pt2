using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaamon : MonoBehaviour
{
    public float movespeed;
    public float horizontal;
    Rigidbody2D myRigidbody2D;
    public Transform yeemonposition;
    public Sprite[] pic;
    public SpriteRenderer yeemonbody;
    public bool yeemonisEating;
    public Animator animator;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            if (collision.gameObject.CompareTag("meat"))
            {
            animator.SetTrigger("bonehit");
                yeemonisEating = true;
            }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        yeemonposition = GetComponent<Transform>();
        yeemonbody.sprite = pic[0];
        yeemonisEating= false;
    }

    // Update is called once per frame
    void Update()
    {
        Moveyaamon();
        Postionyaamon();
       // Yeemonrating();
    }

    void Moveyaamon()//Yaamon horizontal move command

    {
        horizontal = Input.GetAxis("Horizontal");
        myRigidbody2D.velocity = new Vector2(horizontal * movespeed, 0);
    }

    void Postionyaamon()//Yaamon position limitation
    {
        yeemonposition.position = new Vector3(Mathf.Clamp(yeemonposition.position.x, -5f, 5f), Mathf.Clamp(yeemonposition.position.y, -3f, 10f), yeemonposition.position.z);
    }

    
    void Yeemonrating()//Yeemoneating 
    {
        if (yeemonbody.sprite == pic[1] ) 
        {
            { StartCoroutine(yeemonbodyChange(0.2f)); }
        }
    }
    
    IEnumerator yeemonbodyChange(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        yeemonbody.sprite = pic[0];
        yield break;
    }
}
