using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed, jumpHeight;
    public LayerMask groundLayers;
    private Rigidbody2D m_rb;
	private Vector2 DirInput;

    private HashSet<Skill> skillSet;

    void Start()
	{
        //initialize skills and bodyParts dictionary
        skillSet = new HashSet<Skill>();

        //create reference to rb
		m_rb = GetComponent<Rigidbody2D>();
	}
    
	void Update()
 	{
        MoveCharacter();
	}
    

    //Moving Logic

    public bool IsMoving()
    {
        DirInput = PlayerInput.GetDirectionalInput();
        return DirInput != Vector2.zero;
    }

    private bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = Constants.GROUND_DISTANCE;

        //Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayers);
        return hit.collider != null;
    }

    private void MoveCharacter()
    {
        if (IsMoving())
        {
            m_rb.velocity = new Vector2(DirInput.x * speed, m_rb.velocity.y);
        }

        if (PlayerInput.WasSpacePressed() && hasSkill(Skill.Jump) && IsGrounded())
        {
            Jump();
        }
    }

    private void Jump()
    {
        m_rb.velocity = new Vector2(m_rb.velocity.x, jumpHeight);
    }

    //Skills
    private void addSkill(Skill s)
    {
        skillSet.Add(s);
    }

    public bool hasSkill(Skill s)
    {
        return skillSet.Contains(s);
    }

    private void activateLeg()
    {
        GameObject legObj = transform.Find(Constants.LEG).gameObject;
        if (legObj)
        {
            legObj.SetActive(true);
            addSkill(Skill.Jump);
        }
    }

    private void activateEyes()
    {
        GameObject eyeObj = transform.Find(Constants.EYES).gameObject;
        GameObject browObj = transform.Find(Constants.BROW).gameObject;
        if (eyeObj && browObj)
        {
            eyeObj.SetActive(true);
            browObj.SetActive(true);
        }
    }

    private void activateHand()
    {
        GameObject handObj = transform.Find(Constants.HAND).gameObject;
        if (handObj)
        {
            handObj.SetActive(true);
            addSkill(Skill.Grab);
        }
    }


    private void instantiateEyes()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case Constants.LEG_ACTIVATOR:
                //obtain legs
                activateLeg();
                break;
            case Constants.EYE_ACTIVATOR:
                //obtain eyes
                activateEyes();
                break;
            case Constants.HAND_ACTIVATOR:
                activateHand();
                break;
            case Constants.BALLOON:
                //m_rb.gravityScale = 0.0f;
                //m_rb.AddForce(Vector2.left * 500f);
                break;
            default:
                //do nothing
                break;
        }
    }
}
