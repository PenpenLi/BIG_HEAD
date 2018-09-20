// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 2010_CGMapApplyEffect.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 2010_CGMapApplyEffect.proto</summary>
  public static partial class CGMapApplyEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for 2010_CGMapApplyEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CGMapApplyEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChsyMDEwX0NHTWFwQXBwbHlFZmZlY3QucHJvdG8iaQoQQ0dNYXBBcHBseUVm",
            "ZmVjdBIRCglwbGF5ZXJfaWQYASABKAQSDgoGYWN0aW9uGAIgASgFEg0KBXBh",
            "cmFtGAMgASgFEg4KBnBhcmFtMhgEIAEoBRITCgttYXBfY2FyZF9pZBgFIAEo",
            "BUJMCh1jb20ud2hhbGVpc2xhbmQuZ2FtZS5wcm90b2NvbEIYQ0dNYXBBcHBs",
            "eUVmZmVjdFByb3RvY29sqgIQQmlnSGVhZC5wcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.CGMapApplyEffect), global::BigHead.protocol.CGMapApplyEffect.Parser, new[]{ "PlayerId", "Action", "Param", "Param2", "MapCardId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 在地图上使用消耗品
  /// </summary>
  public sealed partial class CGMapApplyEffect : pb::IMessage<CGMapApplyEffect> {
    private static readonly pb::MessageParser<CGMapApplyEffect> _parser = new pb::MessageParser<CGMapApplyEffect>(() => new CGMapApplyEffect());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CGMapApplyEffect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.CGMapApplyEffectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapApplyEffect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapApplyEffect(CGMapApplyEffect other) : this() {
      playerId_ = other.playerId_;
      action_ = other.action_;
      param_ = other.param_;
      param2_ = other.param2_;
      mapCardId_ = other.mapCardId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapApplyEffect Clone() {
      return new CGMapApplyEffect(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private ulong playerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 2;
    private int action_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 3;
    private int param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 4;
    private int param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    /// <summary>Field number for the "map_card_id" field.</summary>
    public const int MapCardIdFieldNumber = 5;
    private int mapCardId_;
    /// <summary>
    ///这个参数来自对话框传递
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MapCardId {
      get { return mapCardId_; }
      set {
        mapCardId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CGMapApplyEffect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CGMapApplyEffect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Action != other.Action) return false;
      if (Param != other.Param) return false;
      if (Param2 != other.Param2) return false;
      if (MapCardId != other.MapCardId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0UL) hash ^= PlayerId.GetHashCode();
      if (Action != 0) hash ^= Action.GetHashCode();
      if (Param != 0) hash ^= Param.GetHashCode();
      if (Param2 != 0) hash ^= Param2.GetHashCode();
      if (MapCardId != 0) hash ^= MapCardId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PlayerId);
      }
      if (Action != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Action);
      }
      if (Param != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Param);
      }
      if (Param2 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Param2);
      }
      if (MapCardId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MapCardId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (Action != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Action);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param);
      }
      if (Param2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param2);
      }
      if (MapCardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapCardId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CGMapApplyEffect other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0UL) {
        PlayerId = other.PlayerId;
      }
      if (other.Action != 0) {
        Action = other.Action;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      if (other.Param2 != 0) {
        Param2 = other.Param2;
      }
      if (other.MapCardId != 0) {
        MapCardId = other.MapCardId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerId = input.ReadUInt64();
            break;
          }
          case 16: {
            Action = input.ReadInt32();
            break;
          }
          case 24: {
            Param = input.ReadInt32();
            break;
          }
          case 32: {
            Param2 = input.ReadInt32();
            break;
          }
          case 40: {
            MapCardId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
