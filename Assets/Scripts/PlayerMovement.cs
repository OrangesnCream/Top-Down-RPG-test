using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.AI;
public class PlayerMovement : MonoBehaviour {
    //Dialogue triggers
    private Camera mainCamera;
    RaycastHit2D[] targets=new RaycastHit2D[] {};
    //Player AI 
    private void OnCollisionEnter2D() {
        Debug.DrawRay(transform.position,destination*10f,Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position,destination,10f);
        if (hit) {
            Debug.Log("hitsomething: " + hit.collider.name);
        }
        destination = transform.position;
    }
    NavMeshAgent agent;
    //Mouse Movement
    [SerializeField] private float movementSpeed;
    public Tilemap map;
    MouseInput mouseInput;
    private Vector3 destination;
    private void Awake() {
        mouseInput = new MouseInput();
        mainCamera = Camera.main;
     
    }
    private void OnEnable() {
        mouseInput.Enable();
    }
    private void OnDisable() {
        mouseInput.Disable();
    }
    void Start() {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        mouseInput.Mouse.MouseClick.performed += _ =>MouseClick();
        destination = transform.position; 
        
    }
    private void MouseClick() {
        if (DialogueManager.GetInstance().dialogueIsPlaying) {
            return;
        }
        bool clickTriggered=false;
        Vector2 mousePosition = mouseInput.Mouse.MousePosition.ReadValue<Vector2>();
        Ray ray = mainCamera.ScreenPointToRay(mousePosition);
        //
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //
        RaycastHit2D[] hits2D = Physics2D.GetRayIntersectionAll(ray);
        if (targets == null || targets.Length == 0) {
            Debug.Log("array is empty");
        }
        else {
            Debug.Log("Enter");
            for (int i = 0; i < targets.Length; i++) {
                Debug.Log("Start of for loop");
                if (targets[i].collider != null) {
                    Debug.Log("Null check");
                    IClicked click = targets[i].collider.gameObject.GetComponent<IClicked>();
                    if (click != null) {
                            Debug.Log("onUnClickAction();");
                            click.onUnClickAction();
                    }
                    
                }
            }
        }
        targets = Physics2D.GetRayIntersectionAll(ray);
        Debug.Log("Out of loop");
        for (int i = 0; i < hits2D.Length; i++) {
            Debug.Log("In loop");
            if (hits2D[i].collider != null&& clickTriggered==false) {
                IClicked click = hits2D[i].collider.gameObject.GetComponent<IClicked>();
                if (click != null) {
                    
                    click.onClickAction();
                    clickTriggered=true;
                }
            }
        }

        //tileset check
        Vector3Int gridPosition = map.WorldToCell(mousePosition);
        if (map.HasTile(gridPosition)) {
            destination = mousePosition;
        }
       

    }
    void Update()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying) {
            return;
        }
        if (Vector3.Distance(transform.position, destination) > 0.1f) {
            agent.SetDestination(destination);
           
        }
    }

}
