﻿//generate by code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BigHead.Net;
using Google.Protobuf;
using BigHead.protocol;

public class GCUpdateMapPlayerDataHandler : BasePacketHandler
{
    public override ushort OpCode
    {
        get
        {
            return (ushort)MessageId_Receive.GCUpdateMapPlayerData;
        }
    }

    public override void Handle(object sender, IMessage packet)
    {
        base.Handle(sender, packet);
        GCUpdateMapPlayerData data = packet as GCUpdateMapPlayerData;
        //处理完数据和逻辑后,发送消息通知其他模块,绝对不可以直接操作UI等Unity主线程的东西!
        if (MapMgr.Inited)
        {
            MapMgr.Instance.MyMapPlayer.Update(data.MapPlayerData);
        }

        Messenger.Broadcast(MessageId.MAP_UPDATE_PLAYER_INFO);
    }
}
