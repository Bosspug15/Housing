
using UnityEngine;

public class SphereController : MonoBehaviour, IDrag
{

    private Rigidbody2D rb;
    public GameObject paperTest;
    [SerializeField] private Collider2D trash;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == trash)
        {
            Debug.Log("enter");
            Destroy(paperTest);
            
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;


        //rb.useGravity = false;
        
    }
    public void onEndDrag()
    {
        rb.velocity = Vector3.zero;
    }

    public void onStartDrag()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;

        
    }
}
