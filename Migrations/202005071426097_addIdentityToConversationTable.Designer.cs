// <auto-generated />
namespace ChatPusher.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class addIdentityToConversationTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(addIdentityToConversationTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202005071426097_addIdentityToConversationTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}