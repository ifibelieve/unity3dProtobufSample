using ProtoBuf.Meta;
using ProtobufBundle.Protocols.PBClass.Common;

namespace ProtoBufSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = TypeModel.Create();
            
            model.Add(typeof(InfoScene), true);
            
            model.AllowParseableTypes = true;
            model.AutoAddMissingTypes = true;

            model.Compile("ProtoBufSerializer", "ProtoBufSerializer.dll");
        }
    }
}
