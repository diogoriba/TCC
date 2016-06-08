﻿using UnityEngine;


public class AnimationBehaviour : BaseBehaviour
{
    public Animator Animator { get; protected set; }

    public string Name { get; set; }
    public float TotalTime { get; set; }
    public float PlayTime { get; set; }
    public float CrossFadeTime { get; set; }

    public AnimationBehaviour(IState state, Animator animator) : base(state)
    {
        BehaviourName = "AnimationBehaviour";
        Name = "";
        Animator = animator;
        TotalTime = 1f;
        PlayTime = 1f;
        CrossFadeTime = 0.1f;
    }
    public override void Enter(string lastStateName, string nextStateName, float additionalDeltaTime = 0f, params object[] args)
    {
        base.Enter(lastStateName, nextStateName, additionalDeltaTime, args);
        Animator.SetFloat("Speed", PlayTime / TotalTime);
        if (Name != "")
        {
            Animator.CrossFade(Name, CrossFadeTime);
        }
    }
}

