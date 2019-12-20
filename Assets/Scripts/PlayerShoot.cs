﻿using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    private AudioSource se;
    public AudioClip sound;
    private GameObject bullet;
   private GameObject trg;
    public float speed = 1000f;

    public bool attack = false;

    private GameObject player;
    //private GameObject camera;
    FlagsInStageManager flagsInStageManager;
    private Animator animator;
    private PlayerMove playerMove;
   // private CameraControl cameracontrol;
    private Transform rifle;
    private float time = 0f;    //経過時間
    public float interval = 0.1f;   //何秒おきに発砲するか

    //AudioSouceコンポーネントを取得
    //  public AudioSource sound;
    //Audioファイルを代入
    //   public AudioClip shotSound; //発砲音を代入

    void Start()
    {
        //     sound = this.gameObject.GetComponent<AudioSource>();    //Audio Sourceコンポーネントを代入
        player = GameObject.Find("player");
        //  camera_s = GameObject.Find("CameraDammy");
        //trg = GameObject.Find("trigger");
        trg = gameObject.transform.Find("TrgObj").gameObject;
        playerMove = player.GetComponent<PlayerMove>();
        rifle = player.transform;
        //cameracontrol = camera_s.GetComponent<CameraControl>();
        flagsInStageManager = GameObject.Find("GameControlObject").GetComponent<FlagsInStageManager>();
        animator = GetComponent<Animator>();
        se = gameObject.GetComponent<AudioSource>();
        se.loop = false;
        bullet = Resources.Load("FireMagic1") as GameObject;
    }

    void Update()
    {
        if (time >= interval)
        {
              if (Input.GetAxis("Attack") == 1 && attack == false)
        {
                if(flagsInStageManager.batleMode == true)
                {
                    animator.SetTrigger("isAttacking");

                    ShootTama();    //発砲
                    attack = true;
                    time = 0f;  //初期化
                }
   


            }
            else if(Input.GetAxis("Attack") == 0)
        {
            attack = false;
          
        }
     //   Debug.Log(Input.GetAxis("Atack"));
           // animator.SetTrigger("isAttacking");


        }
      
    }

    void FixedUpdate()
    {
        if (flagsInStageManager.gameClear == false && flagsInStageManager.gameOver == false && flagsInStageManager.talkMode != 0)
        {
            time += Time.deltaTime; //経過時間を加算

            if (attack == true)
            {


            
            }
        }

        /*
        playerMove.moveDirection.y = 0.0f;
        playerMove.addDirectionMaxInAir = playerMove.moveDirection.magnitude;
        playerMove.isSpiderController.Move(playerMove.moveDirection);
        */
    }
    //発砲関数
    void ShootTama()
    {
        transform.LookAt(new Vector3(playerMove.targetEnemyPosition.transform.position.x, 0.0f, playerMove.targetEnemyPosition.transform.position.z));

        for (int i = 0; i < 3; i++)
        {
            GameObject obj = GameObject.Instantiate(bullet) as GameObject;
              se.PlayOneShot(sound);
            obj.transform.position = trg.transform.position;
            //   obj.GetComponent<Rigidbody>().AddForce(rifle.forward * speed);    //銃の向きが元から反転しているため、併せてforwardも反転させる

            // transform.LookAt(bullet.transform.position);
            interval = 1.0f;

            //  player.transform.eulerAngles = new Vector3(0.0f, cameracontrol.trueDammyCamRotate.y, 0.0f);
        }


    }



}
