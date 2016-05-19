﻿using UnityEngine;

namespace Assets.Scripts.Fuzzy.StateMachine
{
    public interface IState
    {
        string Name { get; }
        string DebugString { get; }
        Fsm Fsm { get; }

        // Fuzzy States can have multiple StateBehaviours
        void AddBehaviour(IStateBehaviour behaviour);
        // Evaluate FuzzySet and changes the FSM Current State
        // This base method should be used as a generic handler
        void PreUpdate();
        void Enter(string lastStateName, string nextStateName, float additionalDeltaTime, params object[] args);
        void FixedUpdate();
        void Exit(string lastStateName, string nextStateName, float additionalDeltaTime, params object[] args);
        void OnTriggerEnter(Collider collider);
        void OnCollisionEnter(Collision collision);


    }
}