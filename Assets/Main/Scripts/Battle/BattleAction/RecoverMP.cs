using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class RecoverMP : BattleActionBase
    {
        public BattleActionType ActionType { get { return BattleActionType.RecoverMP; } }
        public override void Excute()
        {
            throw new System.NotImplementedException();
        }
    }
}