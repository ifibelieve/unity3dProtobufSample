//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Common/InfoMonster.proto
// Note: requires additional types generated from: Common/InfoReward.proto
// Generated from: Common/InfoPayment.proto
// Generated from: Common/InfoScene.proto
// Note: requires additional types generated from: Common/InfoMonster.proto
namespace ProtobufBundle.Protocols.PBClass.Common
{
  [ProtoBuf.ProtoContract]
  public partial class InfoScene : global::ProtoBuf.IExtensible
  {
    public InfoScene() {}
    
    private string _sceneSid;
    [global::ProtoBuf.ProtoMember(1)]
    public string sceneSid
    {
      get { return _sceneSid; }
      set { _sceneSid = value; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
