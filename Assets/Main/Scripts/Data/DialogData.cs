﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 一条对话的数据
/// </summary>
public class DialogData
{
    int index;
    int head;
    int showMode;
    int content;
    int action;
    int actionParam;

    public int Head
    {
        get
        {
            return head;
        }
    }

    public int ShowMode
    {
        get
        {
            return showMode;
        }
    }

    public int Content
    {
        get
        {
            return content;
        }
    }

    public int Action
    {
        get
        {
            return action;
        }
    }

    public int ActionParam
    {
        get
        {
            return actionParam;
        }
    }

    public int Index
    {
        get
        {
            return index;
        }
    }

    public DialogData(int index, int head, int showMode, int content, int action, int actionParam)
    {
        this.index = index;
        this.head = head;
        this.showMode = showMode;
        this.content = content;
        this.action = action;
        this.actionParam = actionParam;
    }
}
