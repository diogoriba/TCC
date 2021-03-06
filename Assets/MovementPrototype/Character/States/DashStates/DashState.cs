﻿using UnityEngine.Assertions;

namespace Assets.MovementPrototype.Character.States.DashStates
{
    public class DashState : ProxyState
    {
        const float speed = 16f;
        public DashState(CharFsm fsm) : base(fsm)
        {
            Name = "DASH";
        }
        public override void Enter(string lastStateName, string nextStateName, float additionalDeltaTime, params object[] args)
        {
            Assert.IsTrue(args.Length == 1);
            var evt = args[0] as InputEvent.Dash;
            Assert.IsNotNull(evt);
            Character.DashVelocity = evt.Move.vector.normalized * speed;
            Fsm.ChangeState("DASH/ACCEL");
        }
    }
}