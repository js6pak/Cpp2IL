namespace LibCpp2IL.Metadata
{
    public class Il2CppFieldDefinition
    {
        public int nameIndex;
        public int typeIndex;
        [Version(Max = 24)] public int customAttributeIndex;
        public uint token;
        
        public string? Name => LibCpp2IlMain.TheMetadata == null ? null : LibCpp2IlMain.TheMetadata.GetStringFromIndex(nameIndex);

        public Il2CppTypeDefinition? FieldType => LibCpp2IlReflection.GetTypeDefinitionByTypeIndex(typeIndex);

        public int FieldIndex => LibCpp2IlReflection.GetFieldIndexFromField(this);
        
        public override string ToString()
        {
            if(LibCpp2IlMain.TheMetadata == null) return base.ToString();

            return $"Il2CppFieldDefinition[Name={Name}, FieldType={FieldType}]";
        }
    }
}