﻿using UnityEngine;

namespace Assets.MovementPrototype.Character.States.AttackStates.Left
{
    public class LeftHeavySwing : AttackState
    {
        const float speed = 2f;
        public LeftHeavySwing(AttackFsm fsm) : base(fsm)
        {
            Name = "LEFT/HEAVY/SWING";
            nextState = "LEFT/HEAVY/RECOVER";
            totalTime = 0.2f;
            damage = 2;
        }

        public override void Enter(string lastStateName, string nextStateName, float additionalDeltaTime, params object[] args)
        {
            base.Enter(lastStateName, nextStateName, additionalDeltaTime, args);
            Character.animator.SetFloat("Speed", 1f / totalTime);
            Character.animator.Play("Swing");
            Character.SwordTrail.Activate();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            Character.Move(Transform.position + ((Transform.forward * speed) * Time.fixedDeltaTime));

        }
    }
}
