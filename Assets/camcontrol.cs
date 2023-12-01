using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class camcontrol : MonoBehaviour
{
    [SerializeField] public CinemachineVirtualCamera cam1;
    [SerializeField] public CinemachineVirtualCamera cam2;
    [SerializeField] public CinemachineVirtualCamera cam3;
    [SerializeField] public CinemachineVirtualCamera cam31;
    [SerializeField] public CinemachineVirtualCamera cam4;
    [SerializeField] public CinemachineVirtualCamera cam5;
    [SerializeField] public CinemachineVirtualCamera cam6;

    private GameObject pcam1 ;
    private GameObject pcam2 ;
    private GameObject pcam3 ;
    private GameObject pcam31 ;
    private GameObject pcam4 ;
    private GameObject pcam5 ;
    private GameObject pcam6 ;
    private GameObject window ;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pcam1 = GameObject.Find("cam1");
        pcam2 = GameObject.Find("cam2");
        pcam3 = GameObject.Find("cam3");
        pcam31 = GameObject.Find("cam3.1");
        pcam4 = GameObject.Find("cam4");
        pcam5 = GameObject.Find("cam5");
        pcam6 = GameObject.Find("cam6");
        window = GameObject.Find("windowcorreta");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name=="aux"){
            pcam1.SetActive(false);
            pcam2.SetActive(true); 
        }
        if(collision.gameObject.name=="aux (1)"){
            pcam2.SetActive(false);
            pcam3.SetActive(true); 
        }
        if(collision.gameObject.name=="aux (2)"){
            pcam3.SetActive(false);
            pcam2.SetActive(true); 
        }
        if(collision.gameObject.name=="aux (3)"){
            pcam2.SetActive(false);
            pcam31.SetActive(true); 
        }
        if(collision.gameObject.name=="aux (4)"){
            pcam31.SetActive(false);
            pcam4.SetActive(true); 
            rb.drag = 0;
        }
        if(collision.gameObject.name=="aux (4)"){
            pcam31.SetActive(false);
            pcam4.SetActive(true); 
            rb.drag = 0;
            
            StartCoroutine(ExampleCoroutine());
            
        }
        

    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
       

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        window.SetActive(false);
        pcam4.SetActive(false);
        pcam5.SetActive(true); 
        StartCoroutine(ExampleCoroutine1());
        
    }
    IEnumerator ExampleCoroutine1()
    {
        //Print the time of when the function is first called.
       

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);

        //After we have waited 5 seconds print the time again.
       
        pcam5.SetActive(false);
        pcam6.SetActive(true); 
        
    }
}
