using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour
{
    private int count;
    private Rigidbody rb;
    public float speed = 3.0F;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void Update()
    {

        float verTranslation = Input.GetAxis("Vertical") * speed;
        float horTranslation = Input.GetAxis("Horizontal") * speed;
        verTranslation *= Time.deltaTime;
        horTranslation *= Time.deltaTime;
        float translation = Time.deltaTime * 6;
        transform.Translate(horTranslation,verTranslation , translation);
        
    }

    /*void OnTriggerEnter(Collider other)
    {

       
        if (other.gameObject.CompareTag("pin"))
        {
            Destroy(other.gameObject);
            // other.gameObject.SetActive(false);

        }
       
    }
*/
   

}