using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_CharacterBehaviour : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(inputX,inputY,0) * moveSpeed * Time.deltaTime; 
    }
}
