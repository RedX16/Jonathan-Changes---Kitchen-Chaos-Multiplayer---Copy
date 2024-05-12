using QFSW.QC.Actions;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour {


    private const string IS_WALKING = "IsWalking";
    private const string DANCE = "Dance";
    private const string DEATH1 = "Death 1";
    private const string DEATH2 = "Death 2";
    private const string DEATH3 = "Death 3";
    private const string FIGHT = "Fight";
    private const string WIN = "Win";



    [SerializeField] private Player player;


    private Animator animator;


    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if (!IsOwner) {
            return;
        }

        animator.SetBool(IS_WALKING, player.IsWalking());

    }

    public void Dance()
    {
        animator.SetTrigger(DANCE);
    }

    public void Death()
    {
        var i = UnityEngine.Random.Range(0, 2);
        switch (i)
        {
            case 0: animator.SetTrigger(DEATH1); break;
            case 1: animator.SetTrigger(DEATH2); break;
            case 2: animator.SetTrigger(DEATH3); break;
        }
    }

    public void Fight()
    {
        animator.SetTrigger(FIGHT);
    }

    public void WinGame()
    {
        animator.SetTrigger(WIN);
    }
}