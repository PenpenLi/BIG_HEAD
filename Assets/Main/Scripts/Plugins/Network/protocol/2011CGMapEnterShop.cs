// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 2011_CGMapEnterShop.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 2011_CGMapEnterShop.proto</summary>
  public static partial class CGMapEnterShopReflection {

    #region Descriptor
    /// <summary>File descriptor for 2011_CGMapEnterShop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CGMapEnterShopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChkyMDExX0NHTWFwRW50ZXJTaG9wLnByb3RvIjQKDkNHTWFwRW50ZXJTaG9w",
            "EhEKCXBsYXllcl9pZBgBIAEoBBIPCgdzaG9wX2lkGAIgASgFQkoKHWNvbS53",
            "aGFsZWlzbGFuZC5nYW1lLnByb3RvY29sQhZDR01hcEVudGVyU2hvcFByb3Rv",
            "Y29sqgIQQmlnSGVhZC5wcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.CGMapEnterShop), global::BigHead.protocol.CGMapEnterShop.Parser, new[]{ "PlayerId", "ShopId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 在地图上使用消耗品
  /// </summary>
  public sealed partial class CGMapEnterShop : pb::IMessage<CGMapEnterShop> {
    private static readonly pb::MessageParser<CGMapEnterShop> _parser = new pb::MessageParser<CGMapEnterShop>(() => new CGMapEnterShop());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CGMapEnterShop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.CGMapEnterShopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapEnterShop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapEnterShop(CGMapEnterShop other) : this() {
      playerId_ = other.playerId_;
      shopId_ = other.shopId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGMapEnterShop Clone() {
      return new CGMapEnterShop(this);
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

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 2;
    private int shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CGMapEnterShop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CGMapEnterShop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (ShopId != other.ShopId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0UL) hash ^= PlayerId.GetHashCode();
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
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
      if (ShopId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ShopId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ShopId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CGMapEnterShop other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0UL) {
        PlayerId = other.PlayerId;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
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
            ShopId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code