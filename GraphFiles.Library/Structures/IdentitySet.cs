using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Represents a keyed collection of identity resources. It is used to represent a set of identities associated with various events for an item, such as created by or last modified by.")]
public struct IdentitySet
{
    [OSStructureField(Description = "Optional. The application associated with this action.")]
    public Identity Application;
    
    [OSStructureField(Description = "Optional. The application instance associated with this action.")]
    public Identity ApplicationInstance;

    [OSStructureField(Description = "Optional. The team or channel associated with this action.")]
    public Identity Conversation;

    [OSStructureField(Description =
        "Optional. Indicates whether the conversation property identifies a team or channel.")]
    public Identity ConversationIdentityType;
    
    [OSStructureField(Description = "Optional. The device associated with this action.")]
    public Identity Device;

    [OSStructureField(Description = "Optional. The encrypted identity associated with this action.")]
    public Identity Encrypted;
    
    [OSStructureField(Description = "Optional. The on-premises identity associated with this action.")]
    public Identity OnPremises;
    
    [OSStructureField(Description = "Optional. The guest identity associated with this action.")]
    public Identity Guest;

    [OSStructureField(Description = "Optional. The phone number associated with this action.")]
    public Identity Phone;
    
    [OSStructureField(Description = "Optional. The user associated with this action.")]
    public Identity User;
}