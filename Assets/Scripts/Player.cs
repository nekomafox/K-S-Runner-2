using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int _speed;
    public int _jumpForce;

    public bool DefeatGame;
    public GameObject defeatMenu;
    public Text scoreText;

    private Rigidbody2D _rb;
    private bool _isJump;
    public float score = 0f;

    [SerializeField] private AudioSource audioJump;
    
    [SerializeField] private AudioSource audioDie;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && _isJump == true)
        {
            Vector2 direction = new Vector2(0, 5f)*_jumpForce;
            _rb.AddForce(direction,ForceMode2D.Impulse);
            _isJump = false;
            audioJump.Play();
        }

        scoreText.text = "" + score;
        
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_speed, _rb.velocity.y);
        score += 1;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isJump = true;
            

        }

        if (collision.gameObject.tag == "Enemy")
        {
            audioDie.Play();
            Defeat();
        }


    }

    public void Defeat()
    {
        
        defeatMenu.SetActive(true);
        Time.timeScale = 0f;
        DefeatGame = true;

    }
}
